using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using GMap.NET;

namespace XLPath
{
    public partial class Form1 : Form
    {
        public static string gLink;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] addDict = new string[8];

            addDict[0] = txtAdd1.Text;
            addDict[1] = txtAdd2.Text;
            addDict[2] = txtAdd3.Text;
            addDict[3] = txtAdd4.Text;
            addDict[4] = txtAdd5.Text;
            addDict[5] = txtAdd6.Text;
            addDict[6] = txtAdd7.Text;
            addDict[7] = txtAdd8.Text;

            string url = "https://maps.googleapis.com/maps/api/directions/json?origin=Gørtlervej 13, 5230 Odense M&destination=Havnegade 65, 5000 Odense C&waypoints=optimize:true";

            foreach (string adresse in addDict)
            {
                if (adresse != "")
                {
                    url = url + "|" + adresse;
                }
                
            }

            url = url + "&key=AIzaSyA-H7XeytXNhQAM52oqioMRApGRW9_-ay0";

            
            string json = GET(url);
            //Console.WriteLine(json);
            JObject o = JObject.Parse(json);
            Console.WriteLine(o["status"]);

            dynamic status = o["status"];
            if (status == "OK")
            {
                dynamic order = o["routes"][0]["waypoint_order"];

                string GoogleUrl = "https://www.google.dk/maps/dir/Gørtlervej+13,+5230+Odense+M/";
                string result = "Rækkefølge";
                int n = 1;
                foreach (string ind in order)
                {

                    int val = Int32.Parse(ind);
                    result = result + "\n" + n + ". " + addDict[val];
                    GoogleUrl = GoogleUrl + addDict[val] + "/";
                    n = n + 1;
                }

                GoogleUrl = GoogleUrl + "Havnegade 65, 5000 Odense C/";
                gLink = GoogleUrl;

                //webMap.Url = new System.Uri("https://www.google.com/maps/embed/v1/directions?key=AIzaSyBK1fxu5KSR-66eaBTLW4XihUw2AWIgfyc&origin=Oslo+Norway&destination=Telemark+Norway&avoid=tolls|highways");
                //webMap.Navigate(GoogleUrl);
                txtRes.Text = result;
                lnkGoogle.Visible = true;
            }
            else
            {
                txtRes.Text = "Rute ikke fundet";
            }

            
        }


        string GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                System.Net.WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }

        private void lnkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(gLink);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

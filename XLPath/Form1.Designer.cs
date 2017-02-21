namespace XLPath
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.txtAdd6 = new System.Windows.Forms.TextBox();
            this.txtAdd4 = new System.Windows.Forms.TextBox();
            this.txtAdd5 = new System.Windows.Forms.TextBox();
            this.txtAdd8 = new System.Windows.Forms.TextBox();
            this.txtAdd7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRute = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lnkGoogle = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(94, 43);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(338, 20);
            this.txtAdd1.TabIndex = 0;
            this.txtAdd1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(94, 69);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(338, 20);
            this.txtAdd2.TabIndex = 1;
            // 
            // txtAdd3
            // 
            this.txtAdd3.Location = new System.Drawing.Point(94, 95);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(338, 20);
            this.txtAdd3.TabIndex = 2;
            // 
            // txtAdd6
            // 
            this.txtAdd6.Location = new System.Drawing.Point(94, 173);
            this.txtAdd6.Name = "txtAdd6";
            this.txtAdd6.Size = new System.Drawing.Size(338, 20);
            this.txtAdd6.TabIndex = 5;
            // 
            // txtAdd4
            // 
            this.txtAdd4.Location = new System.Drawing.Point(94, 121);
            this.txtAdd4.Name = "txtAdd4";
            this.txtAdd4.Size = new System.Drawing.Size(338, 20);
            this.txtAdd4.TabIndex = 3;
            // 
            // txtAdd5
            // 
            this.txtAdd5.Location = new System.Drawing.Point(94, 147);
            this.txtAdd5.Name = "txtAdd5";
            this.txtAdd5.Size = new System.Drawing.Size(338, 20);
            this.txtAdd5.TabIndex = 4;
            // 
            // txtAdd8
            // 
            this.txtAdd8.Location = new System.Drawing.Point(94, 225);
            this.txtAdd8.Name = "txtAdd8";
            this.txtAdd8.Size = new System.Drawing.Size(338, 20);
            this.txtAdd8.TabIndex = 7;
            // 
            // txtAdd7
            // 
            this.txtAdd7.Location = new System.Drawing.Point(94, 199);
            this.txtAdd7.Name = "txtAdd7";
            this.txtAdd7.Size = new System.Drawing.Size(338, 20);
            this.txtAdd7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adresse 1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adresse 7:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresse 5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adresse 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adresse 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Adresse 6:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adresse 4:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adresse 8:";
            // 
            // btnRute
            // 
            this.btnRute.Location = new System.Drawing.Point(320, 266);
            this.btnRute.Name = "btnRute";
            this.btnRute.Size = new System.Drawing.Size(112, 23);
            this.btnRute.TabIndex = 8;
            this.btnRute.Text = "Find Rute";
            this.btnRute.UseVisualStyleBackColor = true;
            this.btnRute.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRes.Location = new System.Drawing.Point(11, 285);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(0, 20);
            this.txtRes.TabIndex = 17;
            // 
            // lnkGoogle
            // 
            this.lnkGoogle.AutoSize = true;
            this.lnkGoogle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkGoogle.Location = new System.Drawing.Point(350, 309);
            this.lnkGoogle.Name = "lnkGoogle";
            this.lnkGoogle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkGoogle.Size = new System.Drawing.Size(82, 13);
            this.lnkGoogle.TabIndex = 18;
            this.lnkGoogle.TabStop = true;
            this.lnkGoogle.Text = "Rute Vejledning";
            this.lnkGoogle.Visible = false;
            this.lnkGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoogle_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(467, 575);
            this.Controls.Add(this.lnkGoogle);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnRute);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdd7);
            this.Controls.Add(this.txtAdd8);
            this.Controls.Add(this.txtAdd5);
            this.Controls.Add(this.txtAdd4);
            this.Controls.Add(this.txtAdd6);
            this.Controls.Add(this.txtAdd3);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XL Byg Rute Planlægger";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.TextBox txtAdd6;
        private System.Windows.Forms.TextBox txtAdd4;
        private System.Windows.Forms.TextBox txtAdd5;
        private System.Windows.Forms.TextBox txtAdd8;
        private System.Windows.Forms.TextBox txtAdd7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRute;
        private System.Windows.Forms.Label txtRes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel lnkGoogle;
    }
}


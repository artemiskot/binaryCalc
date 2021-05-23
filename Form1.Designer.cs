namespace bin_calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.num1cmb = new System.Windows.Forms.ComboBox();
            this.num1lab = new System.Windows.Forms.Label();
            this.num2lab = new System.Windows.Forms.Label();
            this.num2cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num3cmb = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.summ = new System.Windows.Forms.Button();
            this.diff = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.cl = new System.Windows.Forms.RichTextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 77);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 77);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(148, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 77);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 77);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(33, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 77);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(148, 302);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 77);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(263, 302);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 77);
            this.button9.TabIndex = 7;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // num1cmb
            // 
            this.num1cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num1cmb.FormattingEnabled = true;
            this.num1cmb.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.num1cmb.Location = new System.Drawing.Point(24, 80);
            this.num1cmb.Name = "num1cmb";
            this.num1cmb.Size = new System.Drawing.Size(97, 21);
            this.num1cmb.TabIndex = 10;
            // 
            // num1lab
            // 
            this.num1lab.AutoSize = true;
            this.num1lab.Location = new System.Drawing.Point(21, 61);
            this.num1lab.Name = "num1lab";
            this.num1lab.Size = new System.Drawing.Size(92, 13);
            this.num1lab.TabIndex = 13;
            this.num1lab.Text = "Первый операнд";
            // 
            // num2lab
            // 
            this.num2lab.AutoSize = true;
            this.num2lab.Location = new System.Drawing.Point(169, 61);
            this.num2lab.Name = "num2lab";
            this.num2lab.Size = new System.Drawing.Size(88, 13);
            this.num2lab.TabIndex = 15;
            this.num2lab.Text = "Второй операнд";
            // 
            // num2cmb
            // 
            this.num2cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num2cmb.FormattingEnabled = true;
            this.num2cmb.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.num2cmb.Location = new System.Drawing.Point(172, 80);
            this.num2cmb.Name = "num2cmb";
            this.num2cmb.Size = new System.Drawing.Size(97, 21);
            this.num2cmb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Результат";
            // 
            // num3cmb
            // 
            this.num3cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.num3cmb.FormattingEnabled = true;
            this.num3cmb.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.num3cmb.Location = new System.Drawing.Point(343, 80);
            this.num3cmb.Name = "num3cmb";
            this.num3cmb.Size = new System.Drawing.Size(97, 21);
            this.num3cmb.TabIndex = 16;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(389, 362);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 74);
            this.button10.TabIndex = 19;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(396, 121);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(72, 53);
            this.summ.TabIndex = 20;
            this.summ.Text = "+";
            this.summ.UseVisualStyleBackColor = true;
            this.summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(396, 180);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(72, 53);
            this.diff.TabIndex = 21;
            this.diff.Text = "-";
            this.diff.UseVisualStyleBackColor = true;
            this.diff.Click += new System.EventHandler(this.Diff_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(396, 239);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(72, 53);
            this.mult.TabIndex = 22;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // share
            // 
            this.share.Location = new System.Drawing.Point(396, 298);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(72, 53);
            this.share.TabIndex = 23;
            this.share.Text = "/";
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.Share_Click);
            // 
            // erase
            // 
            this.erase.Location = new System.Drawing.Point(263, 107);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(109, 23);
            this.erase.TabIndex = 24;
            this.erase.Text = "erase";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // cl
            // 
            this.cl.Location = new System.Drawing.Point(17, 11);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(451, 47);
            this.cl.TabIndex = 25;
            this.cl.Text = "";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(148, 385);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 77);
            this.button11.TabIndex = 26;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(33, 551);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 77);
            this.button12.TabIndex = 32;
            this.button12.Text = "D";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(148, 551);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(109, 77);
            this.button13.TabIndex = 31;
            this.button13.Text = "E";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(263, 551);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(109, 77);
            this.button14.TabIndex = 30;
            this.button14.Text = "F";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(263, 468);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(109, 77);
            this.button15.TabIndex = 29;
            this.button15.Text = "C";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(148, 468);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 77);
            this.button16.TabIndex = 28;
            this.button16.Text = "B";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(33, 467);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(109, 77);
            this.button17.TabIndex = 27;
            this.button17.Text = "A";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.Button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 663);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.share);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num3cmb);
            this.Controls.Add(this.num2lab);
            this.Controls.Add(this.num2cmb);
            this.Controls.Add(this.num1lab);
            this.Controls.Add(this.num1cmb);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox num1cmb;
        private System.Windows.Forms.Label num1lab;
        private System.Windows.Forms.Label num2lab;
        private System.Windows.Forms.ComboBox num2cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox num3cmb;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button summ;
        private System.Windows.Forms.Button diff;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.RichTextBox cl;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}


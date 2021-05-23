using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace bin_calculator
{
    public partial class Form1 : Form
    {
        int flag = 0;
        public void add_int(string s)
        {
            cl.Text += s;
        }
        public void add_sign(string s)
        {
            cl.Text += " " + s + " ";
            flag++;
        }
        public Form1()
        {
            Image myimage = new Bitmap(@"H:\bin_calculator\Umar.jpg");
            this.BackgroundImage = myimage;
            InitializeComponent();
        }
        public void write(bool a, string m)
        {
            if (flag<2)
            {
                if (a==false)
                {
                    add_int(m);
                }
                else
                {
                    add_sign(m);
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            write(false, "1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            write(false, "2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            write(false, "3");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            write(false, "4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            write(false, "5");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            write(false, "6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            write(false, "7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            write(false, "8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            write(false, "9");
        }

        private void Summ_Click(object sender, EventArgs e)
        {
            write(true, "+");
        }

        private void Diff_Click(object sender, EventArgs e)
        {
            write(true, "-");
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            write(true, "*");
        }

        private void Share_Click(object sender, EventArgs e)
        {
            write(true, "/");
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            flag = 0;
            cl.Text = "";
        }
        double converting(string syst, string num, double number) {
            switch (syst)
            {
                case "0":
                    for(int i = 0; i < num.Length; i++)
                    {
                        if (Convert.ToInt32(num[i])-48 >= 2)
                        {
                            MessageBox.Show("Вы ввели неправильное число для этой системы исчисления");
                            this.Close();
                        }
                    }
                    number = Convert.ToInt32(num, 2);
                    break;
                case "1":
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (Convert.ToInt32(num[i])-48 >= 8)
                        {
                            MessageBox.Show("Вы ввели неправильное число для этой системы исчисления");
                            this.Close();
                        }
                    }
                    number = Convert.ToInt32(num, 8);
                    break;
                case "2":
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (Convert.ToInt32(num[i])-48 >= 10)
                        {
                            MessageBox.Show("Вы ввели неправильное число для этой системы исчисления");
                            this.Close();
                        }
                    }
                    number = Convert.ToInt32(num, 10);
                    break;
                case "3":
                    for (int i = 0; i < num.Length; i++)
                    {
                        if ((!num[i].Equals('A')) && (!num[i].Equals('B')) && (!num[i].Equals('C')) && (!num[i].Equals('D')) && (!num[i].Equals('E')) && (!num[i].Equals('F')))
                        {
                            MessageBox.Show("Вы ввели неправильное число для этой системы исчисления");
                            this.Close();
                        }
                    }
                    number = Convert.ToInt32(num, 16);
                    break;
            }
            return number;
        }
        string converting2(string syst, string num, double number)
        {
            int tmp = Convert.ToInt32(number);
            switch (syst)
            {
                case "0":
                    num = Convert.ToString(tmp, 2);
                    break;
                case "1":
                    num = Convert.ToString(tmp, 8);
                    break;
                case "2":
                    num = Convert.ToString(tmp, 10);
                    break;
                case "3":
                    num = Convert.ToString(tmp, 16);
                    break;
            }
            return num;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            flag++;
            bool fl = false;
            string cl1 = cl.Text;
            string num = "";
            char sn = ' ';
            int st = 0;
            int tmp, pos = 0;
            double n1 = 0, n2 = 0;
            for (int i =0; i < cl1.Length; i++) {
                if (cl1[i] == ' ')
                {
                    sn = cl1[i + 1];
                    pos = i;
                    break;
                }
                num += cl1[i];
            }
            n1 = converting(num1cmb.SelectedIndex.ToString(), num, n1);
            st = 0;
            num = "";
            for (int i = pos+3; i < cl1.Length; i++)
            {
                num += cl1[i];
            }
            n2 = converting(num2cmb.SelectedIndex.ToString(), num, n2);
            double S;
            double tmp1;
            switch (sn)
            {
                case '+':
                    tmp1 = (n1 + n2);
                    cl.Text += " = " + converting2(num3cmb.SelectedIndex.ToString(), Convert.ToString(tmp1), tmp1);
                    break;
                case '-':
                    tmp1 = (n1 - n2);
                    cl.Text += " = " + converting2(num3cmb.SelectedIndex.ToString(), Convert.ToString(tmp1), tmp1);
                    break;
                case '*':
                    tmp1 = (n1 * n2);
                    cl.Text += " = " + converting2(num3cmb.SelectedIndex.ToString(), Convert.ToString(tmp1), tmp1);
                    break;
                case '/':
                    tmp1 = (n1 / n2);
                    cl.Text += " = " + converting2(num3cmb.SelectedIndex.ToString(), Convert.ToString(tmp1), tmp1);
                    break;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            write(false, "0");
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            write(false, "A");
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            write(false, "B");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            write(false, "C");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            write(false, "D");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            write(false, "E");
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            write(false, "F");
        }
    }
}

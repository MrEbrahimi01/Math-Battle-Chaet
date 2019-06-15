using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Math_Battle_Cheat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("button_correct").InvokeMember("Click");
            timer1.Start();
            btn_stop.Enabled = true;
            btn_start.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Url = new System.Uri(txt_link.Text, System.UriKind.Absolute);
                btn_start.Enabled = true;
                button1.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا لینک معتبر وارد کنید .");
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            cheat();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_start.Enabled = false;
            btn_stop.Enabled = false;
            button1.Enabled = true;
        }
        public void cheat()
        {
            int num1 = Convert.ToInt32(webBrowser1.Document.GetElementById("task_x").InnerHtml);
            int num2 = Convert.ToInt32(webBrowser1.Document.GetElementById("task_y").InnerHtml);
            int result = Convert.ToInt32(webBrowser1.Document.GetElementById("task_res").InnerHtml);
            string op = Convert.ToString(webBrowser1.Document.GetElementById("task_op").InnerHtml);

            switch (op)
            {
                case "/":
                    {
                        if (num1 / num2 == result)
                        {
                            webBrowser1.Document.GetElementById("button_correct").InvokeMember("Click");
                        }
                        else
                        {
                            webBrowser1.Document.GetElementById("button_wrong").InvokeMember("Click");
                        }
                    }
                    break;
                case "+":
                    {
                        if (num1 + num2 == result)
                        {
                            webBrowser1.Document.GetElementById("button_correct").InvokeMember("Click");
                        }
                        else
                        {
                            webBrowser1.Document.GetElementById("button_wrong").InvokeMember("Click");
                        }
                    }
                    break;
                case "–":
                    {
                        if (num1 - num2 == result)
                        {
                            webBrowser1.Document.GetElementById("button_correct").InvokeMember("Click");
                        }
                        else
                        {
                            webBrowser1.Document.GetElementById("button_wrong").InvokeMember("Click");
                        }
                    }
                    break;
                case "×":
                    {
                        if (num1 * num2 == result)
                        {
                            webBrowser1.Document.GetElementById("button_correct").InvokeMember("Click");
                        }
                        else
                        {
                            webBrowser1.Document.GetElementById("button_wrong").InvokeMember("Click");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

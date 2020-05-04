using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;
                b.BackColor = Color.Black;
                b.ForeColor = Color.White;
            }
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;
                b.BackColor = Color.White;
                b.ForeColor = Color.Black;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b = sender as Button;
                if (b.Text == "+" || b.Text == "-" || b.Text == "*" || b.Text == "/" || b.Text == "=")
                {
                    if (textBox1.Text.Contains("+") && textBox1.Text.Substring(0, textBox1.Text.IndexOf("+")) != "" &&
                                                       textBox1.Text.Substring(textBox1.Text.IndexOf("+") + 1) != "")
                    {
                        double x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("+"))),
                               y = Convert.ToDouble(textBox1.Text.Substring(textBox1.Text.IndexOf("+") + 1));
                        textBox1.Text = (x + y) + "";
                    }
                    else


                    if (textBox1.Text.Contains("-") && textBox1.Text.Substring(0, textBox1.Text.IndexOf("-")) != "" &&
                                                       textBox1.Text.Substring(textBox1.Text.IndexOf("-") + 1) != "")
                    {
                        double x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("-"))),
                               y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("-") + 1));
                        textBox1.Text = (x - y) + "";
                    }
                    else


                    if (textBox1.Text.Contains("*") && textBox1.Text.Substring(0, textBox1.Text.IndexOf("*")) != "" &&
                                                       textBox1.Text.Substring(0, textBox1.Text.IndexOf("*") + 1) != "")
                    {
                        double x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("*"))),
                               y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("*") + 1));
                        textBox1.Text = (x * y) + "";
                    }
                    else


                    if (textBox1.Text.Contains("/") && textBox1.Text.Substring(0, textBox1.Text.IndexOf("/")) != "" &&
                                                       textBox1.Text.Substring(0, textBox1.Text.IndexOf("/") + 1) != "")
                    {
                        double x = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("/"))),
                               y = Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.IndexOf("/") + 1));
                        textBox1.Text = (x / y) + "";
                    }

                    int n = 0;
                    for (int i = 0; i < textBox1.Text.Length; i++) if (textBox1.Text[i] == '.') n++;

                    if ((b.Text == "." && n == 1 && !textBox1.Text.Contains("+")
                                                 && !textBox1.Text.Contains("*")
                                                 && !textBox1.Text.Contains("-")
                                                 && !textBox1.Text.Contains("+")) ||

                        (b.Text == "." && n == 2 && (textBox1.Text.Contains("+") ||
                                                     textBox1.Text.Contains("*") ||
                                                     textBox1.Text.Contains("-") ||
                                                     textBox1.Text.Contains("+")))) goto A;

                    if (b.Text != "=" && b.Text != "CE" && b.Text != "C")
                        textBox1.Text += b.Text;
                    A:
                    if (b.Text == "CE") textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    else
                    if (b.Text == "C") textBox1.Text = "";
                }
            }
        }
    }
}

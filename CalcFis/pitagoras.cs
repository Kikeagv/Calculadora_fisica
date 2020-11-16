using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CalcFis
{
    public partial class pitagoras : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public pitagoras()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double result = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Pitágoras.txt", true);
            if (comboBox1.SelectedItem.ToString() == "C")
            {
                a = double.Parse(cajaA.Text);
                b = double.Parse(cajaB.Text);
                if (a > 0 && b > 0)
                {
                    result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    result = Math.Round(result, 2);
                    cajaC.Text = result.ToString();
                    sw.WriteLine("\nC= " + result);
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "A")
            {
                c = double.Parse(cajaC.Text);
                b = double.Parse(cajaB.Text);
                if (b > 0 && c > 0)
                {
                    result = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                    result = Math.Round(result, 2);
                    cajaA.Text = result.ToString();
                    sw.WriteLine("\nA= " + result);
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else
            {
                a = double.Parse(cajaA.Text);
                c = double.Parse(cajaC.Text);
                if (a > 0 && c > 0)
                {
                    result = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                    result = Math.Round(result, 2);
                    cajaB.Text = result.ToString();
                    sw.WriteLine("\nB= " + result);
                    
                }
                else
                {
                    MessageBox.Show  ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            sw.Close();
            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Pitágoras.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the lie to console window
                richTextBox1.Text += "\n" + line;
                //Read the next line
                line = sr.ReadLine();

            }
            sr.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            m1.Show();
            this.Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();

        }
    }
}

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
    public partial class centripeta : Form
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
        public centripeta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, v, r, f;
            double result = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Fuerza.txt", true);
            if (comboBox1.SelectedItem.ToString() == "Fuerza")
            {
                m = double.Parse(cajamasa.Text);
                v = double.Parse(cajavelo.Text);
                r = double.Parse(cajaradio.Text);
                if (m >= 0 && v >= 0 && r > 0)
                {
                    result = (m * Math.Pow(v, 2)) / r;
                    result = Math.Round(result, 2);
                    cajafuerza.Text = result.ToString();
                    sw.WriteLine("\nF= " + result + " N");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Masa")
            {
                v = double.Parse(cajavelo.Text);
                r = double.Parse(cajaradio.Text);
                f = double.Parse(cajafuerza.Text);
                if (f >= 0 && v >= 0 && r > 0)
                {
                    result = (f * r) / Math.Pow(v, 2);
                    result = Math.Round(result, 2);
                    cajamasa.Text = result.ToString();
                    sw.WriteLine("\nm= " + result + " kg");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Velocidad")
            {
                m = double.Parse(cajamasa.Text);
                r = double.Parse(cajaradio.Text);
                f = double.Parse(cajafuerza.Text);
                if (f >= 0 && m > 0 && r > 0)
                {
                    result = Math.Sqrt((f * r) / m);
                    result = Math.Round(result, 2);
                    cajavelo.Text = result.ToString();
                    sw.WriteLine("\nv= " + result + " m/s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else
            {
                m = double.Parse(cajamasa.Text);
                v = double.Parse(cajavelo.Text);
                f = double.Parse(cajafuerza.Text);
                if (f > 0 && m >= 0 && v >= 0)
                {
                    result = (m * Math.Pow(v, 2)) / f;
                    result = Math.Round(result, 2);
                    cajaradio.Text = result.ToString();
                    sw.WriteLine("\nr= " + result + " m");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            sw.Close();
            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Fuerza.txt");
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
            Menu1ley M1L = new Menu1ley();
            M1L.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            
        }
    }
}

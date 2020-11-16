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
    public partial class Dilatacion : Form
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
        public Dilatacion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ti, v, t;
            double result = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Dilatación.txt", true);
            if (comboBox1.SelectedItem.ToString() == "Tiempo")
            {
                ti = double.Parse(cajatimepoapo.Text);
                v = double.Parse(cajavelo.Text);
                if (ti >= 0 && v >= 0)
                {
                    double razon_lorentz = Math.Pow(v, 2) / Math.Pow(299792458, 2);
                    if (v < 299792458)
                    {
                        result = ti / Math.Sqrt(1 - razon_lorentz);
                        result = Math.Round(result, 2);
                        cajatiempo.Text = result.ToString();
                        sw.WriteLine("\nt= " + result + " s");
                        
                    }
                    else
                    {
                        MessageBox.Show ("La velocidad ingresada es mayor a la velocidad de la luz, revise por favor");
                    }
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Velocidad")
            {
                ti = double.Parse(cajatimepoapo.Text);
                t = double.Parse(cajatiempo.Text);
                if (t >= 0 && ti >= 0)
                {
                    result = 299792458 * Math.Sqrt((1 - Math.Pow(ti / t, 2)));
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
                v = double.Parse(cajavelo.Text);
                t = double.Parse(cajatiempo.Text);
                if (v >= 0 && t >= 0)
                {
                    double razon_lorentz = Math.Pow(v, 2) / Math.Pow(299792458, 2);
                    if (v < 299792458)
                    {
                        result = t * Math.Sqrt(1 - razon_lorentz);
                        result = Math.Round(result, 2);
                        cajatimepoapo.Text = result.ToString();
                        sw.WriteLine("\nti= " + result + " s");
                        
                    }
                    else
                    {
                        MessageBox.Show ("La velocidad ingresada es mayor a la velocidad de la luz, revise por favor");
                    }
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            sw.Close();
            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Dilatación.txt");
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
            Menu M1 = new Menu();
            M1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Show();

        }
    }
}

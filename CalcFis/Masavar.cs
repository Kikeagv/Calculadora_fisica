using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace CalcFis
{
    public partial class Masavar : Form
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
        public Masavar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu2ley M2L = new menu2ley();
            M2L.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mi, mv, v, a, f;
            double result = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Masavar.txt", true);
            if (comboBox1.SelectedItem.ToString() == "Fuerza")
            {
                mi = double.Parse(cajamasain.Text);
                mv = double.Parse(cajavar.Text);
                a = double.Parse(cajaacel.Text);
                v = double.Parse(cajavelo.Text);
                if (mi >= 0 && mv >= 0 && a >= 0 && v >= 0 && mi > mv)
                {
                    result = mi * a + v * mv;
                    result = Math.Round(result, 2);
                    cajafue.Text = result.ToString();
                    sw.WriteLine("\nF= " + result + " N");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Masa inicial")
            {
                mv = double.Parse(cajavar.Text);
                a = double.Parse(cajaacel.Text);
                v = double.Parse(cajavelo.Text);
                f = double.Parse(cajafue.Text);
                if (f >= 0 && mv >= 0 && a > 0 && v >= 0)
                {
                    result = (f - mv * v) / a;
                    result = Math.Round(result, 2);
                    cajamasain.Text = result.ToString();
                    sw.WriteLine("\nmi= " + result + " kg");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Variación de masa")
            {
                mi = double.Parse(cajamasain.Text);
                a = double.Parse(cajaacel.Text);
                v = double.Parse(cajavelo.Text);
                f = double.Parse(cajafue.Text);
                if (mi >= 0 && f >= 0 && v > 0 && a >= 0)
                {
                    result = (f - mi * a) / v;
                    result = Math.Round(result, 2);
                    cajavar.Text = result.ToString();
                    sw.WriteLine("\nmf= " + result + " kg");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Velocidad")
            {
                mi = double.Parse(cajamasain.Text);
                mv = double.Parse(cajavar.Text);
                a = double.Parse(cajaacel.Text);
                f = double.Parse(cajafue.Text);
                if (mi >= 0 && f >= 0 && mv > 0 && a >= 0 && mi > mv)
                {
                    result = (f - mi * a) / mv;
                    result = Math.Round(result, 2);
                    cajavelo.Text = result.ToString();
                    sw.WriteLine("\nv= " + result + " m/s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else
            {
                mi = double.Parse(cajamasain.Text);
                mv = double.Parse(cajavar.Text);
                v = double.Parse(cajavelo.Text);
                f = double.Parse(cajafue.Text);
                if (f >= 0 && mi > 0 && mv > 0 && v >= 0 && mi > mv)
                {
                    result = (f - mv * v) / mi;
                    result = Math.Round(result, 2);
                    cajaacel.Text = result.ToString();
                    sw.WriteLine("\na= " + result + " m/s2");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            sw.Close();
            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Masavar.txt");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 F10 = new Form10();
            F10.Show();
        }
    }
}

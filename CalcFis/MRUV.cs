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
    public partial class MRUV : Form
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
        public MRUV()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d, t, vi, vf, a;
            double result = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\MRUV.txt", true);
            if (comboBox1.SelectedItem.ToString() == "Velocidad final")
            {
                t = double.Parse(cajatiempo.Text);
                vi = double.Parse(cajavi.Text);
                a = double.Parse(cajaacel.Text);
                if (vi >= 0 && t >= 0 && a >= 0)
                {
                    result = vi + a * t;
                    result = Math.Round(result, 2);
                    cajavf.Text = result.ToString();
                    sw.WriteLine("\nVf " + result + " m/s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Velocidad inicial")
            {
                d = double.Parse(cajadist.Text);
                t = double.Parse(cajatiempo.Text);
                vf = double.Parse(cajavf.Text);
                a = double.Parse(cajaacel.Text);
                if (vf >= 0 && a >= 0 && t >= 0)
                {
                    result = vf - a * t;
                    result = Math.Round(result, 2);
                    cajavi.Text = result.ToString();
                    sw.WriteLine("\nVi= " + result + " m/s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Distancia")
            {
                t = double.Parse(cajatiempo.Text);
                vi = double.Parse(cajavi.Text);
                a = double.Parse(cajaacel.Text);
                if (vi >= 0 && t >= 0 && a >= 0)
                {
                    result = vi * t + (0.5) * a * (Math.Pow(t, 2));
                    result = Math.Round(result, 2);
                    cajadist.Text = result.ToString();
                    sw.WriteLine("\nd= " + result + " m");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Tiempo")
            {
                vi = double.Parse(cajavi.Text);
                vf = double.Parse(cajavf.Text);
                a = double.Parse(cajaacel.Text);
                if (vi >= 0 && vf >= 0 && a > 0)
                {
                    result = (vf - vi) / a;
                    result = Math.Round(result, 2);
                    cajatiempo.Text = result.ToString();
                    sw.WriteLine("\nt= " + result + " s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor no válido, revise por favor");
                }
            }
            else
            {
                t = double.Parse(cajatiempo.Text);
                vi = double.Parse(cajavi.Text);
                vf = double.Parse(cajavf.Text);
                if (vf >= 0 && vi >= 0 && t >= 0)
                {
                    result = (vf - vi) / t;
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
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\MRUV.txt");
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
            Form8 F8 = new Form8();
            F8.Show();
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
    }
}

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
    public partial class MRU : Form
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
        public MRU()
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
            Menu1ley M1L = new Menu1ley();
            M1L.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v, d, t;
            double result = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\MRU.txt", true);
            if (comboBox1.SelectedItem.ToString() == "Velocidad")
            {
                d = double.Parse(cajadis.Text);
                t = double.Parse(cajatiem.Text);
                if (d >= 0 && t >= 0)
                {
                    result = d / t;
                    result = Math.Round(result, 2);
                    cajavelo.Text = result.ToString();
                    sw.WriteLine("\nv= " + result + " m/s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Distancia")
            {
                v = double.Parse(cajavelo.Text);
                t = double.Parse(cajatiem.Text);
                if (v >= 0 && t >= 0)
                {
                    result = v * t;
                    result = Math.Round(result, 2);
                    cajadis.Text = result.ToString();
                    sw.WriteLine("\nd= " + result + " m");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            else
            {
                v = double.Parse(cajavelo.Text);
                d = double.Parse(cajadis.Text);
                if (v >= 0 && d >= 0)
                {
                    result = d / v;
                    result = Math.Round(result, 2);
                    cajatiem.Text = result.ToString();
                    sw.WriteLine("\nt= " + result + " s");
                    
                }
                else
                {
                    MessageBox.Show ("Ha ingresado un valor negativo, revise por favor");
                }
            }
            sw.Close();
            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\MRU.txt");
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
            Form7 F7 = new Form7();
            F7.Show();

        }
    }
}

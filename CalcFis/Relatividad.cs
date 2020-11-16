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
    public partial class Relatividad : Form
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
        public Relatividad()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            Menu m1 = new Menu();
            m1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double energia = 0;
            double masa = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Relatividad.txt", true);
            energia = double.Parse(cajaenergia.Text);
            masa = double.Parse(cajamasa.Text);
            
            if (comboBox1.SelectedItem.ToString() == "Energía")
                if(masa >=0)
            {
                energia = masa * Math.Pow(2.9979e10, 2);    
                energia = Math.Round(energia ,2);
                cajaenergia.Text = energia.ToString();
                sw.WriteLine("\nE= " + energia + " J");
                
            }
            else
            {
                    MessageBox.Show("Ha ingresado un valor de masa negativo");
            }
            else
                if (energia >=0)
            {
                masa = energia / Math.Pow(2.9979e10, 2);
                cajamasa.Text = masa.ToString();
                sw.WriteLine("\nM= " + masa + " Kg");
            }
            else
            {
                MessageBox.Show("Ha ingresado un valor de energia negativo");
            }
            sw.Close();

            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Relatividad.txt");
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }
    }
}

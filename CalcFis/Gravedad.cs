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
    public partial class Gravedad : Form
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
        public Gravedad()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

        }

        private void Gravedad_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Energia";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double F = 0;
            double M1 = 0;
            double M2 = 0;
            double R = 0;
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\Gravedad.txt", true);
            F = double.Parse(cajaf.Text);
            M1 = double.Parse(cajam1.Text);
            M2 = double.Parse(cajam2.Text);
            R = double.Parse(cajar.Text);
            if (comboBox1.SelectedItem.ToString() == "Fuerza")
            
                if (M1 >= 0 && M2 >= 0 && R >= 0)
                {
                    F = ((6.6720e-08)*((M1 * M2) / (Math.Pow(R, 2))));
                   
                    cajaf.Text = F.ToString();
                    sw.WriteLine("\nF= " + F + " N");
                }
                else
                {
                    MessageBox.Show("Ha ingresado un valor negativo");
                }
                
            if (comboBox1.SelectedItem.ToString() == "Masa 1")
            
                if (F >= 0 && R >=0 && M2 >=0)
                {
                    M1 = (F * Math.Pow(R,2)) / ((6.6720e-08) * M2);
                    M1 = Math.Round(M1, 2);
                    cajam1.Text = M1.ToString();
                    sw.WriteLine("\nM1= " + M1 + " Kg");

                }
                else
                {
                    MessageBox.Show("Ha ingresado un valor negativo");
                }
            

            if (comboBox1.SelectedItem.ToString() == "Masa 2")
            
                if (F >= 0 && R >=0 && M1 >=0)
                {
                    M2 = ((F * Math.Pow(R,2)) / ((6.6720e-08) * M1));
                    M2 = Math.Round(M2, 2);
                    cajam2.Text = M2.ToString();
                    sw.WriteLine("\nM2= " + M2 + " Kg");

                }
                else
                {
                    MessageBox.Show("Ha ingresado un valor negativo");
                }

                    if (comboBox1.SelectedItem.ToString() == "Radio")
                    
                        if (M1 >= 0 && M2 >= 0)
                        {
                    R = Math.Sqrt(((6.6720e-08)) * ((M1 * M2) / F));
                    R = Math.Round(R, 2);
                            cajar.Text = R.ToString();
                            sw.WriteLine("\nR= " + R + " m");
                        }
                        else
                        {
                            MessageBox.Show("Ha ingresado un valor negativo");
                        }
                    
               sw.Close();

            richTextBox1.Text = "";
            String line;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\Gravedad.txt");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            m1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
           
        }
    }
            }
        
    


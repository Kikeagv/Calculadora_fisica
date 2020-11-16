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
using System.Security.Cryptography.X509Certificates;

namespace CalcFis
{
    public partial class Registro : Form
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
        public Registro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

       

        private void registrar_Click(object sender, EventArgs e)
        {
            String user, pass;
            bool correctpass = false;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\datosalumnos.txt");
            user = sr.ReadLine();
            pass = sr.ReadLine();
            while (user != null)
            {
                if (cajarecar.Text == user || cajarecar.Text == "" || cajaregcont.Text == "")
                {
                    MessageBox.Show("Usuario ya registrado");
                    correctpass = true;
                    break;

                }
                else
                {
                    user = sr.ReadLine();
                    pass = sr.ReadLine();
                    

                }
            }
            sr.Close();
            if (correctpass == false)
                    {
                
                StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "\\datosalumnos.txt", true);
                        sw.WriteLine(cajarecar.Text + "\n" + cajaregcont.Text);
                        sw.Close();
                        StreamReader se = new StreamReader(Environment.CurrentDirectory + "\\datosalumnos.txt");
                        se.Close();
                        MessageBox.Show("Usuario registrado con exito");
                        
                }
            
            

            }
            
        




    

    private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuDoc MD1 = new MenuDoc();
            MD1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
    }
}

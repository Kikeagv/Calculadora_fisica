using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CalcFis
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }


        private void Entrar_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.CurrentDirectory + "\\Masavar.txt");
            File.Delete(Environment.CurrentDirectory + "\\Masacons.txt");
            File.Delete(Environment.CurrentDirectory + "\\MRUV.txt");
            File.Delete(Environment.CurrentDirectory + "\\MRU.txt");
            File.Delete(Environment.CurrentDirectory + "\\Fuerza.txt");
            File.Delete(Environment.CurrentDirectory + "\\Dilatación.txt");
            File.Delete(Environment.CurrentDirectory + "\\Pitágoras.txt");
            File.Delete(Environment.CurrentDirectory + "\\Gravedad.txt");
            File.Delete(Environment.CurrentDirectory + "\\Relatividad.txt");
            String user, pass;
            bool correctpass = false;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\datosalumnos.txt");
            user = sr.ReadLine();
            pass = sr.ReadLine();
            while (user != null)
            {
                if (CajaCarnet.Text == user && CajaContra.Text == pass)
                {
                    Menu m = new Menu();
                    m.Show();
                    correctpass = true;
                    this.Hide();
                    break;
                    
                }
                else
                {
                    user = sr.ReadLine();
                    pass = sr.ReadLine();
                }
            }
            if (correctpass == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regis_Click(object sender, EventArgs e)
        {
            logdoc lgd1 = new logdoc();
            lgd1.Show();
            this.Hide();
        }
    }
}

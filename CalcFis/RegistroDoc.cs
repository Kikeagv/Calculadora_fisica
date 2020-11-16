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

namespace CalcFis
{
    public partial class RegistroDoc : Form
    {
        public RegistroDoc()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuDoc MD = new MenuDoc();
            MD.Show();
            this.Hide();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            String user, pass;
            bool correctpass = false;
            StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\datosdocentes.txt");
            user = sr.ReadLine();
            pass = sr.ReadLine();
            while (user != null)
            {
                if (cajarecardo.Text == user || cajarecardo.Text == "" || cajarecondo.Text == "")
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

                

            }
        }
    }
}

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

namespace CalcFis
{
    public partial class Menu : Form
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
        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relatividad r1 = new Relatividad();
            r1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gravedad_Click(object sender, EventArgs e)
        {
            Gravedad g1 = new Gravedad();
            g1.Show();
            this.Hide();
        }

        private void pita_Click(object sender, EventArgs e)
        {
            pitagoras p1 = new pitagoras();
            p1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void dilatacion_Click(object sender, EventArgs e)
        {
            Dilatacion Dila = new Dilatacion();
            Dila.Show();
            this.Hide();
        }

        private void newton1_Click(object sender, EventArgs e)
        {
            Menu1ley M1L = new Menu1ley();
            M1L.Show();
            this.Hide();
        }

        private void newton2_Click(object sender, EventArgs e)
        {
            menu2ley M2L = new menu2ley();
            M2L.Show();
            this.Hide();
        }
    }
}

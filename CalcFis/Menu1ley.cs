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
    public partial class Menu1ley : Form
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
        public Menu1ley()
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
            Menu M1 = new Menu();
            M1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            centripeta CEN = new centripeta();
            CEN.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MRU MRU = new MRU();
            MRU.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MRUV MRUV = new MRUV();
            MRUV.Show();
            this.Close();
        }
    }
}

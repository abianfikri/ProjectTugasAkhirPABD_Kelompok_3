using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Home_Admin : Form
    {
        public Home_Admin()
        {
            InitializeComponent();
        }

        private void apoteker_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Apoteker().Show();
        }

        private void obat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Obat().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

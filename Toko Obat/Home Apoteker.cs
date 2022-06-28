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
    public partial class Home_Apoteker : Form
    {
        public Home_Apoteker()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pembeli().Show();
        }

        private void Data_Pengelolaan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Data_Pengelolaan_Obat().Show();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transaksi().Show();
        }
    }
}

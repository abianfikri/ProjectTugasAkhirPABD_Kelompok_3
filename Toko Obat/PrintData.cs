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
    public partial class PrintData : Form
    {
        public PrintData()
        {
            InitializeComponent();
        }

        private void PrintData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Toko_ObatDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.TransaksiTableAdapter.Fill(this.Toko_ObatDataSet.Transaksi);

            this.reportViewer1.RefreshReport();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transaksi().Show();
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transaksi().Show();
        }
    }
}

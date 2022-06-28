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
    public partial class Pembeli : Form
    {
        public Pembeli()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_Apoteker().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = false;

            Id_Pembeli.Text = "";
            nama_pemebeli.Text = "";

            Id_Pembeli.Focus();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;


        }

        private void Update_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = true;
            Delete.Enabled = false;
        }
    }
}

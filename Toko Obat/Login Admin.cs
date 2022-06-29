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
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
            //Ini admin
        }

        private void lg_Aptoker_Click(object sender, EventArgs e)
        {
            // Waktu Klik Button Login Apoteker
            this.Hide();
            new Login_Apoteker().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (user_admin.Text.Equals("") || pass_admin.Text.Equals(""))
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (user_admin.Text.Equals("Admin") && pass_admin.Text.Equals("Admin123"))
            {
                this.Hide();
                new Home_Admin().Show();
            }
            else
            {
                MessageBox.Show("Periksa Kembali Username dan Password Anda !!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Login_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

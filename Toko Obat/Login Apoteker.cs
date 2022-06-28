using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Login_Apoteker : Form
    {
        public Login_Apoteker()
        {
            InitializeComponent();
        }

        private void lg_Aptoker_Click(object sender, EventArgs e)
        {

        }

        private void lg_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Admin().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login Aplikasi Apoteker
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Apoteker where Id_Apoteker = '" + user_apoteker.Text + "' AND Nama_Apoteker = '"+pass_apoteker.Text+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                this.Hide();
                new Home_Apoteker().Show();
            }
            else
            {
                MessageBox.Show("Mohon isi username dan password dengan benar !!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Apoteker_Load(object sender, EventArgs e)
        {

        }
    }
}

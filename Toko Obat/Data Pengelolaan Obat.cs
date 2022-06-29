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
    public partial class Data_Pengelolaan_Obat : Form
    {
        public Data_Pengelolaan_Obat()
        {
            InitializeComponent();
            Fill_Combo_Apoteker();
            Fill_Combo_Obat();
        }

        void Fill_Combo_Apoteker()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlCommand query = new SqlCommand("Select * From Apoteker", conn);
            SqlDataAdapter sda = new SqlDataAdapter(query);

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                id_apoteker.DisplayMember = "Id_Apoteker";
                id_apoteker.DataSource = dt;
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        void Fill_Combo_Obat()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlCommand query = new SqlCommand("Select * From Obat", conn);
            SqlDataAdapter sda = new SqlDataAdapter(query);

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                kode_obat.DisplayMember = "Kode_Obat";
                kode_obat.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        private void Data_Pengelolaan_Obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_ObatDataSetOBAT.Data_Pengelolaan_Obat' table. You can move, or remove it, as needed.
            this.data_Pengelolaan_ObatTableAdapter1.Fill(this.toko_ObatDataSetOBAT.Data_Pengelolaan_Obat);
            // TODO: This line of code loads data into the 'toko_ObatDataSet.Data_Pengelolaan_Obat' table. You can move, or remove it, as needed.

            nama_obat.Enabled = false;
            harga.Enabled = false;
            jenis_obat.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            kode_pengelolaan.Text = "";
            kode_obat.Text = "";
            id_apoteker.Text = "";
            nama_obat.Text = "";
            jenis_obat.Text = "";
            kadaluarsa.Text = "";
            harga.Text = "";
            efek_samping.Text = "";
            cara_penggunaan.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlCommand query = new SqlCommand("Select * From Obat where Kode_Obat = '"+kode_obat.Text+"'", conn);
            SqlDataReader sdr;

            try
            {
                conn.Open();
                sdr = query.ExecuteReader();
                while (sdr.Read())
                {
                    nama_obat.Text = sdr.GetString(1);
                    jenis_obat.Text = sdr.GetString(2);
                    harga.Text = sdr.GetInt32(3).ToString();
                }
            }
            catch (Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Pembeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pembeli().Show();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transaksi().Show();
        }

        private void Data_Pengelolaan_Click(object sender, EventArgs e)
        {

        }
    }
}

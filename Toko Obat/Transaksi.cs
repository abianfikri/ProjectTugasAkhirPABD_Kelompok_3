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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
            Fill_Combo_Obat();
            Fill_Combo_Pembeli();
        }

        // Insert Data
        void insertData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            try
            {
                conn.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO Transaksi (Kode_Transaksi, Id_Pembeli, Kode_Obat, Nama_Obat, Tgl_Transaksi, Qty, Harga_Satuan, Total_Harga) VALUES" +
                    "('" + kode_transaksi.Text + "', '" + id_pembeli.Text + "', '" + kode_obat.Text + "', '" + nama_obat.Text + "', '" + tgl_transaksi.Value + "', '" + qty.Text + "', '" + harga.Text + "'," +
                    "'" + totalHarga.Text + "')", conn);
                insert.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Success Save Data");
                getData();
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        // getData
        void getData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            try
            {
                conn.Open();
                SqlCommand show = new SqlCommand("SELECT * FROM Transaksi", conn);
                SqlDataAdapter sda = new SqlDataAdapter(show);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        // Update Data
        void updateData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");

            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("Update Transaksi set Kode_Transaksi = '" + kode_transaksi.Text + "', Id_Pembeli = '" + id_pembeli.Text + "', Kode_Obat = '" + kode_obat.Text + "', Nama_Obat = '" + nama_obat.Text + "', " +
                    "Tgl_Transaksi = '" + tgl_transaksi.Value + "', Qty = '" + qty.Text + "', Harga_Satuan = '" + harga.Text + "', Total_Harga = '" + totalHarga.Text + "' WHERE Kode_Transaksi = '" + kode_transaksi.Text + "'", conn);
                query.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Success Edit Data");
                getData();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        void deleteData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");

            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("DELETE Transaksi WHERE Kode_Transaksi = '"+kode_transaksi.Text+"'", conn);
                query.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Success Delete Data");
                getData();
            }
            catch(Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }


        // ComboBox Obat
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

        // ComboBox Pembeli
        void Fill_Combo_Pembeli()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlCommand query = new SqlCommand("Select * From Pembeli", conn);
            SqlDataAdapter sda = new SqlDataAdapter(query);

            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                id_pembeli.DisplayMember = "Id_Pembeli";
                id_pembeli.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }



        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_ObatDataSet.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.toko_ObatDataSet.Transaksi);
            nama_obat.Enabled = false;
            harga.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_Apoteker().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    harga.Text = sdr.GetInt32(3).ToString();
                }
            }
            catch(Exception et)
            {
                MessageBox.Show(et.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = false;
            nama_obat.Enabled = false;
            harga.Enabled = false;

            kode_obat.Text = "";
            nama_obat.Text = "";
            kode_transaksi.Text = "";
            id_pembeli.Text = "";
            tgl_transaksi.Text = "";
            qty.Text = "";
            harga.Text = "";
            totalHarga.Text = "";

            kode_transaksi.Focus();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            Add.Enabled = true;
            Create.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;

            insertData();
            conn.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = true;

            updateData();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                kode_transaksi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id_pembeli.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                kode_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                nama_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                tgl_transaksi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                qty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                harga.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                totalHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            }
        }
    }
}

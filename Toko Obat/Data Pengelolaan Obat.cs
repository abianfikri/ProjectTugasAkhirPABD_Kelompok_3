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

        /*Insert Data*/
        void insertData()
        {
            SqlConnection koneksi = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");

            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand("EXEC insertData_Pengelolaan_Obat  '"+kode_pengelolaan.Text+"', '"+id_apoteker.Text+"', '"+kode_obat.Text+"', '"+nama_obat.Text+"', '"+jenis_obat.Text+"', " +
                "'"+kadaluarsa.Value+"', '"+harga.Text+"', '"+efek_samping.Text+"', '"+cara_penggunaan.Text+"'", koneksi);
      
                cmd.ExecuteNonQuery();
                getData();
                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan");
            }
            catch(Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        void getData()
        {
            SqlConnection koneksi = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");

            koneksi.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Data_Pengelolaan_Obat", koneksi);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void updateData()
        {
            SqlConnection koneksi = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");

            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand("EXEC updateData_Pengelolaan_Obat '" + kode_pengelolaan.Text + "', '" + id_apoteker.Text + "'," +
                    "'" + kode_obat.Text + "', '" + nama_obat.Text + "', '" + jenis_obat.Text + "', '" + kadaluarsa.Value + "'," +
                    " '" + harga.Text + "', '" + efek_samping.Text + "', '" + cara_penggunaan.Text + "'", koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                getData();
                MessageBox.Show("Success Edit Data");
            }
            catch(Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        void deleteData()
        {
            SqlConnection koneksi = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");

            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand("DELETE Data_Pengelolaan_Obat WHERE Kode_Pengelolaan = '" + kode_pengelolaan.Text + "'", koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                getData();
                MessageBox.Show("Success Delete Data");
            }
            catch(Exception u)
            {
                MessageBox.Show(u.Message);
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
            insertData();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteData();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                kode_pengelolaan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                id_apoteker.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                kode_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                nama_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                jenis_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                kadaluarsa.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                harga.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                efek_samping.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                cara_penggunaan.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            }
        }
    }
}

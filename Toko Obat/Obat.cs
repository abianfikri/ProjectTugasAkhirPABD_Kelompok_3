using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Obat : Form
    {
        public Obat()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            kode_obat.Text = "";
            nama_obat.Text = "";
            jenis_obat.Text = "";
            harga.Text = "";

            kode_obat.Focus();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            createData();
        }

        void createData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand com = new SqlCommand("insert into Obat values(@Kode_Obat, @Nama_Obat, @Jenis_Obat, @Harga)", conn);
            com.Parameters.AddWithValue("@Kode_Obat", kode_obat.Text);
            com.Parameters.AddWithValue("@Nama_Obat", nama_obat.Text);
            com.Parameters.AddWithValue("@Jenis_Obat", jenis_obat.Text);
            com.Parameters.AddWithValue("@Harga", harga.Text);
            com.ExecuteNonQuery();
            LoadAllRecords();
            conn.Close();
            MessageBox.Show("Berhasil Ditambahkan!");
        }

        void LoadAllRecords()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand com = new SqlCommand("Select * from Obat", conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        void updateData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand com = new SqlCommand("Update Obat set Kode_Obat=@Kode_Obat, Nama_Obat=@Nama_Obat, Jenis_Obat=@Jenis_Obat, Harga=@Harga where Kode_Obat = @Kode_Obat", conn);
            com.Parameters.AddWithValue("@Kode_Obat", kode_obat.Text);
            com.Parameters.AddWithValue("@Nama_Obat", nama_obat.Text);
            com.Parameters.AddWithValue("@Jenis_Obat", jenis_obat.Text);
            com.Parameters.AddWithValue("@Harga", harga.Text);
            com.ExecuteNonQuery();

            LoadAllRecords();
            conn.Close();
            MessageBox.Show("Berhasil Diupdate!");
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        void deleteData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand com = new SqlCommand("Delete Obat where Kode_Obat=@Kode_Obat", conn);
            com.Parameters.AddWithValue("@Kode_Obat", kode_obat.Text);
            com.ExecuteNonQuery();
            LoadAllRecords();
            conn.Close();
            MessageBox.Show("Berhasil Dihapus!");
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                kode_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                nama_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                jenis_obat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                harga.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private void Obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_ObatDataSetOBAT.Obat' table. You can move, or remove it, as needed.
            this.obatTableAdapter1.Fill(this.toko_ObatDataSetOBAT.Obat);
            // TODO: This line of code loads data into the 'toko_ObatDataSet.Obat' table. You can move, or remove it, as needed.

            kode_obat.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Apoteker().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Admin().Show();
        }
    }
}

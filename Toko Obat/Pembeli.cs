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
    public partial class Pembeli : Form
    {
        public Pembeli()
        {
            InitializeComponent();
        }

        void insertData ()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            try
            {
                conn.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO Pembeli (Id_Pembeli, Nama_Pembeli) VALUES" +
                    "('"+ Id_Pembeli.Text + "', '" + Nama_Pembeli.Text +"')", conn);
                insert.ExecuteNonQuery();
                conn.Close();
                getData();
                MessageBox.Show("Success Save Data");
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }

        void getData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            try
            {
                conn.Open();
                SqlCommand show = new SqlCommand("SELECT * FROM Pembeli", conn);
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

        void updateData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Pembeli set Id_Pembeli = @Id_Pembeli, Nama_Pembeli = @Nama_Pembeli where Id_Pembeli = @Id_Pembeli", conn);
            cmd.Parameters.AddWithValue("@Id_Pembeli", Id_Pembeli.Text);
            cmd.Parameters.AddWithValue("@Nama_Pembeli", Nama_Pembeli.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            getData();
            MessageBox.Show("Sukses Update");
        }

        void deleteData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete Pembeli where Id_Pembeli = @Id_Pembeli", conn);
            cmd.Parameters.AddWithValue("@Id_Pembeli", Id_Pembeli.Text);
            cmd.ExecuteNonQuery();
            getData();
            conn.Close();
            MessageBox.Show("Berhasil hapus");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            

            Id_Pembeli.Text = "";
            Nama_Pembeli.Text = "";

            Id_Pembeli.Focus();

        }

        private void Create_Click(object sender, EventArgs e)
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

        private void Id_Pembeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_ObatDataSet.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.toko_ObatDataSet.Pembeli);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                Id_Pembeli.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Nama_Pembeli.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
        }

        private void data_Pengelolaan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Data_Pengelolaan_Obat().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transaksi().Show();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pembeli Where Nama_Pembeli LIKE  '%" + search.Text + "%' OR Id_Pembeli LIKE '%" + search.Text + "%' ", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }
    }

}

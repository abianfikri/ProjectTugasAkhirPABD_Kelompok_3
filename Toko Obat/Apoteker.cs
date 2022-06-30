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
    public partial class Apoteker : Form
    {
        public Apoteker()
        {
            InitializeComponent();
        }

        void createData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Apoteker values (@Id_Apoteker, @Nama_Apoteker, @Alamat, @No_Telp)", conn);
            cmd.Parameters.AddWithValue("@Id_Apoteker", id_apoteker.Text);
            cmd.Parameters.AddWithValue("@Nama_Apoteker", nama_apoteker.Text);
            cmd.Parameters.AddWithValue("@Alamat", alamat.Text);
            cmd.Parameters.AddWithValue("@No_Telp", no_telp.Text);
            cmd.ExecuteNonQuery();
            getData();
            conn.Close();
            MessageBox.Show("Sukses ditambahkan");
        }

        void getData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Apoteker", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void updateData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Apoteker set Nama_Apoteker=@Nama_Apoteker, Alamat=@Alamat, No_Telp=@No_Telp where ID_Apoteker=@ID_Apoteker", conn);
            cmd.Parameters.AddWithValue("@Id_Apoteker", id_apoteker.Text);
            cmd.Parameters.AddWithValue("@Nama_Apoteker", nama_apoteker.Text);
            cmd.Parameters.AddWithValue("@Alamat", alamat.Text);
            cmd.Parameters.AddWithValue("@No_Telp", no_telp.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            getData();
            MessageBox.Show("Sukses Update");
        }

        void deleteData()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlCommand cmd = new SqlCommand("Delete Apoteker where Id_Apoteker=@Id_Apoteker", conn);
            cmd.Parameters.AddWithValue("@Id_Apoteker", id_apoteker.Text);
            cmd.ExecuteNonQuery();
            getData();
            conn.Close();
            MessageBox.Show("Berhasil hapus");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            

            id_apoteker.Text = "";
            nama_apoteker.Text = "";
            alamat.Text = "";
            no_telp.Text = "";

            id_apoteker.Focus();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            createData();


        }

        private void Update_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apoteker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_ObatDataSet.Apoteker' table. You can move, or remove it, as needed.
            this.apotekerTableAdapter.Fill(this.toko_ObatDataSet.Apoteker);

            id_apoteker.Focus();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                id_apoteker.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                nama_apoteker.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                alamat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                no_telp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private void obat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Obat().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}

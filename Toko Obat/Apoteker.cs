using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Apoteker : Form
    {
        

        
        public Apoteker()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source = MEGANE\\ALDYAHMADFAUZI; database=Toko_Obat;" +
               "User ID=sa;Password=Kacamatahitam4321");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Apoteker", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void Create_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source = MEGANE\\ALDYAHMADFAUZI; database=Toko_Obat;" +
                "User ID=sa;Password=Kacamatahitam4321");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Apoteker values (@Id_Apoteker, @Nama_Apoteker, @Alamat, @No_Telp)",conn);
            cmd.Parameters.AddWithValue("@Id_Apoteker",textBox1.Text);
            cmd.Parameters.AddWithValue("@Nama_Apoteker", textBox2.Text);
            cmd.Parameters.AddWithValue("@Alamat", textBox3.Text);
            cmd.Parameters.AddWithValue("@No_Telp", textBox4.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Sukses ditambahkan");

            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source = MEGANE\\ALDYAHMADFAUZI; database=Toko_Obat;" +
                "User ID=sa;Password=Kacamatahitam4321");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Apoteker set Nama_Apoteker=@Nama_Apoteker, Alamat=@Alamat, No_Telp=@No_Telp where ID_Apoteker=@ID_Apoteker",conn);
            cmd.Parameters.AddWithValue("@Id_Apoteker", textBox1.Text);
            cmd.Parameters.AddWithValue("@Nama_Apoteker", textBox2.Text);
            cmd.Parameters.AddWithValue("@Alamat", textBox3.Text);
            cmd.Parameters.AddWithValue("@No_Telp", textBox4.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Sukses Update");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source = MEGANE\\ALDYAHMADFAUZI; database=Toko_Obat;" +
                "User ID=sa;Password=Kacamatahitam4321");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete Apoteker where Id_Apoteker=@Id_Apoteker", conn);
            cmd.Parameters.AddWithValue("@Id_Apoteker", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Berhasil hapus");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_Admin().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apoteker_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

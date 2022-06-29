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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O1VMEB\\ZAKI;Initial Catalog=Toko_Obat;User ID=sa;Password=atharizaki123");
            try
            {
                conn.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO Pembeli (Id_Pembeli, Nama_Pembeli) VALUES" +
                    "('"+ Id_Pembeli.Text + "', '" + Nama_Pembeli +"')", conn);
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

        void getData()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O1VMEB\\ZAKI;Initial Catalog=Toko_Obat;User ID=sa;Password=atharizaki123");
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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O1VMEB\\ZAKI;Initial Catalog=Toko_Obat;User ID=sa;Password=atharizaki123");
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
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3O1VMEB\\ZAKI;Initial Catalog=Toko_Obat;User ID=sa;Password=atharizaki123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete Pembeli where Id_Pembeli = @Id_Pembeli", conn);
            cmd.Parameters.AddWithValue("@Id_Pembeli", Id_Pembeli.Text);
            cmd.ExecuteNonQuery();
            getData();
            conn.Close();
            MessageBox.Show("Berhasil hapus");
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
            Nama_Pembeli.Text = "";

            Id_Pembeli.Focus();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;

            insertData();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = true;

            updateData();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = true;
            Delete.Enabled = false;

            deleteData();
        }

        private void Id_Pembeli_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

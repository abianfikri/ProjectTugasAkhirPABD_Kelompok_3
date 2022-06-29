﻿using System;
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
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
            com.Parameters.AddWithValue("@Kode_Obat", textBox1.Text);
            com.Parameters.AddWithValue("@Nama_Obat", textBox2.Text);
            com.Parameters.AddWithValue("@Jenis_Obat", textBox3.Text);
            com.Parameters.AddWithValue("@Harga", textBox4.Text);
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
            SqlCommand com = new SqlCommand("Update Obat set Kode_Obat=@Kode_Obat, Nama_Obat=@Nama_Obat, Jenis_Obat=@Jenis_Obat, Harga=@Harga", conn);
            com.Parameters.AddWithValue("@Kode_Obat", textBox1.Text);
            com.Parameters.AddWithValue("@Nama_Obat", textBox2.Text);
            com.Parameters.AddWithValue("@Jenis_Obat", textBox3.Text);
            com.Parameters.AddWithValue("@Harga", textBox4.Text);
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
            com.Parameters.AddWithValue("@Kode_Obat", textBox1.Text);
            com.ExecuteNonQuery();
            LoadAllRecords();
            conn.Close();
            MessageBox.Show("Berhasil Dihapus!");
        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_Admin().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }
    }
}

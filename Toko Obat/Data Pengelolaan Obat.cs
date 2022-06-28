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

                comboBox1.DisplayMember = "Id_Apoteker";
                comboBox1.DataSource = dt;
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

                comboBox2.DisplayMember = "Kode_Obat";
                comboBox2.DataSource = dt;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        private void Data_Pengelolaan_Obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_ObatDataSet.Data_Pengelolaan_Obat' table. You can move, or remove it, as needed.
            this.data_Pengelolaan_ObatTableAdapter.Fill(this.toko_ObatDataSet.Data_Pengelolaan_Obat);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home_Apoteker().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = false;
            Update.Enabled = true;
            Delete.Enabled = true;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Add.Enabled = true;
            Create.Enabled = true;
            Update.Enabled = true;
            Delete.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add.Enabled = false;
            Create.Enabled = true;
            Update.Enabled = false;
            Delete.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-91VJ4BQG;Initial Catalog=Toko_Obat;User ID=sa;Password=abianfikri");
            SqlCommand query = new SqlCommand("Select * From Obat where Kode_Obat = '"+comboBox2.SelectedItem.ToString()+"'", conn);
            conn.Open();
            query.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(query);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                textBox6.Text = dr["Kode_Obat"].ToString();
            }
            conn.Close();
        }
    }
}

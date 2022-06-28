using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lg_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Admin().Show();
        }

        private void lg_Aptoker_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Apoteker().Show();
        }
    }
}

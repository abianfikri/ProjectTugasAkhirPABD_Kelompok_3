
namespace Toko_Obat
{
    partial class Pembeli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Id_Pembeli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nama_Pembeli = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.Add = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.pembeliTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.PembeliTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_Pengelolaan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Transaksi = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_Pembeli
            // 
            this.Id_Pembeli.Location = new System.Drawing.Point(432, 94);
            this.Id_Pembeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id_Pembeli.Name = "Id_Pembeli";
            this.Id_Pembeli.Size = new System.Drawing.Size(159, 22);
            this.Id_Pembeli.TabIndex = 0;
            this.Id_Pembeli.TextChanged += new System.EventHandler(this.Id_Pembeli_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Pembeli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Pembeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Pembeli";
            // 
            // Nama_Pembeli
            // 
            this.Nama_Pembeli.Location = new System.Drawing.Point(432, 151);
            this.Nama_Pembeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nama_Pembeli.Name = "Nama_Pembeli";
            this.Nama_Pembeli.Size = new System.Drawing.Size(159, 22);
            this.Nama_Pembeli.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPembeliDataGridViewTextBoxColumn,
            this.namaPembeliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pembeliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(306, 287);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(609, 175);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idPembeliDataGridViewTextBoxColumn
            // 
            this.idPembeliDataGridViewTextBoxColumn.DataPropertyName = "Id_Pembeli";
            this.idPembeliDataGridViewTextBoxColumn.HeaderText = "Id_Pembeli";
            this.idPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPembeliDataGridViewTextBoxColumn.Name = "idPembeliDataGridViewTextBoxColumn";
            // 
            // namaPembeliDataGridViewTextBoxColumn
            // 
            this.namaPembeliDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pembeli";
            this.namaPembeliDataGridViewTextBoxColumn.HeaderText = "Nama_Pembeli";
            this.namaPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPembeliDataGridViewTextBoxColumn.Name = "namaPembeliDataGridViewTextBoxColumn";
            // 
            // pembeliBindingSource
            // 
            this.pembeliBindingSource.DataMember = "Pembeli";
            this.pembeliBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // toko_ObatDataSet
            // 
            this.toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(788, 75);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 31);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(788, 121);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 31);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(788, 171);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 31);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(788, 226);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 31);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pembeliTableAdapter
            // 
            this.pembeliTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.data_Pengelolaan);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Transaksi);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 481);
            this.panel1.TabIndex = 27;
            // 
            // data_Pengelolaan
            // 
            this.data_Pengelolaan.Location = new System.Drawing.Point(12, 167);
            this.data_Pengelolaan.Name = "data_Pengelolaan";
            this.data_Pengelolaan.Size = new System.Drawing.Size(206, 39);
            this.data_Pengelolaan.TabIndex = 15;
            this.data_Pengelolaan.Text = "Data Pengelolaan Obat";
            this.data_Pengelolaan.UseVisualStyleBackColor = true;
            this.data_Pengelolaan.Click += new System.EventHandler(this.data_Pengelolaan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(12, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 39);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pembeli";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Transaksi
            // 
            this.Transaksi.Location = new System.Drawing.Point(12, 287);
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Size = new System.Drawing.Size(206, 39);
            this.Transaksi.TabIndex = 12;
            this.Transaksi.Text = "Transaksi";
            this.Transaksi.UseVisualStyleBackColor = true;
            this.Transaksi.Click += new System.EventHandler(this.Transaksi_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Toko_Obat.Properties.Resources.Apoteker;
            this.pictureBox2.Location = new System.Drawing.Point(63, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(306, 256);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(186, 22);
            this.search.TabIndex = 33;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Pembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1021, 481);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nama_Pembeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_Pembeli);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pembeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembeli";
            this.Load += new System.EventHandler(this.Pembeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_Pembeli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nama_Pembeli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource pembeliBindingSource;
        private Toko_ObatDataSetTableAdapters.PembeliTableAdapter pembeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Transaksi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button data_Pengelolaan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox search;
    }
}
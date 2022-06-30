
namespace Toko_Obat
{
    partial class Transaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.kode_transaksi = new System.Windows.Forms.TextBox();
            this.kode_obat = new System.Windows.Forms.ComboBox();
            this.id_pembeli = new System.Windows.Forms.ComboBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.totalHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.Add = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.tgl_transaksi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nama_obat = new System.Windows.Forms.TextBox();
            this.transaksiTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.TransaksiTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_pengelolaan = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.Pembeli = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hitung = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Transaksi";
            // 
            // kode_transaksi
            // 
            this.kode_transaksi.Location = new System.Drawing.Point(428, 89);
            this.kode_transaksi.Name = "kode_transaksi";
            this.kode_transaksi.Size = new System.Drawing.Size(121, 22);
            this.kode_transaksi.TabIndex = 1;
            // 
            // kode_obat
            // 
            this.kode_obat.FormattingEnabled = true;
            this.kode_obat.Location = new System.Drawing.Point(428, 162);
            this.kode_obat.Name = "kode_obat";
            this.kode_obat.Size = new System.Drawing.Size(121, 24);
            this.kode_obat.TabIndex = 2;
            this.kode_obat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // id_pembeli
            // 
            this.id_pembeli.FormattingEnabled = true;
            this.id_pembeli.Location = new System.Drawing.Point(428, 122);
            this.id_pembeli.Name = "id_pembeli";
            this.id_pembeli.Size = new System.Drawing.Size(121, 24);
            this.id_pembeli.TabIndex = 3;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(810, 125);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(121, 22);
            this.qty.TabIndex = 5;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(1048, 122);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(121, 22);
            this.harga.TabIndex = 6;
            // 
            // totalHarga
            // 
            this.totalHarga.Location = new System.Drawing.Point(810, 207);
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(121, 22);
            this.totalHarga.TabIndex = 7;
            this.totalHarga.TextChanged += new System.EventHandler(this.totalHarga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kode Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kode Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Pembeli";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(697, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tgl Transaksi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(698, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(946, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga Satuan";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(697, 210);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 17);
            this.label.TabIndex = 15;
            this.label.Text = "Total Harga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeTransaksiDataGridViewTextBoxColumn,
            this.idPembeliDataGridViewTextBoxColumn,
            this.kodeObatDataGridViewTextBoxColumn,
            this.namaObatDataGridViewTextBoxColumn,
            this.tglTransaksiDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(301, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 204);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kodeTransaksiDataGridViewTextBoxColumn
            // 
            this.kodeTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Kode_Transaksi";
            this.kodeTransaksiDataGridViewTextBoxColumn.HeaderText = "Kode_Transaksi";
            this.kodeTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeTransaksiDataGridViewTextBoxColumn.Name = "kodeTransaksiDataGridViewTextBoxColumn";
            // 
            // idPembeliDataGridViewTextBoxColumn
            // 
            this.idPembeliDataGridViewTextBoxColumn.DataPropertyName = "Id_Pembeli";
            this.idPembeliDataGridViewTextBoxColumn.HeaderText = "Id_Pembeli";
            this.idPembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPembeliDataGridViewTextBoxColumn.Name = "idPembeliDataGridViewTextBoxColumn";
            // 
            // kodeObatDataGridViewTextBoxColumn
            // 
            this.kodeObatDataGridViewTextBoxColumn.DataPropertyName = "Kode_Obat";
            this.kodeObatDataGridViewTextBoxColumn.HeaderText = "Kode_Obat";
            this.kodeObatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeObatDataGridViewTextBoxColumn.Name = "kodeObatDataGridViewTextBoxColumn";
            // 
            // namaObatDataGridViewTextBoxColumn
            // 
            this.namaObatDataGridViewTextBoxColumn.DataPropertyName = "Nama_Obat";
            this.namaObatDataGridViewTextBoxColumn.HeaderText = "Nama_Obat";
            this.namaObatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaObatDataGridViewTextBoxColumn.Name = "namaObatDataGridViewTextBoxColumn";
            // 
            // tglTransaksiDataGridViewTextBoxColumn
            // 
            this.tglTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.HeaderText = "Tgl_Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglTransaksiDataGridViewTextBoxColumn.Name = "tglTransaksiDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // hargaSatuanDataGridViewTextBoxColumn
            // 
            this.hargaSatuanDataGridViewTextBoxColumn.DataPropertyName = "Harga_Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.HeaderText = "Harga_Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaSatuanDataGridViewTextBoxColumn.Name = "hargaSatuanDataGridViewTextBoxColumn";
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "Transaksi";
            this.transaksiBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // toko_ObatDataSet
            // 
            this.toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(391, 288);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 33);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(527, 288);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 33);
            this.Create.TabIndex = 18;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(653, 288);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 33);
            this.Update.TabIndex = 19;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(778, 288);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 33);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tgl_transaksi
            // 
            this.tgl_transaksi.Location = new System.Drawing.Point(810, 82);
            this.tgl_transaksi.Name = "tgl_transaksi";
            this.tgl_transaksi.Size = new System.Drawing.Size(237, 22);
            this.tgl_transaksi.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nama Obat";
            // 
            // nama_obat
            // 
            this.nama_obat.Location = new System.Drawing.Point(428, 212);
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.Size = new System.Drawing.Size(121, 22);
            this.nama_obat.TabIndex = 23;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.data_pengelolaan);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.Pembeli);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 546);
            this.panel1.TabIndex = 27;
            // 
            // data_pengelolaan
            // 
            this.data_pengelolaan.Location = new System.Drawing.Point(12, 171);
            this.data_pengelolaan.Name = "data_pengelolaan";
            this.data_pengelolaan.Size = new System.Drawing.Size(206, 39);
            this.data_pengelolaan.TabIndex = 15;
            this.data_pengelolaan.Text = "Data Pengelolaan Obat";
            this.data_pengelolaan.UseVisualStyleBackColor = true;
            this.data_pengelolaan.Click += new System.EventHandler(this.data_pengelolaan_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Red;
            this.logout.Location = new System.Drawing.Point(12, 409);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(206, 39);
            this.logout.TabIndex = 14;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Pembeli
            // 
            this.Pembeli.Location = new System.Drawing.Point(12, 226);
            this.Pembeli.Name = "Pembeli";
            this.Pembeli.Size = new System.Drawing.Size(206, 39);
            this.Pembeli.TabIndex = 13;
            this.Pembeli.Text = "Pembeli";
            this.Pembeli.UseVisualStyleBackColor = true;
            this.Pembeli.Click += new System.EventHandler(this.Pembeli_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(12, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Transaksi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(810, 162);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(75, 29);
            this.hitung.TabIndex = 28;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(922, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(919, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Search";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1300, 548);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nama_obat);
            this.Controls.Add(this.tgl_transaksi);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalHarga);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.id_pembeli);
            this.Controls.Add(this.kode_obat);
            this.Controls.Add(this.kode_transaksi);
            this.Controls.Add(this.label1);
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kode_transaksi;
        private System.Windows.Forms.ComboBox kode_obat;
        private System.Windows.Forms.ComboBox id_pembeli;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox totalHarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DateTimePicker tgl_transaksi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nama_obat;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private Toko_ObatDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button data_pengelolaan;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button Pembeli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}
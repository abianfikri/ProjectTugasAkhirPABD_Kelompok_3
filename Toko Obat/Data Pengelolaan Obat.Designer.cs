
namespace Toko_Obat
{
    partial class Data_Pengelolaan_Obat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodePengelolaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idApotekerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglKadaluwarsaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efekSampingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caraPenggunaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPengelolaanObatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSetOBAT = new Toko_Obat.Toko_ObatDataSetOBAT();
            this.kode_pengelolaan = new System.Windows.Forms.TextBox();
            this.jenis_obat = new System.Windows.Forms.TextBox();
            this.id_apoteker = new System.Windows.Forms.ComboBox();
            this.kode_obat = new System.Windows.Forms.ComboBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.efek_samping = new System.Windows.Forms.TextBox();
            this.cara_penggunaan = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.dataPengelolaanObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Pengelolaan_ObatTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.Data_Pengelolaan_ObatTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.nama_obat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Pembeli = new System.Windows.Forms.Button();
            this.Transaksi = new System.Windows.Forms.Button();
            this.Data_Pengelolaan = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kadaluarsa = new System.Windows.Forms.DateTimePicker();
            this.data_Pengelolaan_ObatTableAdapter1 = new Toko_Obat.Toko_ObatDataSetOBATTableAdapters.Data_Pengelolaan_ObatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPengelolaanObatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSetOBAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPengelolaanObatBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pengelolaan Obat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodePengelolaanDataGridViewTextBoxColumn,
            this.idApotekerDataGridViewTextBoxColumn,
            this.kodeObatDataGridViewTextBoxColumn,
            this.namaObatDataGridViewTextBoxColumn,
            this.jenisObatDataGridViewTextBoxColumn,
            this.tglKadaluwarsaDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.efekSampingDataGridViewTextBoxColumn,
            this.caraPenggunaanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataPengelolaanObatBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(251, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // kodePengelolaanDataGridViewTextBoxColumn
            // 
            this.kodePengelolaanDataGridViewTextBoxColumn.DataPropertyName = "Kode_Pengelolaan";
            this.kodePengelolaanDataGridViewTextBoxColumn.HeaderText = "Kode_Pengelolaan";
            this.kodePengelolaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePengelolaanDataGridViewTextBoxColumn.Name = "kodePengelolaanDataGridViewTextBoxColumn";
            // 
            // idApotekerDataGridViewTextBoxColumn
            // 
            this.idApotekerDataGridViewTextBoxColumn.DataPropertyName = "Id_Apoteker";
            this.idApotekerDataGridViewTextBoxColumn.HeaderText = "Id_Apoteker";
            this.idApotekerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idApotekerDataGridViewTextBoxColumn.Name = "idApotekerDataGridViewTextBoxColumn";
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
            // jenisObatDataGridViewTextBoxColumn
            // 
            this.jenisObatDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Obat";
            this.jenisObatDataGridViewTextBoxColumn.HeaderText = "Jenis_Obat";
            this.jenisObatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisObatDataGridViewTextBoxColumn.Name = "jenisObatDataGridViewTextBoxColumn";
            // 
            // tglKadaluwarsaDataGridViewTextBoxColumn
            // 
            this.tglKadaluwarsaDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Kadaluwarsa";
            this.tglKadaluwarsaDataGridViewTextBoxColumn.HeaderText = "Tgl_Kadaluwarsa";
            this.tglKadaluwarsaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglKadaluwarsaDataGridViewTextBoxColumn.Name = "tglKadaluwarsaDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // efekSampingDataGridViewTextBoxColumn
            // 
            this.efekSampingDataGridViewTextBoxColumn.DataPropertyName = "Efek_Samping";
            this.efekSampingDataGridViewTextBoxColumn.HeaderText = "Efek_Samping";
            this.efekSampingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.efekSampingDataGridViewTextBoxColumn.Name = "efekSampingDataGridViewTextBoxColumn";
            // 
            // caraPenggunaanDataGridViewTextBoxColumn
            // 
            this.caraPenggunaanDataGridViewTextBoxColumn.DataPropertyName = "Cara_Penggunaan";
            this.caraPenggunaanDataGridViewTextBoxColumn.HeaderText = "Cara_Penggunaan";
            this.caraPenggunaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caraPenggunaanDataGridViewTextBoxColumn.Name = "caraPenggunaanDataGridViewTextBoxColumn";
            // 
            // dataPengelolaanObatBindingSource1
            // 
            this.dataPengelolaanObatBindingSource1.DataMember = "Data_Pengelolaan_Obat";
            this.dataPengelolaanObatBindingSource1.DataSource = this.toko_ObatDataSetOBAT;
            // 
            // toko_ObatDataSetOBAT
            // 
            this.toko_ObatDataSetOBAT.DataSetName = "Toko_ObatDataSetOBAT";
            this.toko_ObatDataSetOBAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kode_pengelolaan
            // 
            this.kode_pengelolaan.Location = new System.Drawing.Point(492, 74);
            this.kode_pengelolaan.Name = "kode_pengelolaan";
            this.kode_pengelolaan.Size = new System.Drawing.Size(121, 22);
            this.kode_pengelolaan.TabIndex = 2;
            // 
            // jenis_obat
            // 
            this.jenis_obat.Location = new System.Drawing.Point(492, 195);
            this.jenis_obat.Name = "jenis_obat";
            this.jenis_obat.Size = new System.Drawing.Size(189, 22);
            this.jenis_obat.TabIndex = 3;
            // 
            // id_apoteker
            // 
            this.id_apoteker.FormattingEnabled = true;
            this.id_apoteker.Location = new System.Drawing.Point(492, 104);
            this.id_apoteker.Name = "id_apoteker";
            this.id_apoteker.Size = new System.Drawing.Size(121, 24);
            this.id_apoteker.TabIndex = 5;
            this.id_apoteker.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kode_obat
            // 
            this.kode_obat.FormattingEnabled = true;
            this.kode_obat.Location = new System.Drawing.Point(492, 137);
            this.kode_obat.Name = "kode_obat";
            this.kode_obat.Size = new System.Drawing.Size(121, 24);
            this.kode_obat.TabIndex = 6;
            this.kode_obat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(852, 101);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(131, 22);
            this.harga.TabIndex = 7;
            // 
            // efek_samping
            // 
            this.efek_samping.Location = new System.Drawing.Point(852, 137);
            this.efek_samping.Name = "efek_samping";
            this.efek_samping.Size = new System.Drawing.Size(213, 22);
            this.efek_samping.TabIndex = 8;
            // 
            // cara_penggunaan
            // 
            this.cara_penggunaan.Location = new System.Drawing.Point(852, 172);
            this.cara_penggunaan.Name = "cara_penggunaan";
            this.cara_penggunaan.Size = new System.Drawing.Size(213, 22);
            this.cara_penggunaan.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(461, 275);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 40);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(617, 275);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 40);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(764, 275);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 40);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(901, 275);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 40);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kode Pengelolaan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Apoteker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kode Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jenis Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tgl Kadaluarsa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(726, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(726, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Efek Samping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cara Penggunaan";
            // 
            // toko_ObatDataSet
            // 
            this.toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataPengelolaanObatBindingSource
            // 
            this.dataPengelolaanObatBindingSource.DataMember = "Data_Pengelolaan_Obat";
            this.dataPengelolaanObatBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // data_Pengelolaan_ObatTableAdapter
            // 
            this.data_Pengelolaan_ObatTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nama Obat";
            // 
            // nama_obat
            // 
            this.nama_obat.Location = new System.Drawing.Point(492, 167);
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.Size = new System.Drawing.Size(189, 22);
            this.nama_obat.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Pembeli);
            this.panel1.Controls.Add(this.Transaksi);
            this.panel1.Controls.Add(this.Data_Pengelolaan);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 509);
            this.panel1.TabIndex = 26;
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Data_Pengelolaan
            // 
            this.Data_Pengelolaan.BackColor = System.Drawing.Color.Gray;
            this.Data_Pengelolaan.Location = new System.Drawing.Point(12, 165);
            this.Data_Pengelolaan.Name = "Data_Pengelolaan";
            this.Data_Pengelolaan.Size = new System.Drawing.Size(206, 39);
            this.Data_Pengelolaan.TabIndex = 11;
            this.Data_Pengelolaan.Text = "Data Pengelolan Obat";
            this.Data_Pengelolaan.UseVisualStyleBackColor = false;
            this.Data_Pengelolaan.Click += new System.EventHandler(this.Data_Pengelolaan_Click);
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
            // kadaluarsa
            // 
            this.kadaluarsa.Location = new System.Drawing.Point(852, 69);
            this.kadaluarsa.Name = "kadaluarsa";
            this.kadaluarsa.Size = new System.Drawing.Size(213, 22);
            this.kadaluarsa.TabIndex = 27;
            // 
            // data_Pengelolaan_ObatTableAdapter1
            // 
            this.data_Pengelolaan_ObatTableAdapter1.ClearBeforeFill = true;
            // 
            // Data_Pengelolaan_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1231, 509);
            this.Controls.Add(this.kadaluarsa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nama_obat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.cara_penggunaan);
            this.Controls.Add(this.efek_samping);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.kode_obat);
            this.Controls.Add(this.id_apoteker);
            this.Controls.Add(this.jenis_obat);
            this.Controls.Add(this.kode_pengelolaan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pengelolaan_Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data_Pengelolaan_Obat";
            this.Load += new System.EventHandler(this.Data_Pengelolaan_Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPengelolaanObatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSetOBAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPengelolaanObatBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kode_pengelolaan;
        private System.Windows.Forms.TextBox jenis_obat;
        private System.Windows.Forms.ComboBox id_apoteker;
        private System.Windows.Forms.ComboBox kode_obat;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox efek_samping;
        private System.Windows.Forms.TextBox cara_penggunaan;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource dataPengelolaanObatBindingSource;
        private Toko_ObatDataSetTableAdapters.Data_Pengelolaan_ObatTableAdapter data_Pengelolaan_ObatTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nama_obat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Pembeli;
        private System.Windows.Forms.Button Transaksi;
        private System.Windows.Forms.Button Data_Pengelolaan;
        private System.Windows.Forms.DateTimePicker kadaluarsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePengelolaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApotekerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglKadaluwarsaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efekSampingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caraPenggunaanDataGridViewTextBoxColumn;
        private Toko_ObatDataSetOBAT toko_ObatDataSetOBAT;
        private System.Windows.Forms.BindingSource dataPengelolaanObatBindingSource1;
        private Toko_ObatDataSetOBATTableAdapters.Data_Pengelolaan_ObatTableAdapter data_Pengelolaan_ObatTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}
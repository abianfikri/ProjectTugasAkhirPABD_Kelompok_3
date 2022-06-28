
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
            this.kode_pengelolaan = new System.Windows.Forms.TextBox();
            this.jenis_obat = new System.Windows.Forms.TextBox();
            this.kadaluarsa = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.dataPengelolaanObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Pengelolaan_ObatTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.Data_Pengelolaan_ObatTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.nama_obat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPengelolaanObatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pengelolaan Obat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // kode_pengelolaan
            // 
            this.kode_pengelolaan.Location = new System.Drawing.Point(142, 74);
            this.kode_pengelolaan.Name = "kode_pengelolaan";
            this.kode_pengelolaan.Size = new System.Drawing.Size(121, 22);
            this.kode_pengelolaan.TabIndex = 2;
            // 
            // jenis_obat
            // 
            this.jenis_obat.Location = new System.Drawing.Point(142, 195);
            this.jenis_obat.Name = "jenis_obat";
            this.jenis_obat.Size = new System.Drawing.Size(121, 22);
            this.jenis_obat.TabIndex = 3;
            // 
            // kadaluarsa
            // 
            this.kadaluarsa.Location = new System.Drawing.Point(502, 69);
            this.kadaluarsa.Name = "kadaluarsa";
            this.kadaluarsa.Size = new System.Drawing.Size(121, 22);
            this.kadaluarsa.TabIndex = 4;
            // 
            // id_apoteker
            // 
            this.id_apoteker.FormattingEnabled = true;
            this.id_apoteker.Location = new System.Drawing.Point(142, 104);
            this.id_apoteker.Name = "id_apoteker";
            this.id_apoteker.Size = new System.Drawing.Size(121, 24);
            this.id_apoteker.TabIndex = 5;
            this.id_apoteker.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kode_obat
            // 
            this.kode_obat.FormattingEnabled = true;
            this.kode_obat.Location = new System.Drawing.Point(142, 137);
            this.kode_obat.Name = "kode_obat";
            this.kode_obat.Size = new System.Drawing.Size(121, 24);
            this.kode_obat.TabIndex = 6;
            this.kode_obat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(502, 101);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(121, 22);
            this.harga.TabIndex = 7;
            // 
            // efek_samping
            // 
            this.efek_samping.Location = new System.Drawing.Point(502, 137);
            this.efek_samping.Name = "efek_samping";
            this.efek_samping.Size = new System.Drawing.Size(121, 22);
            this.efek_samping.TabIndex = 8;
            // 
            // cara_penggunaan
            // 
            this.cara_penggunaan.Location = new System.Drawing.Point(502, 172);
            this.cara_penggunaan.Name = "cara_penggunaan";
            this.cara_penggunaan.Size = new System.Drawing.Size(121, 22);
            this.cara_penggunaan.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(165, 277);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 40);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(321, 277);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 40);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(468, 277);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 40);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(605, 277);
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
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kode Pengelolaan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Apoteker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kode Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jenis Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kadaluarsa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Efek Samping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cara Penggunaan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toko_Obat.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.label10.Location = new System.Drawing.Point(12, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Nama Obat";
            // 
            // nama_obat
            // 
            this.nama_obat.Location = new System.Drawing.Point(142, 167);
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.Size = new System.Drawing.Size(121, 22);
            this.nama_obat.TabIndex = 24;
            // 
            // Data_Pengelolaan_Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nama_obat);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.kadaluarsa);
            this.Controls.Add(this.jenis_obat);
            this.Controls.Add(this.kode_pengelolaan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Data_Pengelolaan_Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data_Pengelolaan_Obat";
            this.Load += new System.EventHandler(this.Data_Pengelolaan_Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPengelolaanObatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox kode_pengelolaan;
        private System.Windows.Forms.TextBox jenis_obat;
        private System.Windows.Forms.TextBox kadaluarsa;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource dataPengelolaanObatBindingSource;
        private Toko_ObatDataSetTableAdapters.Data_Pengelolaan_ObatTableAdapter data_Pengelolaan_ObatTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nama_obat;
    }
}
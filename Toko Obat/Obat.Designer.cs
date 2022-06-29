
namespace Toko_Obat
{
    partial class Obat
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
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.TextBox();
            this.nama_obat = new System.Windows.Forms.TextBox();
            this.kode_obat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obatBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tokoObatDataSetOBATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSetOBAT = new Toko_Obat.Toko_ObatDataSetOBAT();
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.obatTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.ObatTableAdapter();
            this.obatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.obatTableAdapter1 = new Toko_Obat.Toko_ObatDataSetOBATTableAdapters.ObatTableAdapter();
            this.jenis_obat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoObatDataSetOBATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSetOBAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(799, 248);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 27);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(799, 202);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 27);
            this.Update.TabIndex = 24;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(799, 156);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 27);
            this.Create.TabIndex = 23;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(799, 105);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 27);
            this.Add.TabIndex = 22;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(493, 269);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(133, 22);
            this.harga.TabIndex = 21;
            // 
            // nama_obat
            // 
            this.nama_obat.Location = new System.Drawing.Point(493, 157);
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.Size = new System.Drawing.Size(133, 22);
            this.nama_obat.TabIndex = 19;
            // 
            // kode_obat
            // 
            this.kode_obat.Location = new System.Drawing.Point(493, 107);
            this.kode_obat.Name = "kode_obat";
            this.kode_obat.Size = new System.Drawing.Size(133, 22);
            this.kode_obat.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jenis Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nama Obat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kode Obat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeObatDataGridViewTextBoxColumn,
            this.namaObatDataGridViewTextBoxColumn,
            this.jenisObatDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obatBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(304, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 150);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // obatBindingSource3
            // 
            this.obatBindingSource3.DataMember = "Obat";
            this.obatBindingSource3.DataSource = this.tokoObatDataSetOBATBindingSource;
            // 
            // tokoObatDataSetOBATBindingSource
            // 
            this.tokoObatDataSetOBATBindingSource.DataSource = this.toko_ObatDataSetOBAT;
            this.tokoObatDataSetOBATBindingSource.Position = 0;
            // 
            // toko_ObatDataSetOBAT
            // 
            this.toko_ObatDataSetOBAT.DataSetName = "Toko_ObatDataSetOBAT";
            this.toko_ObatDataSetOBAT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // toko_ObatDataSet
            // 
            this.toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // obatBindingSource1
            // 
            this.obatBindingSource1.DataMember = "Obat";
            this.obatBindingSource1.DataSource = this.toko_ObatDataSet;
            // 
            // obatBindingSource2
            // 
            this.obatBindingSource2.DataMember = "Obat";
            this.obatBindingSource2.DataSource = this.toko_ObatDataSet;
            // 
            // obatTableAdapter1
            // 
            this.obatTableAdapter1.ClearBeforeFill = true;
            // 
            // jenis_obat
            // 
            this.jenis_obat.Location = new System.Drawing.Point(493, 208);
            this.jenis_obat.Name = "jenis_obat";
            this.jenis_obat.Size = new System.Drawing.Size(133, 22);
            this.jenis_obat.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 498);
            this.panel1.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Halo Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Toko_Obat.Properties.Resources.Admin_Bulat;
            this.pictureBox2.Location = new System.Drawing.Point(68, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(19, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(18, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apoteker";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(19, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Obat";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(999, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.jenis_obat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.nama_obat);
            this.Controls.Add(this.kode_obat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obat";
            this.Load += new System.EventHandler(this.Obat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoObatDataSetOBATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSetOBAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox nama_obat;
        private System.Windows.Forms.TextBox kode_obat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private Toko_ObatDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private System.Windows.Forms.BindingSource obatBindingSource1;
        private System.Windows.Forms.BindingSource obatBindingSource2;
        private System.Windows.Forms.BindingSource tokoObatDataSetOBATBindingSource;
        private Toko_ObatDataSetOBAT toko_ObatDataSetOBAT;
        private System.Windows.Forms.BindingSource obatBindingSource3;
        private Toko_ObatDataSetOBATTableAdapters.ObatTableAdapter obatTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox jenis_obat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
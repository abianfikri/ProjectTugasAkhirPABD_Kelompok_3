﻿
namespace Toko_Obat
{
    partial class Apoteker
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_apoteker = new System.Windows.Forms.TextBox();
            this.nama_apoteker = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.no_telp = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idApotekerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaApotekerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apotekerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.apotekerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apotekerTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.ApotekerTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.obat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Apoteker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Apoteker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Telpon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(563, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Apoteker";
            // 
            // id_apoteker
            // 
            this.id_apoteker.Location = new System.Drawing.Point(453, 71);
            this.id_apoteker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_apoteker.Name = "id_apoteker";
            this.id_apoteker.Size = new System.Drawing.Size(183, 22);
            this.id_apoteker.TabIndex = 5;
            this.id_apoteker.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nama_apoteker
            // 
            this.nama_apoteker.Location = new System.Drawing.Point(453, 118);
            this.nama_apoteker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nama_apoteker.Name = "nama_apoteker";
            this.nama_apoteker.Size = new System.Drawing.Size(183, 22);
            this.nama_apoteker.TabIndex = 6;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(453, 163);
            this.alamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(183, 22);
            this.alamat.TabIndex = 7;
            // 
            // no_telp
            // 
            this.no_telp.Location = new System.Drawing.Point(453, 200);
            this.no_telp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_telp.Name = "no_telp";
            this.no_telp.Size = new System.Drawing.Size(183, 22);
            this.no_telp.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(775, 66);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 27);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(775, 116);
            this.Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 27);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(775, 163);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 27);
            this.Update.TabIndex = 11;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(775, 209);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 27);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idApotekerDataGridViewTextBoxColumn,
            this.namaApotekerDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apotekerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(307, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 185);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idApotekerDataGridViewTextBoxColumn
            // 
            this.idApotekerDataGridViewTextBoxColumn.DataPropertyName = "Id_Apoteker";
            this.idApotekerDataGridViewTextBoxColumn.HeaderText = "Id_Apoteker";
            this.idApotekerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idApotekerDataGridViewTextBoxColumn.Name = "idApotekerDataGridViewTextBoxColumn";
            // 
            // namaApotekerDataGridViewTextBoxColumn
            // 
            this.namaApotekerDataGridViewTextBoxColumn.DataPropertyName = "Nama_Apoteker";
            this.namaApotekerDataGridViewTextBoxColumn.HeaderText = "Nama_Apoteker";
            this.namaApotekerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaApotekerDataGridViewTextBoxColumn.Name = "namaApotekerDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            // 
            // apotekerBindingSource
            // 
            this.apotekerBindingSource.DataMember = "Apoteker";
            this.apotekerBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // toko_ObatDataSet
            // 
            this.toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apotekerBindingSource1
            // 
            this.apotekerBindingSource1.DataMember = "Apoteker";
            this.apotekerBindingSource1.DataSource = this.toko_ObatDataSet;
            // 
            // apotekerTableAdapter
            // 
            this.apotekerTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.obat);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 506);
            this.panel1.TabIndex = 14;
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
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(18, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Apoteker";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // obat
            // 
            this.obat.Location = new System.Drawing.Point(19, 227);
            this.obat.Name = "obat";
            this.obat.Size = new System.Drawing.Size(223, 39);
            this.obat.TabIndex = 6;
            this.obat.Text = "Obat";
            this.obat.UseVisualStyleBackColor = true;
            this.obat.Click += new System.EventHandler(this.obat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Search";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(307, 284);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(186, 22);
            this.search.TabIndex = 35;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Apoteker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1048, 507);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.no_telp);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama_apoteker);
            this.Controls.Add(this.id_apoteker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Apoteker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apoteker";
            this.Load += new System.EventHandler(this.Apoteker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_apoteker;
        private System.Windows.Forms.TextBox nama_apoteker;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox no_telp;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource apotekerBindingSource;
        private Toko_ObatDataSetTableAdapters.ApotekerTableAdapter apotekerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApotekerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaApotekerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource apotekerBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button obat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox search;
    }
}
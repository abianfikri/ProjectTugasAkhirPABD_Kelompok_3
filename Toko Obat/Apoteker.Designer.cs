
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
            this.apotekerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.apotekerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.apotekerTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.ApotekerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Apoteker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Apoteker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Telpon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Apoteker";
            // 
            // id_apoteker
            // 
            this.id_apoteker.Location = new System.Drawing.Point(208, 64);
            this.id_apoteker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_apoteker.Name = "id_apoteker";
            this.id_apoteker.Size = new System.Drawing.Size(133, 22);
            this.id_apoteker.TabIndex = 5;
            this.id_apoteker.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nama_apoteker
            // 
            this.nama_apoteker.Location = new System.Drawing.Point(208, 114);
            this.nama_apoteker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nama_apoteker.Name = "nama_apoteker";
            this.nama_apoteker.Size = new System.Drawing.Size(133, 22);
            this.nama_apoteker.TabIndex = 6;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(208, 162);
            this.alamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(133, 22);
            this.alamat.TabIndex = 7;
            // 
            // no_telp
            // 
            this.no_telp.Location = new System.Drawing.Point(208, 209);
            this.no_telp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_telp.Name = "no_telp";
            this.no_telp.Size = new System.Drawing.Size(133, 22);
            this.no_telp.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(517, 64);
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
            this.Create.Location = new System.Drawing.Point(517, 114);
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
            this.Update.Location = new System.Drawing.Point(517, 161);
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
            this.Delete.Location = new System.Drawing.Point(517, 207);
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
            this.dataGridView1.Location = new System.Drawing.Point(59, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 150);
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
            // apotekerBindingSource1
            // 
            this.apotekerBindingSource1.DataMember = "Apoteker";
            this.apotekerBindingSource1.DataSource = this.toko_ObatDataSet;
            // 
            // toko_ObatDataSet
            // 
            this.toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apotekerBindingSource
            // 
            this.apotekerBindingSource.DataMember = "Apoteker";
            this.apotekerBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toko_Obat.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // apotekerTableAdapter
            // 
            this.apotekerTableAdapter.ClearBeforeFill = true;
            // 
            // Apoteker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotekerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource apotekerBindingSource;
        private Toko_ObatDataSetTableAdapters.ApotekerTableAdapter apotekerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApotekerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaApotekerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource apotekerBindingSource1;
    }
}
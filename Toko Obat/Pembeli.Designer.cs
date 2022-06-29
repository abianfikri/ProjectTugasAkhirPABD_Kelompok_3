
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
            this.Add = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.pembeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembeliTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.PembeliTableAdapter();
            this.idPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_Pembeli
            // 
            this.Id_Pembeli.Location = new System.Drawing.Point(173, 112);
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
            this.label1.Location = new System.Drawing.Point(315, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Pembeli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Pembeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Pembeli";
            // 
            // Nama_Pembeli
            // 
            this.Nama_Pembeli.Location = new System.Drawing.Point(173, 159);
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
            this.dataGridView1.Location = new System.Drawing.Point(115, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 175);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(592, 94);
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
            this.Create.Location = new System.Drawing.Point(592, 130);
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
            this.Update.Location = new System.Drawing.Point(592, 167);
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
            this.Delete.Location = new System.Drawing.Point(592, 204);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 31);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toko_Obat.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // pembeliBindingSource
            // 
            this.pembeliBindingSource.DataMember = "Pembeli";
            this.pembeliBindingSource.DataSource = this.toko_ObatDataSet;
            // 
            // pembeliTableAdapter
            // 
            this.pembeliTableAdapter.ClearBeforeFill = true;
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
            // Pembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembeliBindingSource)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private Toko_ObatDataSet toko_ObatDataSet;
        private System.Windows.Forms.BindingSource pembeliBindingSource;
        private Toko_ObatDataSetTableAdapters.PembeliTableAdapter pembeliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPembeliDataGridViewTextBoxColumn;
    }
}

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
            this.Add = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.tgl_transaksi = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nama_obat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Transaksi";
            // 
            // kode_transaksi
            // 
            this.kode_transaksi.Location = new System.Drawing.Point(132, 79);
            this.kode_transaksi.Name = "kode_transaksi";
            this.kode_transaksi.Size = new System.Drawing.Size(121, 22);
            this.kode_transaksi.TabIndex = 1;
            // 
            // kode_obat
            // 
            this.kode_obat.FormattingEnabled = true;
            this.kode_obat.Location = new System.Drawing.Point(132, 152);
            this.kode_obat.Name = "kode_obat";
            this.kode_obat.Size = new System.Drawing.Size(121, 24);
            this.kode_obat.TabIndex = 2;
            this.kode_obat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // id_pembeli
            // 
            this.id_pembeli.FormattingEnabled = true;
            this.id_pembeli.Location = new System.Drawing.Point(132, 112);
            this.id_pembeli.Name = "id_pembeli";
            this.id_pembeli.Size = new System.Drawing.Size(121, 24);
            this.id_pembeli.TabIndex = 3;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(414, 112);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(121, 22);
            this.qty.TabIndex = 5;
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(414, 159);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(121, 22);
            this.harga.TabIndex = 6;
            // 
            // totalHarga
            // 
            this.totalHarga.Location = new System.Drawing.Point(414, 201);
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(121, 22);
            this.totalHarga.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kode Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kode Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Pembeli";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tgl Transaksi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Harga Satuan";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(302, 202);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 17);
            this.label.TabIndex = 15;
            this.label.Text = "Total Harga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 161);
            this.dataGridView1.TabIndex = 16;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(132, 278);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 33);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(292, 278);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 33);
            this.Create.TabIndex = 18;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(439, 278);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 33);
            this.Update.TabIndex = 19;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(587, 278);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 33);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // tgl_transaksi
            // 
            this.tgl_transaksi.Location = new System.Drawing.Point(414, 79);
            this.tgl_transaksi.Name = "tgl_transaksi";
            this.tgl_transaksi.Size = new System.Drawing.Size(237, 22);
            this.tgl_transaksi.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toko_Obat.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nama Obat";
            // 
            // nama_obat
            // 
            this.nama_obat.Location = new System.Drawing.Point(132, 202);
            this.nama_obat.Name = "nama_obat";
            this.nama_obat.Size = new System.Drawing.Size(121, 22);
            this.nama_obat.TabIndex = 23;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nama_obat);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nama_obat;
    }
}
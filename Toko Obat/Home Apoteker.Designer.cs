
namespace Toko_Obat
{
    partial class Home_Apoteker
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
            this.Data_Pengelolaan = new System.Windows.Forms.Button();
            this.Transaksi = new System.Windows.Forms.Button();
            this.Pembeli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo";
            // 
            // Data_Pengelolaan
            // 
            this.Data_Pengelolaan.Location = new System.Drawing.Point(272, 140);
            this.Data_Pengelolaan.Name = "Data_Pengelolaan";
            this.Data_Pengelolaan.Size = new System.Drawing.Size(223, 39);
            this.Data_Pengelolaan.TabIndex = 1;
            this.Data_Pengelolaan.Text = "Data Pengelolan Obat";
            this.Data_Pengelolaan.UseVisualStyleBackColor = true;
            this.Data_Pengelolaan.Click += new System.EventHandler(this.Data_Pengelolaan_Click);
            // 
            // Transaksi
            // 
            this.Transaksi.Location = new System.Drawing.Point(272, 262);
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Size = new System.Drawing.Size(223, 39);
            this.Transaksi.TabIndex = 2;
            this.Transaksi.Text = "Transaksi";
            this.Transaksi.UseVisualStyleBackColor = true;
            this.Transaksi.Click += new System.EventHandler(this.Transaksi_Click);
            // 
            // Pembeli
            // 
            this.Pembeli.Location = new System.Drawing.Point(272, 201);
            this.Pembeli.Name = "Pembeli";
            this.Pembeli.Size = new System.Drawing.Size(223, 39);
            this.Pembeli.TabIndex = 3;
            this.Pembeli.Text = "Pembeli";
            this.Pembeli.UseVisualStyleBackColor = true;
            this.Pembeli.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home_Apoteker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pembeli);
            this.Controls.Add(this.Transaksi);
            this.Controls.Add(this.Data_Pengelolaan);
            this.Controls.Add(this.label1);
            this.Name = "Home_Apoteker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Apoteker";
            this.Load += new System.EventHandler(this.Home_Apoteker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Data_Pengelolaan;
        private System.Windows.Forms.Button Transaksi;
        private System.Windows.Forms.Button Pembeli;
    }
}
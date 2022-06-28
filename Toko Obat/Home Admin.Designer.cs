
namespace Toko_Obat
{
    partial class Home_Admin
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
            this.obat = new System.Windows.Forms.Button();
            this.apoteker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // obat
            // 
            this.obat.Location = new System.Drawing.Point(284, 224);
            this.obat.Name = "obat";
            this.obat.Size = new System.Drawing.Size(223, 39);
            this.obat.TabIndex = 6;
            this.obat.Text = "Obat";
            this.obat.UseVisualStyleBackColor = true;
            this.obat.Click += new System.EventHandler(this.obat_Click);
            // 
            // apoteker
            // 
            this.apoteker.Location = new System.Drawing.Point(284, 163);
            this.apoteker.Name = "apoteker";
            this.apoteker.Size = new System.Drawing.Size(223, 39);
            this.apoteker.TabIndex = 5;
            this.apoteker.Text = "Apoteker";
            this.apoteker.UseVisualStyleBackColor = true;
            this.apoteker.Click += new System.EventHandler(this.apoteker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logo";
            // 
            // Home_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.obat);
            this.Controls.Add(this.apoteker);
            this.Controls.Add(this.label1);
            this.Name = "Home_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button obat;
        private System.Windows.Forms.Button apoteker;
        private System.Windows.Forms.Label label1;
    }
}
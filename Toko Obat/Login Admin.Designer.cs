
namespace Toko_Obat
{
    partial class Login_Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_admin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_admin = new System.Windows.Forms.TextBox();
            this.lg_Admin = new System.Windows.Forms.Label();
            this.lg_Aptoker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pass_admin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.user_admin);
            this.panel1.Controls.Add(this.lg_Admin);
            this.panel1.Controls.Add(this.lg_Aptoker);
            this.panel1.Location = new System.Drawing.Point(225, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 221);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(74, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // pass_admin
            // 
            this.pass_admin.Location = new System.Drawing.Point(77, 114);
            this.pass_admin.Name = "pass_admin";
            this.pass_admin.Size = new System.Drawing.Size(184, 22);
            this.pass_admin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(74, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // user_admin
            // 
            this.user_admin.Location = new System.Drawing.Point(77, 67);
            this.user_admin.Name = "user_admin";
            this.user_admin.Size = new System.Drawing.Size(184, 22);
            this.user_admin.TabIndex = 1;
            // 
            // lg_Admin
            // 
            this.lg_Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lg_Admin.BackColor = System.Drawing.Color.Coral;
            this.lg_Admin.Location = new System.Drawing.Point(46, 0);
            this.lg_Admin.Name = "lg_Admin";
            this.lg_Admin.Size = new System.Drawing.Size(134, 33);
            this.lg_Admin.TabIndex = 0;
            this.lg_Admin.Text = "Admin";
            this.lg_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lg_Aptoker
            // 
            this.lg_Aptoker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lg_Aptoker.BackColor = System.Drawing.Color.PeachPuff;
            this.lg_Aptoker.Location = new System.Drawing.Point(186, 0);
            this.lg_Aptoker.Name = "lg_Aptoker";
            this.lg_Aptoker.Size = new System.Drawing.Size(134, 33);
            this.lg_Aptoker.TabIndex = 0;
            this.lg_Aptoker.Text = "Apoteker";
            this.lg_Aptoker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lg_Aptoker.Click += new System.EventHandler(this.lg_Aptoker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logo";
            // 
            // Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Login_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Admin";
            this.Load += new System.EventHandler(this.Login_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_admin;
        private System.Windows.Forms.Label lg_Admin;
        private System.Windows.Forms.Label lg_Aptoker;
        private System.Windows.Forms.Label label1;
    }
}
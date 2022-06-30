
namespace Toko_Obat
{
    partial class PrintData
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Toko_ObatDataSet = new Toko_Obat.Toko_ObatDataSet();
            this.TransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TransaksiTableAdapter = new Toko_Obat.Toko_ObatDataSetTableAdapters.TransaksiTableAdapter();
            this.kembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Toko_ObatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TransaksiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Toko_Obat.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(950, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Toko_ObatDataSet
            // 
            this.Toko_ObatDataSet.DataSetName = "Toko_ObatDataSet";
            this.Toko_ObatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TransaksiBindingSource
            // 
            this.TransaksiBindingSource.DataMember = "Transaksi";
            this.TransaksiBindingSource.DataSource = this.Toko_ObatDataSet;
            // 
            // TransaksiTableAdapter
            // 
            this.TransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // kembali
            // 
            this.kembali.Dock = System.Windows.Forms.DockStyle.Left;
            this.kembali.Location = new System.Drawing.Point(0, 0);
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(75, 25);
            this.kembali.TabIndex = 1;
            this.kembali.Text = "BACK";
            this.kembali.UseVisualStyleBackColor = true;
            this.kembali.Click += new System.EventHandler(this.kembali_Click);
            // 
            // PrintData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 475);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintData";
            this.Text = "PrintData";
            this.Load += new System.EventHandler(this.PrintData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Toko_ObatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransaksiBindingSource;
        private Toko_ObatDataSet Toko_ObatDataSet;
        private Toko_ObatDataSetTableAdapters.TransaksiTableAdapter TransaksiTableAdapter;
        private System.Windows.Forms.Button kembali;
    }
}
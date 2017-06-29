namespace BUUDIEN
{
    partial class ReportDV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TKBUUDIENDataSet2 = new BUUDIEN.TKBUUDIENDataSet2();
            this.SP_LAYTHONGTINDICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LAYTHONGTINDICHVUTableAdapter = new BUUDIEN.TKBUUDIENDataSet2TableAdapters.SP_LAYTHONGTINDICHVUTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKBUUDIENDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LAYTHONGTINDICHVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DỊCH VỤ";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SP_LAYTHONGTINDICHVUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BUUDIEN.Thongkedichvu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(650, 398);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // TKBUUDIENDataSet2
            // 
            this.TKBUUDIENDataSet2.DataSetName = "TKBUUDIENDataSet2";
            this.TKBUUDIENDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_LAYTHONGTINDICHVUBindingSource
            // 
            this.SP_LAYTHONGTINDICHVUBindingSource.DataMember = "SP_LAYTHONGTINDICHVU";
            this.SP_LAYTHONGTINDICHVUBindingSource.DataSource = this.TKBUUDIENDataSet2;
            // 
            // SP_LAYTHONGTINDICHVUTableAdapter
            // 
            this.SP_LAYTHONGTINDICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 416);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportDV";
            this.Text = "ReportDV";
            this.Load += new System.EventHandler(this.ReportDV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TKBUUDIENDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LAYTHONGTINDICHVUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_LAYTHONGTINDICHVUBindingSource;
        private TKBUUDIENDataSet2 TKBUUDIENDataSet2;
        private TKBUUDIENDataSet2TableAdapters.SP_LAYTHONGTINDICHVUTableAdapter SP_LAYTHONGTINDICHVUTableAdapter;
    }
}
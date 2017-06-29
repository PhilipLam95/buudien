namespace BUUDIEN
{
    partial class ReportPhieuGuiquahan
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
            this.SP_LIETKEPHIEUGUIQUAHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LIETKEPHIEUGUIQUAHANTableAdapter = new BUUDIEN.TKBUUDIENDataSet2TableAdapters.SP_LIETKEPHIEUGUIQUAHANTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TKBUUDIENDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LIETKEPHIEUGUIQUAHANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.SP_LIETKEPHIEUGUIQUAHANBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BUUDIEN.Thongkephieuguiquahan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(753, 390);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // TKBUUDIENDataSet2
            // 
            this.TKBUUDIENDataSet2.DataSetName = "TKBUUDIENDataSet2";
            this.TKBUUDIENDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_LIETKEPHIEUGUIQUAHANBindingSource
            // 
            this.SP_LIETKEPHIEUGUIQUAHANBindingSource.DataMember = "SP_LIETKEPHIEUGUIQUAHAN";
            this.SP_LIETKEPHIEUGUIQUAHANBindingSource.DataSource = this.TKBUUDIENDataSet2;
            // 
            // SP_LIETKEPHIEUGUIQUAHANTableAdapter
            // 
            this.SP_LIETKEPHIEUGUIQUAHANTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPhieuGuiquahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 409);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportPhieuGuiquahan";
            this.Text = "ReportPhieuGuiquahan";
            this.Load += new System.EventHandler(this.ReportPhieuGuiquahan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TKBUUDIENDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LIETKEPHIEUGUIQUAHANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_LIETKEPHIEUGUIQUAHANBindingSource;
        private TKBUUDIENDataSet2 TKBUUDIENDataSet2;
        private TKBUUDIENDataSet2TableAdapters.SP_LIETKEPHIEUGUIQUAHANTableAdapter SP_LIETKEPHIEUGUIQUAHANTableAdapter;
    }
}
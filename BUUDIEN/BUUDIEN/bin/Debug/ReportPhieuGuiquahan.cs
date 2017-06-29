using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BUUDIEN
{
    public partial class ReportPhieuGuiquahan : Form
    {
        private DataTable pguiquahan;
        public ReportPhieuGuiquahan()
        {
            InitializeComponent();
        }

        private void ReportPhieuGuiquahan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TKBUUDIENDataSet2.SP_LIETKEPHIEUGUIQUAHAN' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
             pguiquahan = DBAcess.ExecuteQuery("SP_LIETKEPHIEUGUIQUAHAN");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Thongkephieuguiquahan.rdlc";
            if (pguiquahan.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet3";
                rds.Value = pguiquahan;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

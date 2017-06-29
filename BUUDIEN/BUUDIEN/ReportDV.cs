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
    public partial class ReportDV : Form
    {
        private DataTable dichvu;
        public ReportDV()
        {
            InitializeComponent();
        }

        private void ReportDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TKBUUDIENDataSet2.SP_LAYTHONGTINDICHVU' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();

            dichvu = DBAcess.ExecuteQuery("SP_LIETKEDICHVU");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Thongkedichvu.rdlc";
            if (dichvu.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet2";
                rds.Value = dichvu;

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

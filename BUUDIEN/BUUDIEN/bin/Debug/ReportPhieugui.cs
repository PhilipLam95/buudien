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
    public partial class ReportPhieugui : Form
    {
        public ReportPhieugui()
        {
            InitializeComponent();
        }

        private void ReportDichvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TKBUUDIENDataSet2.SP_LIETKEPHIEUGUI' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromdate = DateTime.Parse(dateTimePicker1.Value.ToString());
           

            DateTime todate = DateTime.Parse(dateTimePicker2.Value.ToString());
          



            string[] name = { "@FROMDATE", "@TODATE" };
            object[] param = { fromdate, todate };
            DataTable phieutrongkhoang = DBAcess.ExecuteQuery("SP_LIETKEPHIEUGUI", name, param, 2);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Thongkephieugui.rdlc";
            if (phieutrongkhoang.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = phieutrongkhoang;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

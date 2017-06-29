using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BUUDIEN
{
    public partial class FrmChucNang : Form
    {
        /*this.sP_LayBaiThiTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_LayBaiThi, Program.loginName, cmbMonHoc.SelectedValue.ToString(),
         * new System.Nullable<short>(((short)(System.Convert.ChangeType(cmbLan.SelectedValue.ToString(), 
         * typeof(short))))), cmbTrinhDo.SelectedValue.ToString());*/
        
         
         
       
        public FrmChucNang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaoGDV f3 = new TaoGDV();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuGuiTien f2 = new PhieuGuiTien();
            f2.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuRutTien f1 = new PhieuRutTien();
            f1.Show();
        }

        private void load_dichvu(object sender, EventArgs e)
        {
            DataTable dichvu = DBAcess.ExecuteQuery("SP_LIETKEDICHVU");
            sP_LIETKEDICHVUBindingSource1.DataSource = dichvu;
        }

        private void load_phieuguiquahan()
        {
            DataTable pguiquahan = DBAcess.ExecuteQuery("SP_LIETKEPHIEUGUIQUAHAN");
            sP_LIETKEPHIEUGUIQUAHANBindingSource.DataSource = pguiquahan;
        }

        private void FrmChucNang_Load(object sender, EventArgs e)
        {
           
            /*this.sP_LayBaiThiTableAdapter.Fill(this.tRACNGHIEMDataSet.SP_LayBaiThi, Program.loginName, cmbMonHoc.SelectedValue.ToString(),
        * new System.Nullable<short>(((short)(System.Convert.ChangeType(cmbLan.SelectedValue.ToString(), 
        * typeof(short))))), cmbTrinhDo.SelectedValue.ToString());*/
            // TODO: This line of code loads data into the 'tKBUUDIENDataSet2.SP_LIETKEPHIEUGUI' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tKBUUDIENDataSet2.SP_LIETKEDICHVU' table. You can move, or remove it, as needed.
            
            load_dichvu(sender,e);
            load_phieuguiquahan();
            
           
           
            
            
             
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Capnhatdichvu fcapnhatdichvu = new Capnhatdichvu();
            fcapnhatdichvu.Show();
            
        }


        private void Refesh_Click(object sender, EventArgs e)
        {
            FrmChucNang_Load(sender, e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            

         
            
           /* DataRow red = sP_LIETKEPHIEUGUIDataGridView.GetFocusedDataRow();
            sP_LIETKEPHIEUGUIDataGridView.Columns.["MADV"].Add = ("TEXT", tien_lai, "")
            sP_LIETKEPHIEUGUIDataGridView.Columns["CMND"].HeaderText = "1";
            sP_LIETKEPHIEUGUIDataGridView.Columns["MADV"].HeaderText = "1";
            sP_LIETKEPHIEUGUIDataGridView.Columns["NGAYGUI"].HeaderText = "1";
            sP_LIETKEPHIEUGUIDataGridView.Columns["LAISUAT"].HeaderText = "1";
            sP_LIETKEPHIEUGUIDataGridView.Columns["SOTIEN_GUI"].HeaderText = "1";
            sP_LIETKEPHIEUGUIDataGridView.Columns["NGAYDENHAN"].HeaderText = "1";
            sP_LIETKEPHIEUGUIDataGridView.Columns["MAGDV_LPGUI"].HeaderText ="1";*/


            /*if (sP_LIETKEPHIEUGUIDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = sP_LIETKEPHIEUGUIDataGridView.SelectedCells[0].RowIndex;
            MAGDV_LPGUI
                DataGridViewRow selectedRow = sP_LIETKEPHIEUGUIDataGridView.Rows[selectedrowindex];

              

            }*/

        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }


        private void button7_Click(object sender, EventArgs e)
        {
         
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sP_LIETKEPHIEUGUIQUAHANDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sP_LIETKEPHIEUGUIQUAHANDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sP_LIETKEPHIEUGUIDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sP_LIETKEDICHVUBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           

            DateTime fromdate = DateTime.Parse(dateTimePicker2.Value.ToString());
            

            DateTime todate = DateTime.Parse(dateTimePicker1.Value.ToString());
            

            
          
            string[] name = { "@FROMDATE", "@TODATE" };
            object[] param = { fromdate,todate };
            DataTable phieutrongkhoang = DBAcess.ExecuteQuery("SP_LIETKEPHIEUGUI", name, param, 2);
            this.sP_LIETKEPHIEUGUIDataGridView.DataSource = phieutrongkhoang;
           

        }

        private void sP_LIETKEDICHVUDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ReportDV frpdichvu = new ReportDV();
            frpdichvu.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            ReportPhieugui frpphieugui = new ReportPhieugui();
            frpphieugui.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReportPhieuGuiquahan frpphieuguiqhan = new ReportPhieuGuiquahan();
            frpphieuguiqhan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doimatkhau dmk = new Doimatkhau();
            dmk.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* TongTN.Text = Format(CType(TongTN.Text, Double), "N0")
            TongTN.SelectionStart = TongTN.Text.Length*/
          
        }

     

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void sP_LIETKEPHIEUGUIQUAHANDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

       

   
        private void button12_Click_1(object sender, EventArgs e)
        {
            DateTime year = DateTime.Parse(dateTimePicker3.Value.ToString());
            string[] name = { "@YEAR" };
            object[] param = { year };

            DataTable table = DBAcess.ExecuteQuery("SP_LIETKETIENTHEOTHANG", name, param, 1);
            this.sP_LIETKETIENTHEOTHANGDataGridView.DataSource = table;
        }

        private void sP_LIETKETIENTHEOTHANGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Backup_Restore fbrs = new Backup_Restore();
            fbrs.Show();
            this.Hide();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

       

        

        

       

     
      

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BUUDIEN
{
    public partial class Backup_Restore : Form
    {
        private int index = -1;
        public Backup_Restore()
        {
            InitializeComponent();
        }

        private void DANHSACH_LOAD()
        {
            DataTable dsbackup = DBAcess.ExecuteQuery("SP_DANHSACHBACKUP");
            sP_DANHSACHBACKUPBindingSource.DataSource = dsbackup;

           
        }
        private void Backup_Restore_Load(object sender, EventArgs e)
        {
            DANHSACH_LOAD();
            // TODO: This line of code loads data into the 'tKBUUDIENDataSet.SP_DANHSACHBACKUP' table. You can move, or remove it, as needed.
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
               int reinit = checkBox1.Checked ? 1 : 0;
            string[] name = { "@reinit" };
            object[] param = { reinit };
            int code =DBAcess.ExecuteNonQuery("SP_BACKUP", name, param, 1);
            if (code > 0)
            {

                MessageBox.Show("Sao lưu thành công");
            }
            else
                MessageBox.Show("Sao lưu thất bại.");
        }

        private void sP_DANHSACHBACKUPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sP_DANHSACHBACKUPDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            index = sP_DANHSACHBACKUPDataGridView.CurrentRow.Index;
            for (int i = 0; i < sP_DANHSACHBACKUPDataGridView.RowCount; i++)
            {
                if (i != index)
                {
                    sP_DANHSACHBACKUPDataGridView.Rows[i].Cells[0].Value = false;
                }
            }
            sP_DANHSACHBACKUPDataGridView.Rows[index].Cells[0].Value = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Backup_Restore_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

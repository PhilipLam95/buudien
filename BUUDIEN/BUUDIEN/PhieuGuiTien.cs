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
    public partial class PhieuGuiTien : Form
    {
        private DataTable madichvu;
        private DataTable MaPhieu;
       
        public PhieuGuiTien()
        {
            InitializeComponent();
        }

        private void tinhngaydenhan()
        {
            DateTime ngGUI = DateTime.Parse(dateTimePicker1.Value.ToString());
            dateTimePicker1.Text = ngGUI.ToShortDateString();
            string kyhan = textBox8.Text.ToString();
            string []name = {"@NGAYGUI","@KYHAN"};
            object[] param = { ngGUI, kyhan };
            DataTable ngaydenhan = DBAcess.ExecuteQuery("SP_TINHNGAYDENHAN", name, param, 2);
            textBox1.DataBindings.Add("TEXT", ngaydenhan, "NGAYDENHAN");
            textBox1.DataBindings.Clear();

        }
        private void KiemTra()
        {
            if (textBox11.Text.Trim() == "")
            {
                MessageBox.Show("Mời bạn nhập số tiền muốn gửi");
            }
        }
        private void AddMaPhieutoCompo()
        {
            MaPhieu = DBAcess.ExecuteQuery("SP_LAYMAPHIEU");
            comboBox2.DataSource = MaPhieu;

            comboBox2.ValueMember = "MAPHIEU";



        }

        private void AddMaDichvuCompo()
        {
            madichvu = DBAcess.ExecuteQuery("SP_LAYMADICHVU");
            comboBox1.DataSource = madichvu;

            comboBox1.ValueMember = "MADV";
            
            
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PhieuGuiTien_Load(object sender, EventArgs e)
        {
            AddMaDichvuCompo();
            AddMaPhieutoCompo();
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            textBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            label14.Text = DBAcess.MAGDV;
            label15.Hide();
            textBox10.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maDV = comboBox1.SelectedValue.ToString();
           
            string[] name = { "@MADV" };
            object[] param = { maDV};
            
            DataTable thongtindichvu = DBAcess.ExecuteQuery("SP_LAYTHONGTINDICHVU", name, param, 1);
            textBox9.DataBindings.Add("TEXT", thongtindichvu, "TENDV");
            textBox9.DataBindings.Clear();
            textBox8.DataBindings.Add("TEXT", thongtindichvu, "KYHAN");
            textBox8.DataBindings.Clear();
            textBox10.DataBindings.Add("TEXT", thongtindichvu, "LAISUAT");
            textBox10.DataBindings.Clear();
            tinhngaydenhan();
           
            
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maphieu = comboBox2.SelectedValue.ToString();

            string[] name = { "@MAPHIEU" };
            object[] param = { maphieu };

            DataTable thongtinkhachhang = DBAcess.ExecuteQuery("SP_LAYTHONGTINKHACHANG", name, param, 1);
            textBox4.DataBindings.Add("TEXT", thongtinkhachhang, "HOTEN");
            textBox4.DataBindings.Clear();
            textBox5.DataBindings.Add("TEXT", thongtinkhachhang, "DIACHI");
            textBox5.DataBindings.Clear();
            /*textBox6.DataBindings.Add("TEXT", thongtinkhachhang, "NGAYCAP");
            textBox6.DataBindings.Clear();*/

            dateTimePicker2.DataBindings.Clear();             
            dateTimePicker2.DataBindings.Add("Value", thongtinkhachhang, "NGAYCAP");
           

            
          
           
          
          


           

           
            textBox7.DataBindings.Add("TEXT", thongtinkhachhang, "CMNDAN");
            textBox7.DataBindings.Clear();
            comboBox1.DataBindings.Add("TEXT", thongtinkhachhang, "MDV");
            comboBox1.DataBindings.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuGuiTien fguitien = new PhieuGuiTien();
            fguitien.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap f1 = new FrmDangNhap();
            FrmChucNang f2 = new FrmChucNang();
            f1.Show();
            f2.ShowDialog(f1);
            f2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                
                if (textBox4.Text.Trim() == "" | textBox5.Text.Trim()== "" | textBox7.Text.Trim() == "" | comboBox1.Text == "")
                {
                    MessageBox.Show("Không được để trống các trường trong form ");
                }
                if (textBox11.Text.Trim() == "")
                {
                    MessageBox.Show("Mời bạn nhập số tiền muốn gửi");
                }
                if (textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox7.Text.Trim() != "" && comboBox1.Text != "" && textBox7.Text.Length <11 )
                {
                    string hoTen = textBox4.Text.ToString();
                    string diaChi = textBox5.Text.ToString();
                    /*DateTime ngCap = DateTime.Parse(textBox6.Text.ToString());
                    textBox6.Text = ngCap.ToString("dd/MM/yyyy");*/
                    DateTime ngCap = DateTime.Parse(dateTimePicker2.Text.ToString());
                    dateTimePicker2.Text = ngCap.ToString();
                    string CMNDAN = textBox7.Text.ToString();
                    string maDV = comboBox1.Text.ToString();
                    string maGDV_lpgui = label14.Text.ToString();
                    string soTiengui = textBox11.Text.ToString();
                    DateTime ngDenhan = DateTime.Parse(textBox1.Text.ToString());
                    textBox1.Text = ngDenhan.ToString("dd/MM/yyyy");

                    string[] name = { "@CMND", "@HOTEN", "@DIACHI", "@NGAYCAP", "@MADV", "@SOTIEN_GUI", "@NGAYDENHAN", "@MAGDV_LPGUI" };
                    object[] param = { CMNDAN, hoTen, diaChi, ngCap, maDV, soTiengui, ngDenhan, maGDV_lpgui };
                    DataTable thongtindichvu = DBAcess.ExecuteQuery("SP_THEMPHIEUGUI", name, param, 8);

                    label15.DataBindings.Add("TEXT", thongtindichvu, "MAPHIEU");
                    MessageBox.Show("Đã thêm thành công " + textBox11.Text + " " + "VDN vào phiếu gửi " + " " + label15.Text.ToUpper());

                    textBox4.DataBindings.Clear();
                    textBox5.DataBindings.Clear();
                    /*textBox6.DataBindings.Clear();*/
                    dateTimePicker2.DataBindings.Clear();
                    textBox7.DataBindings.Clear();
                    comboBox1.DataBindings.Clear();
                    textBox11.DataBindings.Clear();
                    /* string laiSuat =
           
                     string ngdenHan =
                     string maGDV_lpgui =*/
                    PhieuGuiTien_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("GUI TIEN THAT BAI ROI");
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa mã phiếu :"+ " "+comboBox2.Text , "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maPhieu = comboBox2.Text.ToString();
                string[] name = { "@MAPHIEU" };
                object[] param = { maPhieu };
                DataTable xoaphieugui = DBAcess.ExecuteQuery("SP_XOAPHIEUGUI", name, param, 1);
                MessageBox.Show("Đã xóa mã phiếu" + " " + maPhieu + " " + "thành công");
                comboBox2.DataBindings.Clear();
                PhieuGuiTien_Load(sender,e);

            }
            
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số tiền gửi phải là kiểu số ", "Thông Báo ");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("CMND phải là kiểu số ", "Thông Báo ");
            }
        }
    }
}

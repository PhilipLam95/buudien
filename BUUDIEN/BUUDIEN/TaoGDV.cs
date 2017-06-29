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
    public partial class TaoGDV : Form
    {
        public TaoGDV()
        {
            InitializeComponent();
        }

        public string getRole()
        {
            string role = "";
            if (nhanvienrRBTON.Checked)
            {
                role = role + nhanvienrRBTON.Text;
                
            }
            if (adminRBTON.Checked) 
            {
                role = role + adminRBTON.Text;
                
            }
            return role;
        }
        
        private void TaoGDV_Load(object sender, EventArgs e)
        {
           if(DBAcess.ROLE != "ADMIN")
           {
               adminRBTON.Hide();
               button2.Enabled = false;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || nhanvienrRBTON.Checked == false && adminRBTON.Checked == false)
                {
                    MessageBox.Show("ban chua nhập đầy đủ");
                }
                else
                {
                    string hoten = comboBox1.Text.ToString();
                    string diachi = textBox2.Text.ToString();
                    string cmndan = textBox3.Text.ToString();
                    string soDT = textBox4.Text.ToString();
                    string tenDnhap = textBox5.Text.ToString();
                    string mAtkhau = textBox6.Text.ToString();
                    string Role = getRole();


                    string[] name = { "@LGNAME", "@PASS", "@ROLE", "@HOTEN", "@DIACHI", "@CMND", "@SODT" };
                    object[] param = { tenDnhap, mAtkhau, Role, hoten, diachi, cmndan, soDT };
                    int x = DBAcess.ExecuteNonQuery("TAO_LOGIN", name, param, 7);
                    comboBox1.Text = string.Empty;
                    textBox2.Text= string.Empty;
                    textBox3.Text= string.Empty;
                    textBox4.Text= string.Empty;
                    textBox5.Text = string.Empty;
                    textBox6.Text= string.Empty;
                    if(x==0)
                        MessageBox.Show("TẠO TÀI KHÒAN" + Role + "THÀNH CÔNG");
                    if(x!=0)
                        MessageBox.Show("Chưa tạo được tài khoản");
                }
            }
            catch {
                MessageBox.Show(" loi roi");
            }
           

            


        }

        private void nhanvienrRBTON_Click(object sender, EventArgs e)
        {
           
        }

        private void adminRBTON_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmChucNang fchucnang = new FrmChucNang();
            fchucnang.Show();
            this.Hide();
        }

      
        
        
    }
}

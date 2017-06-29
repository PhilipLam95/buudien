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
    public partial class Doimatkhau : Form
    {
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void Doimatkhau_Load(object sender, EventArgs e)
        {
            label1.Text = DBAcess.USERNAME;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" || textBox1.Text.Trim() == "" ||textBox3.Text.Trim() == "" )
            {
                MessageBox.Show("Mật khẩu phải chứa kí tự hoặc số. Không chứa khoảng trắng.");
                return;
            }
            if (textBox1.Text != textBox3.Text)
            {
                MessageBox.Show("New password phải giống confirm password");
                return;
            }

            string[] name = { "@newpassword", "@oldpassword", "@login" };
            object[] param = { textBox1.Text, textBox2.Text, DBAcess.USERNAME };
            int x = DBAcess.ExecuteNonQuery("SP_DoiMatKhau", name, param, 3);
            if (x == 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else
                MessageBox.Show("Đổi mật khẩu thất bại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

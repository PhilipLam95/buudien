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
    public partial class Capnhatdichvu : Form
    {

        private DataTable dichvu;

        public Capnhatdichvu()
        {
            InitializeComponent();
        }

        private void AddMaPhieutoCompo()
        {
            dichvu = DBAcess.ExecuteQuery("SP_LAYMADICHVU");

            comboBox1.Items.Clear();
            foreach (DataRow s in dichvu.Rows)
            {
                comboBox1.Items.Add(s[0]);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madv = comboBox1.SelectedItem.ToString();

            string[] name = { "@MADV" };
            object[] param = { madv };

            DataTable thongtindichvu = DBAcess.ExecuteQuery("SP_LAYTHONGTINDICHVU", name, param, 1);

            textBox1.DataBindings.Add("TEXT",thongtindichvu,"TENDV");
            textBox2.DataBindings.Add("TEXT",thongtindichvu,"KYHAN");
            textBox3.DataBindings.Add("TEXT", thongtindichvu, "LAISUAT");

             textBox1.DataBindings.Clear();
             textBox2.DataBindings.Clear();
             textBox3.DataBindings.Clear();

        }

        private void Capnhatdichvu_Load(object sender, EventArgs e)
        {
            AddMaPhieutoCompo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madv = comboBox1.Text.ToString();
            string tendv = textBox1.Text.ToString();
            string kyhan = textBox2.Text.ToString();
            string laisuat = textBox3.Text.ToString();
            string[] name = { "@MADV", "@TENDV", "@KYHAN", "@LAISUAT" };
            object[] param = { madv,tendv,kyhan,laisuat };
            int x = DBAcess.ExecuteNonQuery("SP_THEMDICHVU", name, param, 4);
            if (x == 0)
            {
                MessageBox.Show("Thêm dich vu thành công");
                Capnhatdichvu_Load(sender, e);
                
                
            }
            if(x!= 0)
            {
                  MessageBox.Show("Đã tồn tài 1 trường nào đó trong csdl");
            }
            comboBox1.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string madv = comboBox1.Text.ToString();
            string tendv = textBox1.Text.ToString();
            string kyhan = textBox2.Text.ToString();
            string laisuat = textBox3.Text.ToString();
            string[] name = { "@MADV", "@TENDV", "@KYHAN", "@LAISUAT" };
            object[] param = { madv, tendv, kyhan, laisuat };
            int x = DBAcess.ExecuteNonQuery("SP_SUADICHVU", name, param, 4);
            if (x == 0)
            {
                MessageBox.Show("Sua dich vu thành công");
                Capnhatdichvu_Load(sender, e);



            }
            if (x != 0)
            {
                MessageBox.Show("Sua dich vu thất bại");
            }
            comboBox1.DataBindings.Clear();
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
        }
    }
}

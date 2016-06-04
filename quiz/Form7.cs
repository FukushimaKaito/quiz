using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked & checkBox6.Checked)
            {
                MessageBox.Show("正解！！");
                Form8 fome8 = new Form8();
                fome8.Show();
                this.Close();
            }
            else
                MessageBox.Show("不正解");
        }
    }
}

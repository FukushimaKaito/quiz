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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("不正解");
                Form4 fome4 = new Form4();
                fome4.Show();
                this.Close();
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("不正解");
                Form4 fome4 = new Form4();
                fome4.Show();
                this.Close();
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("正解！！");
                Form4 fome4 = new Form4();
                fome4.Show();
                this.Close();
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("ヒント：問題文をよく読もう！");
                Form4 fome4 = new Form4();
                fome4.Show();
                this.Close();
            }
        }
    }
}

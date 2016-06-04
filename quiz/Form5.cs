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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("不正解");
                Form6 fome6 = new Form6();
                fome6.Show();
                this.Close();
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("不正解");
                Form6 fome6 = new Form6();
                fome6.Show();
                this.Close();
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("不正解");
                Form6 fome6 = new Form6();
                fome6.Show();
                this.Close();
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("正解");
                Form6 fome6 = new Form6();
                fome6.Show();
                this.Close();
            }

        }
    }
}

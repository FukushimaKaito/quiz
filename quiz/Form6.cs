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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("不正解");
                Form7 fome7 = new Form7();
                fome7.Show();
                this.Close();
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("不正解");
                Form7 fome7 = new Form7();
                fome7.Show();
                this.Close();
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("不正解");
                Form7 fome7 = new Form7();
                fome7.Show();
                this.Close();
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("不正解");
                Form7 fome7 = new Form7();
                fome7.Show();
                this.Close();
            }
            if (radioButton5.Checked)
            {
                MessageBox.Show("不正解");
                Form7 fome7 = new Form7();
                fome7.Show();
                this.Close();
            }
        }

    }
}

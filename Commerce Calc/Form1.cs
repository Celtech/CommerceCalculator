using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Commerce_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Decimal[] values  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 ,14, 15 };
        Decimal[] values2 = { 0 , 0 , 0 ,0 , 1, 1 , 2, 2 , 3 };

        private void button1_Click(object sender, EventArgs e)
        {
            decimal divisor = 0;
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked == true)
                    divisor = rb.TabIndex;
            }

            decimal commerceRank = 1 + (values[comboBox1.SelectedIndex] / 100);
            decimal townRank = 1 + (values2[comboBox2.SelectedIndex] / 100);
            decimal guarenteeLetter = 1 + (divisor / 100);

            label6.Text = Math.Ceiling(100  / (Convert.ToDecimal(numericUpDown1.Value) * guarenteeLetter * commerceRank * townRank)).ToString();
            label5.Text = Math.Ceiling(1000 / (Convert.ToDecimal(numericUpDown1.Value) * guarenteeLetter * commerceRank * townRank)).ToString();
            label4.Text = Math.Ceiling(5000 / (Convert.ToDecimal(numericUpDown1.Value) * guarenteeLetter * commerceRank * townRank)).ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://mabimods.net");
        }
    }
}

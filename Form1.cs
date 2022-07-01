using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string pay;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < produce.CheckedItems.Count; i++)
            {
                str += produce.CheckedItems[i].ToString() + "，";
            }
            lblSHOW.Text = $"\n{textBox1.Text}你好，你買了" + str + $"\n付款為{pay}" +
                $"\n產品於{time.Text}送達，謝謝";
        }

        private void cash_CheckedChanged(object sender, EventArgs e)
        {
            if (cash.Checked)
                pay = "貨到付款";
        }

        private void atm_CheckedChanged(object sender, EventArgs e)
        {
            if (atm.Checked)
                pay = "ATM";
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

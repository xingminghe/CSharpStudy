using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace StudentDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValiDataInput.IsNumber(txtSNO.Text))
            {
                MessageBox.Show("输入的信息必须为数字！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSNO.Text))
            {
                MessageBox.Show("输入的信息不能为空！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValiDataInput.IsStartWith (txtSNO.Text))
            {
                MessageBox.Show("输入的信息必须以95开始的六位数字！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValiDataInput.IsChinese(txtName.Text))
            {
                MessageBox.Show("输入的信息必须是汉字！", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListExcise
{
    public partial class Form1 : Form
    {
       
        List<student> objList = new List<student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student objstudent = new student();
            if (this.txtSNO.Text.Trim().Length == 0)
            {
                MessageBox.Show("学号不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSNO.Focus();
                return;
            }
            objstudent.SNO = this.txtSNO.Text.Trim();
            objstudent.SName = this.txtSName.Text.Trim();
            objstudent.Major = this.cmbMajor.Text.Trim();
            objstudent.Gender = this.rdbMale.Enabled = true ? true : false;
            objstudent.Brithday = DateTime.Parse(this.dtpBorthday.Text);
            objstudent.EmailAddress = this.txtEmailAddress.Text.Trim();
            objstudent.Telephone = this.txtTelephone.Text.Trim();

            objList.Add(objstudent);

            this.dgvInforList.DataSource = null;
            this.dgvInforList.AutoGenerateColumns = false;
            this.dgvInforList.DataSource = objList;

            this.txtSNO.Text = string.Empty;
            this.txtSName.Text = string.Empty;
            this.rdbMale.Enabled = true;
            this.dtpBorthday.Text = DateTime.Now.ToShortDateString();
            this.cmbMajor.Text = "请选择专业";
            this.txtEmailAddress.Text = string.Empty;
            this.txtTelephone.Text = string.Empty;

            this.txtSNO.Focus();

        }
    }
}

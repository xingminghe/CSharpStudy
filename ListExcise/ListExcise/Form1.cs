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
        student objstudent = new student();
        List<student> objList = new List<student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            objstudent.SNO = Convert.ToInt32(this.txtSNO.Text.Trim());
            objstudent.SName = this.txtSName.Text.Trim();
            objstudent.Major = this.cmbMajor.Text.Trim();
            objstudent.Gender = this.rdbMale.Enabled = true ? true : false;
            objstudent.Brithday = DateTime.Parse(this.dtpBorthday.Text);
            objstudent.EmailAddress = this.txtEmailAddress.Text.Trim();
            objstudent.Telephone = this.txtTelephone.Text.Trim();
        }
    }
}

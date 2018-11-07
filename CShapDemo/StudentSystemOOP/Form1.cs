using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modules;
using DAL;

namespace StudentSystemOOP
{
    public partial class Form1 : Form
    {
        private string fileName = string.Empty;
        private List<Students> objListStudent = new List<Students>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //导入数据 选择文件-->读取文件-->ListStudent-->展示在DataGrid

            //打开选择文件对话框
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV文件(*.csv)|*.csv|txt文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }

            try
            {
                FileOperator objFile = new FileOperator();
                objListStudent = objFile.ReadFile(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取数据失败，具体原因：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvStudent.DataSource = null;
            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = objListStudent;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
        private List<Students> objlistQuery = new List<Students>();
        private StudentService objStudentService = new StudentService();
        private int actionFlag;
        public Form1()
        {
            InitializeComponent();
            gBoxStudentDetail.Enabled = false;
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

            //默认展示第一行学生信息明细
            Students objStudent = objStudentService.GetStudentBySNO(dgvStudent.Rows[0].Cells[0].Value.ToString(), objListStudent);
            LoadStudentToDetial(objStudent);
            objStudentService.GetAllStudentBySNO(txtQueryNo.Text.Trim(), objListStudent);
        }

        private void LoadStudentToDetial(Students objStudent)
        {
            txtNo.Text = objStudent.SNO;
            txtName.Text = objStudent.Name;
            if (objStudent.Gender == "男") rbMale.Checked = true;
            else rbFemale.Checked = true;
            dtpBorthday.Text = objStudent.Birthday.ToString();
            txtTel.Text = objStudent.Mobile;
            txtEmail.Text = objStudent.Email;
            txtAddress.Text = objStudent.HomeAddress;
            if (string.IsNullOrWhiteSpace(objStudent.PhotoPath)) return;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudent.Rows.Count == 0) return;
            if (dgvStudent.CurrentRow.Selected == false) return;
            else
            {
                Students objStudent = objStudentService.GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString(), objListStudent);
                LoadStudentToDetial(objStudent);
            }
        }

        private void txtQueryNo_TextChanged(object sender, EventArgs e)
        {
            objlistQuery.Clear();
            objlistQuery = objStudentService.GetAllStudentBySNO(txtQueryNo.Text, objListStudent);
            dgvStudent.DataSource = objlistQuery;
            if (objlistQuery == null)
            {
                Students objStudent = objStudentService.GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString(), objListStudent);
                LoadStudentToDetial(objStudent);
            }
            
        }

        private void txtQueryName_TextChanged(object sender, EventArgs e)
        {
            objlistQuery = objStudentService.GetAllStudentByName(txtQueryName.Text, objListStudent);
            dgvStudent.DataSource = objlistQuery;
        }

        private void txtQueryTel_TextChanged(object sender, EventArgs e)
        {
            objlistQuery = objStudentService.GetAllStudentByMobile(txtQueryTel.Text, objListStudent);
            dgvStudent.DataSource = objlistQuery;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisableButton();
            txtNo.Text = string.Empty;
            txtName.Text = string.Empty;
            rbMale.Checked = true;
            dtpBorthday.Text = DateTime.Now.ToString();
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            pbCurrentPic.BackgroundImage = null;


            txtNo.Focus();
            actionFlag = 1;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            actionFlag = 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            switch (actionFlag)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableButton();
            this.dgvStudent.DataSource = objListStudent;
        }

        private void  DisableButton()
        {
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnImport.Enabled = false;
            btnDelete.Enabled = false;

            gBoxStudentDetail.Enabled = true;
        }

        private void EnableButton()
        {
            btnAdd.Enabled = true;
            btnModify.Enabled = true;
            btnImport.Enabled = true;
            btnDelete.Enabled = true;

            gBoxStudentDetail.Enabled = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CShapDemo
{
    public partial class FormMain : Form
    {
        private string fileName = string.Empty;//定义文件读取文件路径变量
        private List<string> objlistStudent = new List<string>();
        private List<string> objListQuery = new List<string>();
        private int actionFlag = 0;
        private string photoName = string.Empty;


        public FormMain()
        {
            InitializeComponent();
            gBoxStudentDetail.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //选择文件
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "CSV文件(*.csv)|*.csv|txt文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                fileName = openfile.FileName;
            }
            try
            {
                objlistStudent = ReadFileToList(fileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("读取文件出现错误，具体如下：" + ex.Message, "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDatatoDataGrid(objlistStudent);

            string currentSNO = dgvStudent.Rows[0].Cells[0].Value.ToString();
            string [] currentDetail = GetStudentBySNO(currentSNO).Split(',');
            loadDataToDetial(currentDetail[0],currentDetail[1],currentDetail[2],currentDetail[3],currentDetail[4],currentDetail[5],currentDetail[6], currentDetail[7]);
        }

        private void dgvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Selected == false) return;
            else
            {
                string currentSNO = dgvStudent.CurrentRow.Cells[0].Value.ToString();
                string[] currentDetail = GetStudentBySNO(currentSNO).Split(',');
                loadDataToDetial(currentDetail[0], currentDetail[1], currentDetail[2], currentDetail[3], currentDetail[4], currentDetail[5], currentDetail[6], currentDetail[7]);
            }
        }

        private List<string> ReadFileToList(string filepath)//把某一个文件读取
        {
            List<string> objList = new List<string>();
            string line = string.Empty;
            try
            {
                StreamReader file = new StreamReader(filepath,Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    objList.Add(line); 
                }
                file.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
            return objList;

        }
        private void loadDatatoDataGrid(List<string> objList)
        {
            foreach(string item in objList)
            {
                string[] strArray = item.Trim().Split(',');
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvStudent);
                row.Cells[0].Value = strArray[0];
                row.Cells[1].Value = strArray[1];
                row.Cells[2].Value = strArray[2];
                row.Cells[3].Value = strArray[3];
                row.Cells[4].Value = strArray[4];
                dgvStudent.Rows.Add(row);
            }
        }//把list里的数据导入data grid view
        //把data grid view的第一行数据的明细展示到下面的明细框内
        private void loadDataToDetial(string sno,string sname,string sex,string birthday,string mobile,
                                                        string emial,string homeaddress,string photo)
        {
            txtNo.Text = sno;
            txtName.Text = sname;
            if (sex == "男")
                rbMale.Checked = true;
            else rbFemale.Checked = true;
            dtpBorthday.Text = birthday;
            txtTel.Text = mobile;
            txtAddress.Text = homeaddress;
            txtEmail.Text = emial;
            if (photo == string.Empty) pbCurrentPic.BackgroundImage = null;
            else pbCurrentPic.BackgroundImage = Image.FromFile(photo);

        }

        private string GetStudentBySNO(string SNO)
        {
            string currentstudent = string.Empty;
            foreach (string item in objlistStudent)
            {
                if (item.StartsWith(SNO))
                {
                    currentstudent = item;
                    break;
                }
            }
            return currentstudent;
        }

        private void txtQueryNo_TextChanged(object sender, EventArgs e)
        {
            objListQuery.Clear();
            foreach (string item in objlistStudent)
            {
                if (item.StartsWith(txtQueryNo.Text))
                    objListQuery.Add(item);
            }
            dgvStudent.Rows.Clear();
            loadDatatoDataGrid(objListQuery);
        }

        private void txtQueryName_TextChanged(object sender, EventArgs e)
        {
            objListQuery.Clear();
            foreach (string item in objlistStudent)
            {
                if (item.Contains(txtQueryName.Text))
                    objListQuery.Add(item);
            }
            dgvStudent.Rows.Clear();
            loadDatatoDataGrid(objListQuery);
        }

        private void txtQueryTel_TextChanged(object sender, EventArgs e)
        {
            objListQuery.Clear();
            foreach (string item in objlistStudent)
            {
                if (item.Contains(txtQueryTel.Text))
                    objListQuery.Add(item);
            }
            dgvStudent.Rows.Clear();
            loadDatatoDataGrid(objListQuery);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisableButton();
            //清空学生明细里的信息
            txtNo.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtTel.Text = string.Empty;
            dtpBorthday.Text = DateTime.Now.ToString();
            rbMale.Checked = true;
            pbCurrentPic.BackgroundImage = null;
            txtNo.Focus();
            actionFlag = 1;


        }//添加学生信息

        private void btnModify_Click(object sender, EventArgs e)
        {
            DisableButton();
            txtNo.Enabled = false;//学号不能修改
            txtName.Focus();//学生姓名文本框或得焦点
            actionFlag = 2;

        }//修改学生信息

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Selected == false)
            {
                MessageBox.Show("删除数据前需要选择其中一行", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string info = "您确定删除学生【学号：" + dgvStudent.CurrentRow.Cells[0].Value.ToString() +" "+ "姓名：" + dgvStudent.CurrentRow.Cells[1].Value.ToString()+"】的信息吗？";
                DialogResult result = MessageBox.Show(info, "系统信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string currentstudent = GetStudentBySNO(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                    foreach (string item in objlistStudent)
                    {
                        if (item.Equals(currentstudent))
                        {
                            objlistStudent.Remove(item);                         
                            //File.WriteAllLines(fileName, objlistStudent);
                            MessageBox.Show("学生信息删除成功，添加数据", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvStudent.Rows.Clear();
                            loadDatatoDataGrid(objlistStudent);
                            break;
                        }
                    }
                    
                }
                else return;

            }

        }//删除学生信息

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("系统退出，是否保存修改？", "系统消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(fileName, string.Empty);
                File.WriteAllLines(fileName, objlistStudent);
                Close();
            }
            else
            {
                Close();
            }
            
        }//退出程序

        private void btnCommit_Click(object sender, EventArgs e)
        {
            //if（actionFlag==1）
            if (!verifyData())
            {
                MessageBox.Show("数据校验错误", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            else
            {
                string photoPath = DateTime.Now.ToString("yyyyMMddHHmmss");
                Random objRandom = new Random();
                photoPath += objRandom.Next(0, 100).ToString("00");
                photoPath += photoName.Substring(photoName.Length - 4);
                photoPath = ".\\Image\\" + photoPath;
                Bitmap objBitmap = new Bitmap(pbCurrentPic.BackgroundImage);
                objBitmap.Save(photoPath, pbCurrentPic.BackgroundImage.RawFormat);
                objBitmap.Dispose();




                string sno = txtNo.Text.Trim();
                string sname = txtName.Text.Trim();
                string sex = rbMale.Checked ? "男" : "女";
                string birthday = dtpBorthday.Text;
                string mobile = txtTel.Text;
                string email = txtEmail.Text;
                string homeaddress = txtAddress.Text;
                string photo = photoPath;

                string currentStudent = sno + "," + sname + "," + sex + "," + birthday + "," + mobile + "," + email + "," + homeaddress+","+ photo;
                switch (actionFlag)
                {
                    case 1://添加
                        //MessageBox.Show("flag为1，添加数据", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objlistStudent.Add(currentStudent);
                        loadDatatoDataGrid(objlistStudent);
                        //File.OpenWrite(fileName);
                        //File.WriteAllLines(fileName, objlistStudent);
                        MessageBox.Show("学生信息添加成功，添加数据", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //控制按钮
                        EnableButton();
                        gBoxStudentDetail.Enabled = false;
                        break;
                    case 2://修改
                        for (int i = 0; i < objlistStudent.Count; i++)
                        {
                            if (objlistStudent[i].StartsWith(sno))
                            {
                                objlistStudent.RemoveAt(i);
                                objlistStudent.Insert(i, currentStudent);
                                dgvStudent.Rows.Clear();
                                loadDatatoDataGrid(objlistStudent);
                                //File.WriteAllLines(fileName, objlistStudent);
                                MessageBox.Show("学生信息修改成功，添加数据", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EnableButton();
                                gBoxStudentDetail.Enabled = false;
                                txtNo.Enabled = true;
                                break;
                            }
                        }
                       
                        break;
                    default:
                        
                        break;
                }
            }
          
        }//提交学生信息


        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableButton();
        }
        private void DisableButton()
        {
            btnAdd.Enabled = false;
            //btnCancel.Enabled = false;
            //btnCommit.Enabled = false;
            btnDelete.Enabled = false;
            btnImport.Enabled = false;
            btnModify.Enabled = false;
            gBoxStudentDetail.Enabled = true;
         
        }
        private void EnableButton()
        {
            btnAdd.Enabled = true;
            //btnCancel.Enabled = false;
            //btnCommit.Enabled = false;
            btnDelete.Enabled = true;
            btnImport.Enabled = true;
            btnModify.Enabled = true;
            gBoxStudentDetail.Enabled = false;
            
        }
        private bool verifyData()
        {
            bool b = true;
            if (string.IsNullOrWhiteSpace(txtNo.Text))//学号是否为空
            {
                MessageBox.Show("学号不能为空", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNo.Focus();
                b = false;
                return b;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))//姓名是否为空
            {
                MessageBox.Show("姓名不能为空", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                b = false;
                return b;
            }

            if (actionFlag == 1)
            {
                if (GetStudentBySNO(txtNo.Text.Trim()) != string.Empty)
                {
                    MessageBox.Show("学号已经存在，请重新输入", "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNo.Focus();
                    b = false;
                    return b;
                }
            }
            return b;
        }//用户数据的校验

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFle = new OpenFileDialog();
            openFle.Filter = "图片(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp|所有文件(*.*)|*.*";
            if (openFle.ShowDialog() == DialogResult.OK)
            {
                photoName = openFle.FileName;
                pbCurrentPic.BackgroundImage = Image.FromFile(openFle.FileName);
            }
        }
    }
}

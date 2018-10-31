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
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void loadDataToDetial(string currentStudent)
        {
        }
    }
}

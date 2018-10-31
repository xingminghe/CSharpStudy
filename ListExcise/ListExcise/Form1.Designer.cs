namespace ListExcise
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInforList = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.dtpBorthday = new System.Windows.Forms.DateTimePicker();
            this.rdbFemle = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInforList
            // 
            this.dgvInforList.AllowUserToAddRows = false;
            this.dgvInforList.AllowUserToDeleteRows = false;
            this.dgvInforList.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInforList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInforList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInforList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInforList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SName,
            this.Major,
            this.Telephone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInforList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInforList.EnableHeadersVisualStyles = false;
            this.dgvInforList.Location = new System.Drawing.Point(16, 29);
            this.dgvInforList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInforList.Name = "dgvInforList";
            this.dgvInforList.ReadOnly = true;
            this.dgvInforList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvInforList.RowHeadersVisible = false;
            this.dgvInforList.RowTemplate.Height = 23;
            this.dgvInforList.Size = new System.Drawing.Size(672, 309);
            this.dgvInforList.TabIndex = 1;
            // 
            // SNO
            // 
            this.SNO.DataPropertyName = "SNO";
            this.SNO.HeaderText = "学号";
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            this.SNO.Width = 167;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "姓名";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 168;
            // 
            // Major
            // 
            this.Major.DataPropertyName = "Major";
            this.Major.HeaderText = "专业";
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            this.Major.Width = 167;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "电话号码";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // buttAdd
            // 
            this.buttAdd.Location = new System.Drawing.Point(861, 365);
            this.buttAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(103, 36);
            this.buttAdd.TabIndex = 0;
            this.buttAdd.Text = "添加";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMajor);
            this.groupBox1.Controls.Add(this.dtpBorthday);
            this.groupBox1.Controls.Add(this.rdbFemle);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.txtEmailAddress);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.txtSName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSNO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 429);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(887, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生信息";
            // 
            // cmbMajor
            // 
            this.cmbMajor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "电子工程",
            "英语",
            "计算机",
            "土木工程",
            "建筑设计"});
            this.cmbMajor.Location = new System.Drawing.Point(59, 100);
            this.cmbMajor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(132, 24);
            this.cmbMajor.TabIndex = 5;
            // 
            // dtpBorthday
            // 
            this.dtpBorthday.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpBorthday.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpBorthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorthday.Location = new System.Drawing.Point(709, 31);
            this.dtpBorthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBorthday.Name = "dtpBorthday";
            this.dtpBorthday.Size = new System.Drawing.Size(133, 22);
            this.dtpBorthday.TabIndex = 4;
            // 
            // rdbFemle
            // 
            this.rdbFemle.AutoSize = true;
            this.rdbFemle.Location = new System.Drawing.Point(531, 32);
            this.rdbFemle.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemle.Name = "rdbFemle";
            this.rdbFemle.Size = new System.Drawing.Size(43, 21);
            this.rdbFemle.TabIndex = 3;
            this.rdbFemle.Text = "女";
            this.rdbFemle.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Location = new System.Drawing.Point(476, 31);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(43, 21);
            this.rdbMale.TabIndex = 2;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "男";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmailAddress.Location = new System.Drawing.Point(508, 99);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(335, 22);
            this.txtEmailAddress.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTelephone.Location = new System.Drawing.Point(267, 99);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(132, 22);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtSName
            // 
            this.txtSName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSName.Location = new System.Drawing.Point(267, 28);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(132, 22);
            this.txtSName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "邮箱地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "出生日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名";
            // 
            // txtSNO
            // 
            this.txtSNO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSNO.Location = new System.Drawing.Point(59, 29);
            this.txtSNO.Margin = new System.Windows.Forms.Padding(4);
            this.txtSNO.Name = "txtSNO";
            this.txtSNO.Size = new System.Drawing.Size(132, 22);
            this.txtSNO.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "专业";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.dgvInforList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInforList;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.DateTimePicker dtpBorthday;
        private System.Windows.Forms.RadioButton rdbFemle;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
    }
}


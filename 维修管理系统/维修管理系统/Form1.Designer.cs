namespace 维修管理系统
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ManagerRadioButton = new System.Windows.Forms.RadioButton();
            this.EmployeeRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.WrongHint = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // ManagerRadioButton
            // 
            this.ManagerRadioButton.AutoSize = true;
            this.ManagerRadioButton.Location = new System.Drawing.Point(161, 52);
            this.ManagerRadioButton.Name = "ManagerRadioButton";
            this.ManagerRadioButton.Size = new System.Drawing.Size(59, 16);
            this.ManagerRadioButton.TabIndex = 1;
            this.ManagerRadioButton.Text = "管理员";
            this.ManagerRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeRadioButton
            // 
            this.EmployeeRadioButton.AutoSize = true;
            this.EmployeeRadioButton.Checked = true;
            this.EmployeeRadioButton.Location = new System.Drawing.Point(75, 52);
            this.EmployeeRadioButton.Name = "EmployeeRadioButton";
            this.EmployeeRadioButton.Size = new System.Drawing.Size(47, 16);
            this.EmployeeRadioButton.TabIndex = 2;
            this.EmployeeRadioButton.TabStop = true;
            this.EmployeeRadioButton.Text = "员工";
            this.EmployeeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密　码";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(102, 88);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(145, 21);
            this.userName.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(102, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(145, 21);
            this.password.TabIndex = 6;
            this.password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(46, 192);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 7;
            this.Login.Text = "登陆";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // WrongHint
            // 
            this.WrongHint.AutoSize = true;
            this.WrongHint.Location = new System.Drawing.Point(124, 163);
            this.WrongHint.Name = "WrongHint";
            this.WrongHint.Size = new System.Drawing.Size(101, 12);
            this.WrongHint.TabIndex = 8;
            this.WrongHint.Text = "用户名或密码错误";
            this.WrongHint.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(162, 192);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.WrongHint);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmployeeRadioButton);
            this.Controls.Add(this.ManagerRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "维修管理系统-登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ManagerRadioButton;
        private System.Windows.Forms.RadioButton EmployeeRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label WrongHint;
        private System.Windows.Forms.Button Exit;
    }
}


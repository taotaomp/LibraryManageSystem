namespace LibraryManageSystem
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_User = new System.Windows.Forms.Label();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.button_UserLogin = new System.Windows.Forms.Button();
            this.button_ReaderLogin = new System.Windows.Forms.Button();
            this.button_PassLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(359, 158);
            this.label_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(52, 15);
            this.label_User.TabIndex = 0;
            this.label_User.Text = "用户：";
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(362, 232);
            this.label_PassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(52, 15);
            this.label_PassWord.TabIndex = 1;
            this.label_PassWord.Text = "密码：";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(457, 154);
            this.textBox_User.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(132, 25);
            this.textBox_User.TabIndex = 2;
            this.textBox_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_User_KeyPress);
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(457, 228);
            this.textBox_PassWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(132, 25);
            this.textBox_PassWord.TabIndex = 3;
            // 
            // button_UserLogin
            // 
            this.button_UserLogin.Location = new System.Drawing.Point(365, 324);
            this.button_UserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.button_UserLogin.Name = "button_UserLogin";
            this.button_UserLogin.Size = new System.Drawing.Size(100, 29);
            this.button_UserLogin.TabIndex = 4;
            this.button_UserLogin.Text = "管理员登录";
            this.button_UserLogin.UseVisualStyleBackColor = true;
            this.button_UserLogin.Click += new System.EventHandler(this.button_UserLogin_Click);
            // 
            // button_ReaderLogin
            // 
            this.button_ReaderLogin.Location = new System.Drawing.Point(505, 324);
            this.button_ReaderLogin.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReaderLogin.Name = "button_ReaderLogin";
            this.button_ReaderLogin.Size = new System.Drawing.Size(100, 29);
            this.button_ReaderLogin.TabIndex = 5;
            this.button_ReaderLogin.Text = "读者登录";
            this.button_ReaderLogin.UseVisualStyleBackColor = true;
            this.button_ReaderLogin.Click += new System.EventHandler(this.button_ReaderLogin_Click);
            // 
            // button_PassLogin
            // 
            this.button_PassLogin.Location = new System.Drawing.Point(365, 392);
            this.button_PassLogin.Margin = new System.Windows.Forms.Padding(4);
            this.button_PassLogin.Name = "button_PassLogin";
            this.button_PassLogin.Size = new System.Drawing.Size(240, 29);
            this.button_PassLogin.TabIndex = 6;
            this.button_PassLogin.Text = "暂不登录";
            this.button_PassLogin.UseVisualStyleBackColor = true;
            this.button_PassLogin.Click += new System.EventHandler(this.button_PassLogin_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 624);
            this.Controls.Add(this.button_PassLogin);
            this.Controls.Add(this.button_ReaderLogin);
            this.Controls.Add(this.button_UserLogin);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.label_User);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Login";
            this.Text = "登陆窗口";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.Button button_UserLogin;
        private System.Windows.Forms.Button button_ReaderLogin;
        private System.Windows.Forms.Button button_PassLogin;
    }
}
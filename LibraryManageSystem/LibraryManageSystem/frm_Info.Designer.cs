namespace LibraryManageSystem
{
    partial class frm_Info
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
            this.groupBox_BasicData = new System.Windows.Forms.GroupBox();
            this.button_No = new System.Windows.Forms.Button();
            this.button_Sure = new System.Windows.Forms.Button();
            this.button_ModifyPassword = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Picture = new System.Windows.Forms.TextBox();
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_ModifyImage = new System.Windows.Forms.Button();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.textBox_OverTime = new System.Windows.Forms.TextBox();
            this.textBox_RepeatPassword = new System.Windows.Forms.TextBox();
            this.textBox_Borrow = new System.Windows.Forms.TextBox();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.label_Borrow = new System.Windows.Forms.Label();
            this.label_RepeatPassword = new System.Windows.Forms.Label();
            this.label_OverTime = new System.Windows.Forms.Label();
            this.radio_women = new System.Windows.Forms.RadioButton();
            this.radion_man = new System.Windows.Forms.RadioButton();
            this.label_ReaderSex = new System.Windows.Forms.Label();
            this.pictureBox_PersonnalPhoto = new System.Windows.Forms.PictureBox();
            this.textBox_ReaderType = new System.Windows.Forms.TextBox();
            this.textBox_ReaderName = new System.Windows.Forms.TextBox();
            this.label_ReaderType = new System.Windows.Forms.Label();
            this.label_ReaderId = new System.Windows.Forms.Label();
            this.textBox_ReaderId = new System.Windows.Forms.TextBox();
            this.label_ReaderName = new System.Windows.Forms.Label();
            this.openFileDialog_Image = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_BasicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonnalPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_BasicData
            // 
            this.groupBox_BasicData.Controls.Add(this.button_No);
            this.groupBox_BasicData.Controls.Add(this.button_Sure);
            this.groupBox_BasicData.Controls.Add(this.button_ModifyPassword);
            this.groupBox_BasicData.Controls.Add(this.textBox_Password);
            this.groupBox_BasicData.Controls.Add(this.label_Password);
            this.groupBox_BasicData.Controls.Add(this.textBox_Picture);
            this.groupBox_BasicData.Controls.Add(this.button_Yes);
            this.groupBox_BasicData.Controls.Add(this.button_ModifyImage);
            this.groupBox_BasicData.Controls.Add(this.textBox_NewPassword);
            this.groupBox_BasicData.Controls.Add(this.textBox_OverTime);
            this.groupBox_BasicData.Controls.Add(this.textBox_RepeatPassword);
            this.groupBox_BasicData.Controls.Add(this.textBox_Borrow);
            this.groupBox_BasicData.Controls.Add(this.label_NewPassword);
            this.groupBox_BasicData.Controls.Add(this.label_Borrow);
            this.groupBox_BasicData.Controls.Add(this.label_RepeatPassword);
            this.groupBox_BasicData.Controls.Add(this.label_OverTime);
            this.groupBox_BasicData.Controls.Add(this.radio_women);
            this.groupBox_BasicData.Controls.Add(this.radion_man);
            this.groupBox_BasicData.Controls.Add(this.label_ReaderSex);
            this.groupBox_BasicData.Controls.Add(this.pictureBox_PersonnalPhoto);
            this.groupBox_BasicData.Controls.Add(this.textBox_ReaderType);
            this.groupBox_BasicData.Controls.Add(this.textBox_ReaderName);
            this.groupBox_BasicData.Controls.Add(this.label_ReaderType);
            this.groupBox_BasicData.Controls.Add(this.label_ReaderId);
            this.groupBox_BasicData.Controls.Add(this.textBox_ReaderId);
            this.groupBox_BasicData.Controls.Add(this.label_ReaderName);
            this.groupBox_BasicData.Location = new System.Drawing.Point(16, 27);
            this.groupBox_BasicData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_BasicData.Name = "groupBox_BasicData";
            this.groupBox_BasicData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_BasicData.Size = new System.Drawing.Size(462, 531);
            this.groupBox_BasicData.TabIndex = 4;
            this.groupBox_BasicData.TabStop = false;
            this.groupBox_BasicData.Text = "读者基本资料";
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(44, 484);
            this.button_No.Margin = new System.Windows.Forms.Padding(4);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(100, 29);
            this.button_No.TabIndex = 38;
            this.button_No.Text = "取消修改";
            this.button_No.UseVisualStyleBackColor = true;
            // 
            // button_Sure
            // 
            this.button_Sure.Location = new System.Drawing.Point(347, 414);
            this.button_Sure.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sure.Name = "button_Sure";
            this.button_Sure.Size = new System.Drawing.Size(107, 29);
            this.button_Sure.TabIndex = 37;
            this.button_Sure.Text = "确认修改密码";
            this.button_Sure.UseVisualStyleBackColor = true;
            this.button_Sure.Click += new System.EventHandler(this.button_Sure_Click);
            // 
            // button_ModifyPassword
            // 
            this.button_ModifyPassword.Location = new System.Drawing.Point(0, 346);
            this.button_ModifyPassword.Margin = new System.Windows.Forms.Padding(4);
            this.button_ModifyPassword.Name = "button_ModifyPassword";
            this.button_ModifyPassword.Size = new System.Drawing.Size(100, 29);
            this.button_ModifyPassword.TabIndex = 36;
            this.button_ModifyPassword.Text = "修改密码";
            this.button_ModifyPassword.UseVisualStyleBackColor = true;
            this.button_ModifyPassword.Click += new System.EventHandler(this.button_ModifyPassword_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(102, 297);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(148, 25);
            this.textBox_Password.TabIndex = 35;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(18, 300);
            this.label_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(37, 15);
            this.label_Password.TabIndex = 34;
            this.label_Password.Text = "密码";
            // 
            // textBox_Picture
            // 
            this.textBox_Picture.Location = new System.Drawing.Point(274, 185);
            this.textBox_Picture.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Picture.Name = "textBox_Picture";
            this.textBox_Picture.Size = new System.Drawing.Size(86, 25);
            this.textBox_Picture.TabIndex = 33;
            // 
            // button_Yes
            // 
            this.button_Yes.Location = new System.Drawing.Point(338, 484);
            this.button_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(100, 29);
            this.button_Yes.TabIndex = 9;
            this.button_Yes.Text = "确认修改";
            this.button_Yes.UseVisualStyleBackColor = true;
            // 
            // button_ModifyImage
            // 
            this.button_ModifyImage.Location = new System.Drawing.Point(368, 185);
            this.button_ModifyImage.Margin = new System.Windows.Forms.Padding(4);
            this.button_ModifyImage.Name = "button_ModifyImage";
            this.button_ModifyImage.Size = new System.Drawing.Size(56, 25);
            this.button_ModifyImage.TabIndex = 32;
            this.button_ModifyImage.Text = "上传";
            this.button_ModifyImage.UseVisualStyleBackColor = true;
            this.button_ModifyImage.Click += new System.EventHandler(this.button_ModifyImage_Click);
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(168, 350);
            this.textBox_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(132, 25);
            this.textBox_NewPassword.TabIndex = 21;
            // 
            // textBox_OverTime
            // 
            this.textBox_OverTime.Location = new System.Drawing.Point(102, 264);
            this.textBox_OverTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_OverTime.Name = "textBox_OverTime";
            this.textBox_OverTime.Size = new System.Drawing.Size(148, 25);
            this.textBox_OverTime.TabIndex = 28;
            // 
            // textBox_RepeatPassword
            // 
            this.textBox_RepeatPassword.Location = new System.Drawing.Point(168, 414);
            this.textBox_RepeatPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RepeatPassword.Name = "textBox_RepeatPassword";
            this.textBox_RepeatPassword.Size = new System.Drawing.Size(132, 25);
            this.textBox_RepeatPassword.TabIndex = 20;
            // 
            // textBox_Borrow
            // 
            this.textBox_Borrow.Location = new System.Drawing.Point(102, 221);
            this.textBox_Borrow.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Borrow.Name = "textBox_Borrow";
            this.textBox_Borrow.Size = new System.Drawing.Size(148, 25);
            this.textBox_Borrow.TabIndex = 27;
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Location = new System.Drawing.Point(108, 353);
            this.label_NewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(52, 15);
            this.label_NewPassword.TabIndex = 19;
            this.label_NewPassword.Text = "新密码";
            // 
            // label_Borrow
            // 
            this.label_Borrow.AutoSize = true;
            this.label_Borrow.Location = new System.Drawing.Point(8, 224);
            this.label_Borrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Borrow.Name = "label_Borrow";
            this.label_Borrow.Size = new System.Drawing.Size(67, 15);
            this.label_Borrow.TabIndex = 26;
            this.label_Borrow.Text = "已借书数";
            // 
            // label_RepeatPassword
            // 
            this.label_RepeatPassword.AutoSize = true;
            this.label_RepeatPassword.Location = new System.Drawing.Point(99, 417);
            this.label_RepeatPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RepeatPassword.Name = "label_RepeatPassword";
            this.label_RepeatPassword.Size = new System.Drawing.Size(67, 15);
            this.label_RepeatPassword.TabIndex = 18;
            this.label_RepeatPassword.Text = "重复密码";
            // 
            // label_OverTime
            // 
            this.label_OverTime.AutoSize = true;
            this.label_OverTime.Location = new System.Drawing.Point(-3, 267);
            this.label_OverTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OverTime.Name = "label_OverTime";
            this.label_OverTime.Size = new System.Drawing.Size(97, 15);
            this.label_OverTime.TabIndex = 25;
            this.label_OverTime.Text = "过期未还书数";
            // 
            // radio_women
            // 
            this.radio_women.AutoSize = true;
            this.radio_women.ForeColor = System.Drawing.Color.Black;
            this.radio_women.Location = new System.Drawing.Point(160, 185);
            this.radio_women.Margin = new System.Windows.Forms.Padding(4);
            this.radio_women.Name = "radio_women";
            this.radio_women.Size = new System.Drawing.Size(43, 19);
            this.radio_women.TabIndex = 24;
            this.radio_women.Text = "女";
            this.radio_women.UseVisualStyleBackColor = true;
            // 
            // radion_man
            // 
            this.radion_man.AutoSize = true;
            this.radion_man.Checked = true;
            this.radion_man.ForeColor = System.Drawing.Color.Black;
            this.radion_man.Location = new System.Drawing.Point(88, 185);
            this.radion_man.Margin = new System.Windows.Forms.Padding(4);
            this.radion_man.Name = "radion_man";
            this.radion_man.Size = new System.Drawing.Size(43, 19);
            this.radion_man.TabIndex = 23;
            this.radion_man.TabStop = true;
            this.radion_man.Text = "男";
            this.radion_man.UseVisualStyleBackColor = true;
            // 
            // label_ReaderSex
            // 
            this.label_ReaderSex.AutoSize = true;
            this.label_ReaderSex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ReaderSex.Location = new System.Drawing.Point(8, 185);
            this.label_ReaderSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReaderSex.Name = "label_ReaderSex";
            this.label_ReaderSex.Size = new System.Drawing.Size(37, 15);
            this.label_ReaderSex.TabIndex = 22;
            this.label_ReaderSex.Text = "性别";
            // 
            // pictureBox_PersonnalPhoto
            // 
            this.pictureBox_PersonnalPhoto.Location = new System.Drawing.Point(274, 0);
            this.pictureBox_PersonnalPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_PersonnalPhoto.Name = "pictureBox_PersonnalPhoto";
            this.pictureBox_PersonnalPhoto.Size = new System.Drawing.Size(133, 170);
            this.pictureBox_PersonnalPhoto.TabIndex = 8;
            this.pictureBox_PersonnalPhoto.TabStop = false;
            // 
            // textBox_ReaderType
            // 
            this.textBox_ReaderType.Location = new System.Drawing.Point(71, 129);
            this.textBox_ReaderType.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReaderType.Name = "textBox_ReaderType";
            this.textBox_ReaderType.Size = new System.Drawing.Size(148, 25);
            this.textBox_ReaderType.TabIndex = 6;
            // 
            // textBox_ReaderName
            // 
            this.textBox_ReaderName.Location = new System.Drawing.Point(71, 81);
            this.textBox_ReaderName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReaderName.Name = "textBox_ReaderName";
            this.textBox_ReaderName.Size = new System.Drawing.Size(148, 25);
            this.textBox_ReaderName.TabIndex = 5;
            // 
            // label_ReaderType
            // 
            this.label_ReaderType.AutoSize = true;
            this.label_ReaderType.Location = new System.Drawing.Point(8, 132);
            this.label_ReaderType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReaderType.Name = "label_ReaderType";
            this.label_ReaderType.Size = new System.Drawing.Size(37, 15);
            this.label_ReaderType.TabIndex = 4;
            this.label_ReaderType.Text = "职别";
            // 
            // label_ReaderId
            // 
            this.label_ReaderId.AutoSize = true;
            this.label_ReaderId.Location = new System.Drawing.Point(8, 41);
            this.label_ReaderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReaderId.Name = "label_ReaderId";
            this.label_ReaderId.Size = new System.Drawing.Size(37, 15);
            this.label_ReaderId.TabIndex = 2;
            this.label_ReaderId.Text = "编号";
            // 
            // textBox_ReaderId
            // 
            this.textBox_ReaderId.Location = new System.Drawing.Point(71, 31);
            this.textBox_ReaderId.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReaderId.Name = "textBox_ReaderId";
            this.textBox_ReaderId.Size = new System.Drawing.Size(148, 25);
            this.textBox_ReaderId.TabIndex = 1;
            // 
            // label_ReaderName
            // 
            this.label_ReaderName.AutoSize = true;
            this.label_ReaderName.Location = new System.Drawing.Point(8, 84);
            this.label_ReaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReaderName.Name = "label_ReaderName";
            this.label_ReaderName.Size = new System.Drawing.Size(37, 15);
            this.label_ReaderName.TabIndex = 0;
            this.label_ReaderName.Text = "姓名";
            // 
            // openFileDialog_Image
            // 
            this.openFileDialog_Image.FileName = "openFileDialog1";
            // 
            // frm_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 571);
            this.Controls.Add(this.groupBox_BasicData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Info";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.frm_Info_Load);
            this.groupBox_BasicData.ResumeLayout(false);
            this.groupBox_BasicData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PersonnalPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_BasicData;
        private System.Windows.Forms.Label label_ReaderName;
        private System.Windows.Forms.PictureBox pictureBox_PersonnalPhoto;
        private System.Windows.Forms.TextBox textBox_ReaderType;
        private System.Windows.Forms.TextBox textBox_ReaderName;
        private System.Windows.Forms.Label label_ReaderType;
        private System.Windows.Forms.Label label_ReaderId;
        private System.Windows.Forms.TextBox textBox_ReaderId;
        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.RadioButton radio_women;
        private System.Windows.Forms.RadioButton radion_man;
        private System.Windows.Forms.Label label_ReaderSex;
        private System.Windows.Forms.TextBox textBox_OverTime;
        private System.Windows.Forms.TextBox textBox_Borrow;
        private System.Windows.Forms.Label label_Borrow;
        private System.Windows.Forms.Label label_OverTime;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.TextBox textBox_RepeatPassword;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.Label label_RepeatPassword;
        private System.Windows.Forms.TextBox textBox_Picture;
        private System.Windows.Forms.Button button_ModifyImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Image;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_ModifyPassword;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Button button_Sure;
    }
}


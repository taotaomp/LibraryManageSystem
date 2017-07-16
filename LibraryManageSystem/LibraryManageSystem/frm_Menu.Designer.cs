namespace LibraryManageSystem
{
    partial class frm_Menu
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
            this.button_Login = new System.Windows.Forms.Button();
            this.button_ReaderManage = new System.Windows.Forms.Button();
            this.button_Borrowed = new System.Windows.Forms.Button();
            this.button_PersonalInfo = new System.Windows.Forms.Button();
            this.button_BookManage = new System.Windows.Forms.Button();
            this.textBox_SearchInfo = new System.Windows.Forms.TextBox();
            this.comboBox_BookType = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_UserManage = new System.Windows.Forms.Button();
            this.label_State = new System.Windows.Forms.Label();
            this.button_ReturnBook = new System.Windows.Forms.Button();
            this.button_Eixt = new System.Windows.Forms.Button();
            this.panel_HotBook = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(768, 561);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(100, 29);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "登录";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_ReaderManage
            // 
            this.button_ReaderManage.Location = new System.Drawing.Point(403, 151);
            this.button_ReaderManage.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReaderManage.Name = "button_ReaderManage";
            this.button_ReaderManage.Size = new System.Drawing.Size(100, 29);
            this.button_ReaderManage.TabIndex = 1;
            this.button_ReaderManage.Text = "读者管理";
            this.button_ReaderManage.UseVisualStyleBackColor = true;
            this.button_ReaderManage.Click += new System.EventHandler(this.button_ReaderManage_Click);
            // 
            // button_Borrowed
            // 
            this.button_Borrowed.Location = new System.Drawing.Point(570, 151);
            this.button_Borrowed.Margin = new System.Windows.Forms.Padding(4);
            this.button_Borrowed.Name = "button_Borrowed";
            this.button_Borrowed.Size = new System.Drawing.Size(100, 29);
            this.button_Borrowed.TabIndex = 2;
            this.button_Borrowed.Text = "借阅纪录";
            this.button_Borrowed.UseVisualStyleBackColor = true;
            this.button_Borrowed.Click += new System.EventHandler(this.button_Borrowed_Click);
            // 
            // button_PersonalInfo
            // 
            this.button_PersonalInfo.Location = new System.Drawing.Point(737, 151);
            this.button_PersonalInfo.Margin = new System.Windows.Forms.Padding(4);
            this.button_PersonalInfo.Name = "button_PersonalInfo";
            this.button_PersonalInfo.Size = new System.Drawing.Size(131, 29);
            this.button_PersonalInfo.TabIndex = 3;
            this.button_PersonalInfo.Text = "个人信息维护";
            this.button_PersonalInfo.UseVisualStyleBackColor = true;
            this.button_PersonalInfo.Click += new System.EventHandler(this.button_PersonalInfo_Click);
            // 
            // button_BookManage
            // 
            this.button_BookManage.Location = new System.Drawing.Point(236, 151);
            this.button_BookManage.Margin = new System.Windows.Forms.Padding(4);
            this.button_BookManage.Name = "button_BookManage";
            this.button_BookManage.Size = new System.Drawing.Size(100, 29);
            this.button_BookManage.TabIndex = 4;
            this.button_BookManage.Text = "图书管理";
            this.button_BookManage.UseVisualStyleBackColor = true;
            this.button_BookManage.Click += new System.EventHandler(this.button_BookManage_Click);
            // 
            // textBox_SearchInfo
            // 
            this.textBox_SearchInfo.Location = new System.Drawing.Point(256, 73);
            this.textBox_SearchInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SearchInfo.Name = "textBox_SearchInfo";
            this.textBox_SearchInfo.Size = new System.Drawing.Size(199, 25);
            this.textBox_SearchInfo.TabIndex = 5;
            this.textBox_SearchInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SearchInfo_KeyPress);
            // 
            // comboBox_BookType
            // 
            this.comboBox_BookType.FormattingEnabled = true;
            this.comboBox_BookType.Location = new System.Drawing.Point(477, 73);
            this.comboBox_BookType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BookType.Name = "comboBox_BookType";
            this.comboBox_BookType.Size = new System.Drawing.Size(72, 23);
            this.comboBox_BookType.TabIndex = 6;
            this.comboBox_BookType.SelectedIndexChanged += new System.EventHandler(this.comboBox_BookType_SelectedIndexChanged);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(570, 69);
            this.button_Search.Margin = new System.Windows.Forms.Padding(4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(100, 29);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "查找";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_UserManage
            // 
            this.button_UserManage.Location = new System.Drawing.Point(69, 151);
            this.button_UserManage.Margin = new System.Windows.Forms.Padding(4);
            this.button_UserManage.Name = "button_UserManage";
            this.button_UserManage.Size = new System.Drawing.Size(100, 29);
            this.button_UserManage.TabIndex = 9;
            this.button_UserManage.Text = "管理员管理";
            this.button_UserManage.UseVisualStyleBackColor = true;
            this.button_UserManage.Click += new System.EventHandler(this.button_UserManage_Click);
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(17, 46);
            this.label_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(67, 15);
            this.label_State.TabIndex = 10;
            this.label_State.Text = "当前登录";
            // 
            // button_ReturnBook
            // 
            this.button_ReturnBook.Location = new System.Drawing.Point(935, 151);
            this.button_ReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReturnBook.Name = "button_ReturnBook";
            this.button_ReturnBook.Size = new System.Drawing.Size(100, 29);
            this.button_ReturnBook.TabIndex = 11;
            this.button_ReturnBook.Text = "还书";
            this.button_ReturnBook.UseVisualStyleBackColor = true;
            this.button_ReturnBook.Click += new System.EventHandler(this.button_ReturnBook_Click);
            // 
            // button_Eixt
            // 
            this.button_Eixt.Location = new System.Drawing.Point(917, 561);
            this.button_Eixt.Margin = new System.Windows.Forms.Padding(4);
            this.button_Eixt.Name = "button_Eixt";
            this.button_Eixt.Size = new System.Drawing.Size(100, 29);
            this.button_Eixt.TabIndex = 13;
            this.button_Eixt.Text = "退出";
            this.button_Eixt.UseVisualStyleBackColor = true;
            this.button_Eixt.Click += new System.EventHandler(this.button_Eixt_Click);
            // 
            // panel_HotBook
            // 
            this.panel_HotBook.Location = new System.Drawing.Point(69, 244);
            this.panel_HotBook.Name = "panel_HotBook";
            this.panel_HotBook.Size = new System.Drawing.Size(863, 284);
            this.panel_HotBook.TabIndex = 14;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 624);
            this.Controls.Add(this.panel_HotBook);
            this.Controls.Add(this.button_Eixt);
            this.Controls.Add(this.button_ReturnBook);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.button_UserManage);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBox_BookType);
            this.Controls.Add(this.textBox_SearchInfo);
            this.Controls.Add(this.button_BookManage);
            this.Controls.Add(this.button_PersonalInfo);
            this.Controls.Add(this.button_Borrowed);
            this.Controls.Add(this.button_ReaderManage);
            this.Controls.Add(this.button_Login);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Menu";
            this.Text = "图书馆管理系统";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_ReaderManage;
        private System.Windows.Forms.Button button_Borrowed;
        private System.Windows.Forms.Button button_PersonalInfo;
        private System.Windows.Forms.Button button_BookManage;
        private System.Windows.Forms.TextBox textBox_SearchInfo;
        private System.Windows.Forms.ComboBox comboBox_BookType;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_UserManage;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Button button_ReturnBook;
        private System.Windows.Forms.Button button_Eixt;
        private System.Windows.Forms.Panel panel_HotBook;
    }
}
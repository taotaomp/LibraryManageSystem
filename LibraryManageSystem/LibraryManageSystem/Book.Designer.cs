namespace LibraryManageSystem
{
    partial class Book
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Borrow = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.listBox_Book = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Borrow
            // 
            this.button_Borrow.Location = new System.Drawing.Point(336, 0);
            this.button_Borrow.Margin = new System.Windows.Forms.Padding(0);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(57, 50);
            this.button_Borrow.TabIndex = 1;
            this.button_Borrow.Text = "借书";
            this.button_Borrow.UseVisualStyleBackColor = true;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(393, 0);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(57, 50);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "下架";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // listBox_Book
            // 
            this.listBox_Book.FormattingEnabled = true;
            this.listBox_Book.ItemHeight = 15;
            this.listBox_Book.Location = new System.Drawing.Point(0, 1);
            this.listBox_Book.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_Book.Name = "listBox_Book";
            this.listBox_Book.Size = new System.Drawing.Size(336, 49);
            this.listBox_Book.TabIndex = 3;
            this.listBox_Book.Click += new System.EventHandler(this.listBox_Book_Click);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox_Book);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Borrow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(450, 50);
            this.Load += new System.EventHandler(this.Book_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.ListBox listBox_Book;
    }
}

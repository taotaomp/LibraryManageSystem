namespace LibraryManageSystem
{
    partial class frm_Record
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
            this.label_BorrowHistory = new System.Windows.Forms.Label();
            this.label_BorrowTotal = new System.Windows.Forms.Label();
            this.textBox_BorrowTotal = new System.Windows.Forms.TextBox();
            this.dataGridView_History = new System.Windows.Forms.DataGridView();
            this.groupBox_Detail = new System.Windows.Forms.GroupBox();
            this.textBox_BookId = new System.Windows.Forms.TextBox();
            this.textBox_BookName = new System.Windows.Forms.TextBox();
            this.textBox_ReaderId = new System.Windows.Forms.TextBox();
            this.textBox_BorrowTime = new System.Windows.Forms.TextBox();
            this.textBox_ReturnTime = new System.Windows.Forms.TextBox();
            this.label_BookId = new System.Windows.Forms.Label();
            this.label_ReaderId = new System.Windows.Forms.Label();
            this.label_ReturnTime = new System.Windows.Forms.Label();
            this.label_BookName = new System.Windows.Forms.Label();
            this.label_BorrowTime = new System.Windows.Forms.Label();
            this.Column_BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_BorrowStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_BorrowStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_NowBorrow = new System.Windows.Forms.Label();
            this.listView_BorrowNow = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_BorrowOver = new System.Windows.Forms.ListView();
            this.button_BackReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).BeginInit();
            this.groupBox_Detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_BorrowHistory
            // 
            this.label_BorrowHistory.AutoSize = true;
            this.label_BorrowHistory.Location = new System.Drawing.Point(16, 11);
            this.label_BorrowHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BorrowHistory.Name = "label_BorrowHistory";
            this.label_BorrowHistory.Size = new System.Drawing.Size(67, 15);
            this.label_BorrowHistory.TabIndex = 9;
            this.label_BorrowHistory.Text = "借阅历史";
            // 
            // label_BorrowTotal
            // 
            this.label_BorrowTotal.AutoSize = true;
            this.label_BorrowTotal.Location = new System.Drawing.Point(98, 737);
            this.label_BorrowTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BorrowTotal.Name = "label_BorrowTotal";
            this.label_BorrowTotal.Size = new System.Drawing.Size(67, 15);
            this.label_BorrowTotal.TabIndex = 11;
            this.label_BorrowTotal.Text = "共借书数";
            // 
            // textBox_BorrowTotal
            // 
            this.textBox_BorrowTotal.Location = new System.Drawing.Point(297, 734);
            this.textBox_BorrowTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BorrowTotal.Name = "textBox_BorrowTotal";
            this.textBox_BorrowTotal.Size = new System.Drawing.Size(132, 25);
            this.textBox_BorrowTotal.TabIndex = 12;
            // 
            // dataGridView_History
            // 
            this.dataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_History.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_BookName,
            this.Column_BookId,
            this.Column_ReaderId,
            this.Column_LendTime,
            this.Column_ReturnTime,
            this.Column_BorrowStatus});
            this.dataGridView_History.Location = new System.Drawing.Point(1, 43);
            this.dataGridView_History.Name = "dataGridView_History";
            this.dataGridView_History.RowTemplate.Height = 27;
            this.dataGridView_History.Size = new System.Drawing.Size(643, 328);
            this.dataGridView_History.TabIndex = 13;
            this.dataGridView_History.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_History_CellClick);
            // 
            // groupBox_Detail
            // 
            this.groupBox_Detail.Controls.Add(this.textBox1);
            this.groupBox_Detail.Controls.Add(this.label_BorrowStatus);
            this.groupBox_Detail.Controls.Add(this.textBox_BookId);
            this.groupBox_Detail.Controls.Add(this.textBox_BookName);
            this.groupBox_Detail.Controls.Add(this.textBox_ReaderId);
            this.groupBox_Detail.Controls.Add(this.textBox_BorrowTime);
            this.groupBox_Detail.Controls.Add(this.textBox_ReturnTime);
            this.groupBox_Detail.Controls.Add(this.label_BookId);
            this.groupBox_Detail.Controls.Add(this.label_ReaderId);
            this.groupBox_Detail.Controls.Add(this.label_ReturnTime);
            this.groupBox_Detail.Controls.Add(this.label_BookName);
            this.groupBox_Detail.Controls.Add(this.label_BorrowTime);
            this.groupBox_Detail.Location = new System.Drawing.Point(19, 411);
            this.groupBox_Detail.Name = "groupBox_Detail";
            this.groupBox_Detail.Size = new System.Drawing.Size(620, 125);
            this.groupBox_Detail.TabIndex = 14;
            this.groupBox_Detail.TabStop = false;
            this.groupBox_Detail.Text = "详细信息";
            // 
            // textBox_BookId
            // 
            this.textBox_BookId.Location = new System.Drawing.Point(99, 60);
            this.textBox_BookId.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BookId.Name = "textBox_BookId";
            this.textBox_BookId.Size = new System.Drawing.Size(132, 25);
            this.textBox_BookId.TabIndex = 22;
            // 
            // textBox_BookName
            // 
            this.textBox_BookName.Location = new System.Drawing.Point(99, 25);
            this.textBox_BookName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BookName.Name = "textBox_BookName";
            this.textBox_BookName.Size = new System.Drawing.Size(132, 25);
            this.textBox_BookName.TabIndex = 21;
            // 
            // textBox_ReaderId
            // 
            this.textBox_ReaderId.Location = new System.Drawing.Point(99, 93);
            this.textBox_ReaderId.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReaderId.Name = "textBox_ReaderId";
            this.textBox_ReaderId.Size = new System.Drawing.Size(132, 25);
            this.textBox_ReaderId.TabIndex = 20;
            // 
            // textBox_BorrowTime
            // 
            this.textBox_BorrowTime.Location = new System.Drawing.Point(468, 25);
            this.textBox_BorrowTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BorrowTime.Name = "textBox_BorrowTime";
            this.textBox_BorrowTime.Size = new System.Drawing.Size(132, 25);
            this.textBox_BorrowTime.TabIndex = 19;
            // 
            // textBox_ReturnTime
            // 
            this.textBox_ReturnTime.Location = new System.Drawing.Point(468, 60);
            this.textBox_ReturnTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReturnTime.Name = "textBox_ReturnTime";
            this.textBox_ReturnTime.Size = new System.Drawing.Size(132, 25);
            this.textBox_ReturnTime.TabIndex = 18;
            // 
            // label_BookId
            // 
            this.label_BookId.AutoSize = true;
            this.label_BookId.Location = new System.Drawing.Point(27, 70);
            this.label_BookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BookId.Name = "label_BookId";
            this.label_BookId.Size = new System.Drawing.Size(37, 15);
            this.label_BookId.TabIndex = 17;
            this.label_BookId.Text = "书号";
            // 
            // label_ReaderId
            // 
            this.label_ReaderId.AutoSize = true;
            this.label_ReaderId.Location = new System.Drawing.Point(12, 103);
            this.label_ReaderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReaderId.Name = "label_ReaderId";
            this.label_ReaderId.Size = new System.Drawing.Size(67, 15);
            this.label_ReaderId.TabIndex = 16;
            this.label_ReaderId.Text = "读者编号";
            // 
            // label_ReturnTime
            // 
            this.label_ReturnTime.AutoSize = true;
            this.label_ReturnTime.Location = new System.Drawing.Point(379, 70);
            this.label_ReturnTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReturnTime.Name = "label_ReturnTime";
            this.label_ReturnTime.Size = new System.Drawing.Size(67, 15);
            this.label_ReturnTime.TabIndex = 15;
            this.label_ReturnTime.Text = "还书日期";
            // 
            // label_BookName
            // 
            this.label_BookName.AutoSize = true;
            this.label_BookName.Location = new System.Drawing.Point(27, 28);
            this.label_BookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BookName.Name = "label_BookName";
            this.label_BookName.Size = new System.Drawing.Size(37, 15);
            this.label_BookName.TabIndex = 14;
            this.label_BookName.Text = "书名";
            // 
            // label_BorrowTime
            // 
            this.label_BorrowTime.AutoSize = true;
            this.label_BorrowTime.Location = new System.Drawing.Point(379, 25);
            this.label_BorrowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BorrowTime.Name = "label_BorrowTime";
            this.label_BorrowTime.Size = new System.Drawing.Size(67, 15);
            this.label_BorrowTime.TabIndex = 13;
            this.label_BorrowTime.Text = "借书日期";
            // 
            // Column_BookName
            // 
            this.Column_BookName.HeaderText = "书名";
            this.Column_BookName.Name = "Column_BookName";
            this.Column_BookName.ToolTipText = "书名";
            // 
            // Column_BookId
            // 
            this.Column_BookId.HeaderText = "书号";
            this.Column_BookId.Name = "Column_BookId";
            this.Column_BookId.ToolTipText = "书号";
            // 
            // Column_ReaderId
            // 
            this.Column_ReaderId.HeaderText = "读者编号";
            this.Column_ReaderId.Name = "Column_ReaderId";
            this.Column_ReaderId.ToolTipText = "读者编号";
            // 
            // Column_LendTime
            // 
            this.Column_LendTime.HeaderText = "借书日期";
            this.Column_LendTime.Name = "Column_LendTime";
            this.Column_LendTime.ToolTipText = "借书日期";
            // 
            // Column_ReturnTime
            // 
            this.Column_ReturnTime.HeaderText = "还书日期";
            this.Column_ReturnTime.Name = "Column_ReturnTime";
            this.Column_ReturnTime.ToolTipText = "还书日期";
            // 
            // Column_BorrowStatus
            // 
            this.Column_BorrowStatus.HeaderText = "借阅状态";
            this.Column_BorrowStatus.Name = "Column_BorrowStatus";
            // 
            // label_BorrowStatus
            // 
            this.label_BorrowStatus.AutoSize = true;
            this.label_BorrowStatus.Location = new System.Drawing.Point(379, 103);
            this.label_BorrowStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BorrowStatus.Name = "label_BorrowStatus";
            this.label_BorrowStatus.Size = new System.Drawing.Size(67, 15);
            this.label_BorrowStatus.TabIndex = 24;
            this.label_BorrowStatus.Text = "借阅状态";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 25;
            // 
            // label_NowBorrow
            // 
            this.label_NowBorrow.AutoSize = true;
            this.label_NowBorrow.Location = new System.Drawing.Point(31, 555);
            this.label_NowBorrow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NowBorrow.Name = "label_NowBorrow";
            this.label_NowBorrow.Size = new System.Drawing.Size(67, 15);
            this.label_NowBorrow.TabIndex = 17;
            this.label_NowBorrow.Text = "正在借阅";
            // 
            // listView_BorrowNow
            // 
            this.listView_BorrowNow.Location = new System.Drawing.Point(34, 596);
            this.listView_BorrowNow.Name = "listView_BorrowNow";
            this.listView_BorrowNow.Size = new System.Drawing.Size(236, 97);
            this.listView_BorrowNow.TabIndex = 18;
            this.listView_BorrowNow.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 555);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "超期";
            // 
            // listView_BorrowOver
            // 
            this.listView_BorrowOver.Location = new System.Drawing.Point(381, 596);
            this.listView_BorrowOver.Name = "listView_BorrowOver";
            this.listView_BorrowOver.Size = new System.Drawing.Size(236, 97);
            this.listView_BorrowOver.TabIndex = 20;
            this.listView_BorrowOver.UseCompatibleStateImageBehavior = false;
            // 
            // button_BackReturnBook
            // 
            this.button_BackReturnBook.Location = new System.Drawing.Point(507, 734);
            this.button_BackReturnBook.Name = "button_BackReturnBook";
            this.button_BackReturnBook.Size = new System.Drawing.Size(110, 23);
            this.button_BackReturnBook.TabIndex = 21;
            this.button_BackReturnBook.Text = "返回还书界面";
            this.button_BackReturnBook.UseVisualStyleBackColor = true;
            this.button_BackReturnBook.Click += new System.EventHandler(this.button_BackReturnBook_Click);
            // 
            // frm_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 772);
            this.Controls.Add(this.button_BackReturnBook);
            this.Controls.Add(this.listView_BorrowOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_BorrowNow);
            this.Controls.Add(this.label_NowBorrow);
            this.Controls.Add(this.groupBox_Detail);
            this.Controls.Add(this.dataGridView_History);
            this.Controls.Add(this.textBox_BorrowTotal);
            this.Controls.Add(this.label_BorrowTotal);
            this.Controls.Add(this.label_BorrowHistory);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Record";
            this.Text = "借阅记录";
            this.Load += new System.EventHandler(this.frm_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).EndInit();
            this.groupBox_Detail.ResumeLayout(false);
            this.groupBox_Detail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BorrowHistory;
        private System.Windows.Forms.Label label_BorrowTotal;
        private System.Windows.Forms.TextBox textBox_BorrowTotal;
        private System.Windows.Forms.DataGridView dataGridView_History;
        private System.Windows.Forms.GroupBox groupBox_Detail;
        private System.Windows.Forms.TextBox textBox_BookId;
        private System.Windows.Forms.TextBox textBox_BookName;
        private System.Windows.Forms.TextBox textBox_ReaderId;
        private System.Windows.Forms.TextBox textBox_BorrowTime;
        private System.Windows.Forms.TextBox textBox_ReturnTime;
        private System.Windows.Forms.Label label_BookId;
        private System.Windows.Forms.Label label_ReaderId;
        private System.Windows.Forms.Label label_ReturnTime;
        private System.Windows.Forms.Label label_BookName;
        private System.Windows.Forms.Label label_BorrowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReaderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReturnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BorrowStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_BorrowStatus;
        private System.Windows.Forms.Label label_NowBorrow;
        private System.Windows.Forms.ListView listView_BorrowNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_BorrowOver;
        public System.Windows.Forms.Button button_BackReturnBook;
    }
}
namespace LibraryManageSystem
{
    partial class frm_ReturnBook
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
            this.label_ReturnReaderName = new System.Windows.Forms.Label();
            this.textBox_ReturnReaderName = new System.Windows.Forms.TextBox();
            this.button_SureReturn = new System.Windows.Forms.Button();
            this.button_LookRecord = new System.Windows.Forms.Button();
            this.label_OverReturn = new System.Windows.Forms.Label();
            this.textBox_OverReturn = new System.Windows.Forms.TextBox();
            this.label_Over = new System.Windows.Forms.Label();
            this.button_ReturnSeek = new System.Windows.Forms.Button();
            this.listBox_NotReturn = new System.Windows.Forms.ListBox();
            this.button_AddAll = new System.Windows.Forms.Button();
            this.button_CancelAll = new System.Windows.Forms.Button();
            this.button_CancelOne = new System.Windows.Forms.Button();
            this.button_AddOne = new System.Windows.Forms.Button();
            this.listBox_Returning = new System.Windows.Forms.ListBox();
            this.listBox_OverBookName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_ReturnReaderName
            // 
            this.label_ReturnReaderName.AutoSize = true;
            this.label_ReturnReaderName.Location = new System.Drawing.Point(13, 47);
            this.label_ReturnReaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReturnReaderName.Name = "label_ReturnReaderName";
            this.label_ReturnReaderName.Size = new System.Drawing.Size(67, 15);
            this.label_ReturnReaderName.TabIndex = 3;
            this.label_ReturnReaderName.Text = "读者编号";
            // 
            // textBox_ReturnReaderName
            // 
            this.textBox_ReturnReaderName.Location = new System.Drawing.Point(118, 40);
            this.textBox_ReturnReaderName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReturnReaderName.Name = "textBox_ReturnReaderName";
            this.textBox_ReturnReaderName.Size = new System.Drawing.Size(132, 25);
            this.textBox_ReturnReaderName.TabIndex = 5;
            // 
            // button_SureReturn
            // 
            this.button_SureReturn.Location = new System.Drawing.Point(429, 525);
            this.button_SureReturn.Margin = new System.Windows.Forms.Padding(4);
            this.button_SureReturn.Name = "button_SureReturn";
            this.button_SureReturn.Size = new System.Drawing.Size(100, 29);
            this.button_SureReturn.TabIndex = 6;
            this.button_SureReturn.Text = "确认归还";
            this.button_SureReturn.UseVisualStyleBackColor = true;
            // 
            // button_LookRecord
            // 
            this.button_LookRecord.Location = new System.Drawing.Point(324, 40);
            this.button_LookRecord.Margin = new System.Windows.Forms.Padding(4);
            this.button_LookRecord.Name = "button_LookRecord";
            this.button_LookRecord.Size = new System.Drawing.Size(81, 29);
            this.button_LookRecord.TabIndex = 8;
            this.button_LookRecord.Text = "查看记录";
            this.button_LookRecord.UseVisualStyleBackColor = true;
            this.button_LookRecord.Click += new System.EventHandler(this.button_ReturnSeek_Click);
            // 
            // label_OverReturn
            // 
            this.label_OverReturn.AutoSize = true;
            this.label_OverReturn.Location = new System.Drawing.Point(202, 467);
            this.label_OverReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OverReturn.Name = "label_OverReturn";
            this.label_OverReturn.Size = new System.Drawing.Size(67, 15);
            this.label_OverReturn.TabIndex = 9;
            this.label_OverReturn.Text = "超借罚款";
            // 
            // textBox_OverReturn
            // 
            this.textBox_OverReturn.Location = new System.Drawing.Point(277, 457);
            this.textBox_OverReturn.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_OverReturn.Name = "textBox_OverReturn";
            this.textBox_OverReturn.Size = new System.Drawing.Size(132, 25);
            this.textBox_OverReturn.TabIndex = 10;
            // 
            // label_Over
            // 
            this.label_Over.AutoSize = true;
            this.label_Over.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Over.Location = new System.Drawing.Point(37, 390);
            this.label_Over.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Over.Name = "label_Over";
            this.label_Over.Size = new System.Drawing.Size(112, 15);
            this.label_Over.TabIndex = 40;
            this.label_Over.Text = "超出借阅期的书";
            // 
            // button_ReturnSeek
            // 
            this.button_ReturnSeek.Location = new System.Drawing.Point(429, 40);
            this.button_ReturnSeek.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReturnSeek.Name = "button_ReturnSeek";
            this.button_ReturnSeek.Size = new System.Drawing.Size(67, 29);
            this.button_ReturnSeek.TabIndex = 43;
            this.button_ReturnSeek.Text = "查找";
            this.button_ReturnSeek.UseVisualStyleBackColor = true;
            this.button_ReturnSeek.Click += new System.EventHandler(this.button_ReturnSeek_Click_1);
            // 
            // listBox_NotReturn
            // 
            this.listBox_NotReturn.FormattingEnabled = true;
            this.listBox_NotReturn.ItemHeight = 15;
            this.listBox_NotReturn.Location = new System.Drawing.Point(31, 109);
            this.listBox_NotReturn.Name = "listBox_NotReturn";
            this.listBox_NotReturn.Size = new System.Drawing.Size(150, 259);
            this.listBox_NotReturn.TabIndex = 44;
            // 
            // button_AddAll
            // 
            this.button_AddAll.Location = new System.Drawing.Point(205, 161);
            this.button_AddAll.Name = "button_AddAll";
            this.button_AddAll.Size = new System.Drawing.Size(102, 30);
            this.button_AddAll.TabIndex = 48;
            this.button_AddAll.Text = "添加所有";
            this.button_AddAll.UseVisualStyleBackColor = true;
            this.button_AddAll.Click += new System.EventHandler(this.button_AddAll_Click);
            // 
            // button_CancelAll
            // 
            this.button_CancelAll.Location = new System.Drawing.Point(205, 334);
            this.button_CancelAll.Name = "button_CancelAll";
            this.button_CancelAll.Size = new System.Drawing.Size(102, 34);
            this.button_CancelAll.TabIndex = 47;
            this.button_CancelAll.Text = "取消所有";
            this.button_CancelAll.UseVisualStyleBackColor = true;
            this.button_CancelAll.Click += new System.EventHandler(this.button_CancelAll_Click);
            // 
            // button_CancelOne
            // 
            this.button_CancelOne.Location = new System.Drawing.Point(205, 288);
            this.button_CancelOne.Name = "button_CancelOne";
            this.button_CancelOne.Size = new System.Drawing.Size(102, 35);
            this.button_CancelOne.TabIndex = 46;
            this.button_CancelOne.Text = "取消选择";
            this.button_CancelOne.UseVisualStyleBackColor = true;
            this.button_CancelOne.Click += new System.EventHandler(this.button_CancelOne_Click);
            // 
            // button_AddOne
            // 
            this.button_AddOne.Location = new System.Drawing.Point(205, 109);
            this.button_AddOne.Name = "button_AddOne";
            this.button_AddOne.Size = new System.Drawing.Size(102, 33);
            this.button_AddOne.TabIndex = 45;
            this.button_AddOne.Text = "添加选择";
            this.button_AddOne.UseVisualStyleBackColor = true;
            this.button_AddOne.Click += new System.EventHandler(this.button_AddOne_Click);
            // 
            // listBox_Returning
            // 
            this.listBox_Returning.FormattingEnabled = true;
            this.listBox_Returning.ItemHeight = 15;
            this.listBox_Returning.Location = new System.Drawing.Point(346, 109);
            this.listBox_Returning.Name = "listBox_Returning";
            this.listBox_Returning.Size = new System.Drawing.Size(150, 259);
            this.listBox_Returning.TabIndex = 49;
            // 
            // listBox_OverBookName
            // 
            this.listBox_OverBookName.FormattingEnabled = true;
            this.listBox_OverBookName.ItemHeight = 15;
            this.listBox_OverBookName.Location = new System.Drawing.Point(31, 427);
            this.listBox_OverBookName.Name = "listBox_OverBookName";
            this.listBox_OverBookName.Size = new System.Drawing.Size(150, 124);
            this.listBox_OverBookName.TabIndex = 50;
            // 
            // frm_ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 563);
            this.Controls.Add(this.listBox_OverBookName);
            this.Controls.Add(this.listBox_Returning);
            this.Controls.Add(this.button_AddAll);
            this.Controls.Add(this.button_CancelAll);
            this.Controls.Add(this.button_CancelOne);
            this.Controls.Add(this.button_AddOne);
            this.Controls.Add(this.listBox_NotReturn);
            this.Controls.Add(this.button_ReturnSeek);
            this.Controls.Add(this.label_Over);
            this.Controls.Add(this.textBox_OverReturn);
            this.Controls.Add(this.label_OverReturn);
            this.Controls.Add(this.button_LookRecord);
            this.Controls.Add(this.button_SureReturn);
            this.Controls.Add(this.textBox_ReturnReaderName);
            this.Controls.Add(this.label_ReturnReaderName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ReturnBook";
            this.Text = "还书";
            this.Load += new System.EventHandler(this.frm_ReturnBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ReturnReaderName;
        private System.Windows.Forms.TextBox textBox_ReturnReaderName;
        private System.Windows.Forms.Button button_SureReturn;
        private System.Windows.Forms.Button button_LookRecord;
        private System.Windows.Forms.Label label_OverReturn;
        private System.Windows.Forms.TextBox textBox_OverReturn;
        private System.Windows.Forms.Label label_Over;
        private System.Windows.Forms.Button button_ReturnSeek;
        private System.Windows.Forms.ListBox listBox_NotReturn;
        private System.Windows.Forms.Button button_AddAll;
        private System.Windows.Forms.Button button_CancelAll;
        private System.Windows.Forms.Button button_CancelOne;
        private System.Windows.Forms.Button button_AddOne;
        private System.Windows.Forms.ListBox listBox_Returning;
        private System.Windows.Forms.ListBox listBox_OverBookName;
    }
}
namespace LibraryManageSystem
{
    partial class frm_BookInfo
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
            this.panel = new System.Windows.Forms.Panel();
            this.label_pic = new System.Windows.Forms.Label();
            this.panelForText = new System.Windows.Forms.Panel();
            this.textBox_BookID = new System.Windows.Forms.TextBox();
            this.textBox_Book_Name = new System.Windows.Forms.TextBox();
            this.textBox_Bool_Writer = new System.Windows.Forms.TextBox();
            this.textBox_Book_Price = new System.Windows.Forms.TextBox();
            this.textBox_Book_ISBN = new System.Windows.Forms.TextBox();
            this.textBox_Book_EnterTime = new System.Windows.Forms.TextBox();
            this.textBox_Book_All = new System.Windows.Forms.TextBox();
            this.textBox_Book_Remain = new System.Windows.Forms.TextBox();
            this.label_Book_Remain = new System.Windows.Forms.Label();
            this.label_Book_All = new System.Windows.Forms.Label();
            this.label_Book_EnterTime = new System.Windows.Forms.Label();
            this.label_Book_ISBN = new System.Windows.Forms.Label();
            this.label_Book_Price = new System.Windows.Forms.Label();
            this.label_Bool_Writer = new System.Windows.Forms.Label();
            this.label_Book_Name = new System.Windows.Forms.Label();
            this.label_Book_ID = new System.Windows.Forms.Label();
            this.pictureBox_BookPic = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.panelForText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.label_pic);
            this.panel.Controls.Add(this.panelForText);
            this.panel.Controls.Add(this.label_Book_Remain);
            this.panel.Controls.Add(this.label_Book_All);
            this.panel.Controls.Add(this.label_Book_EnterTime);
            this.panel.Controls.Add(this.label_Book_ISBN);
            this.panel.Controls.Add(this.label_Book_Price);
            this.panel.Controls.Add(this.label_Bool_Writer);
            this.panel.Controls.Add(this.label_Book_Name);
            this.panel.Controls.Add(this.label_Book_ID);
            this.panel.Controls.Add(this.pictureBox_BookPic);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(637, 672);
            this.panel.TabIndex = 0;
            // 
            // label_pic
            // 
            this.label_pic.AutoSize = true;
            this.label_pic.CausesValidation = false;
            this.label_pic.Location = new System.Drawing.Point(415, 52);
            this.label_pic.Name = "label_pic";
            this.label_pic.Size = new System.Drawing.Size(53, 12);
            this.label_pic.TabIndex = 1;
            this.label_pic.Text = "图书图片";
            // 
            // panelForText
            // 
            this.panelForText.Controls.Add(this.textBox_BookID);
            this.panelForText.Controls.Add(this.textBox_Book_Name);
            this.panelForText.Controls.Add(this.textBox_Bool_Writer);
            this.panelForText.Controls.Add(this.textBox_Book_Price);
            this.panelForText.Controls.Add(this.textBox_Book_ISBN);
            this.panelForText.Controls.Add(this.textBox_Book_EnterTime);
            this.panelForText.Controls.Add(this.textBox_Book_All);
            this.panelForText.Controls.Add(this.textBox_Book_Remain);
            this.panelForText.Location = new System.Drawing.Point(97, 47);
            this.panelForText.Name = "panelForText";
            this.panelForText.Size = new System.Drawing.Size(236, 261);
            this.panelForText.TabIndex = 0;
            // 
            // textBox_BookID
            // 
            this.textBox_BookID.Location = new System.Drawing.Point(3, 19);
            this.textBox_BookID.Name = "textBox_BookID";
            this.textBox_BookID.ReadOnly = true;
            this.textBox_BookID.Size = new System.Drawing.Size(145, 21);
            this.textBox_BookID.TabIndex = 0;
            // 
            // textBox_Book_Name
            // 
            this.textBox_Book_Name.Location = new System.Drawing.Point(3, 46);
            this.textBox_Book_Name.Name = "textBox_Book_Name";
            this.textBox_Book_Name.ReadOnly = true;
            this.textBox_Book_Name.Size = new System.Drawing.Size(145, 21);
            this.textBox_Book_Name.TabIndex = 1;
            // 
            // textBox_Bool_Writer
            // 
            this.textBox_Bool_Writer.Location = new System.Drawing.Point(3, 73);
            this.textBox_Bool_Writer.Name = "textBox_Bool_Writer";
            this.textBox_Bool_Writer.ReadOnly = true;
            this.textBox_Bool_Writer.Size = new System.Drawing.Size(145, 21);
            this.textBox_Bool_Writer.TabIndex = 2;
            // 
            // textBox_Book_Price
            // 
            this.textBox_Book_Price.Location = new System.Drawing.Point(3, 100);
            this.textBox_Book_Price.Name = "textBox_Book_Price";
            this.textBox_Book_Price.ReadOnly = true;
            this.textBox_Book_Price.Size = new System.Drawing.Size(145, 21);
            this.textBox_Book_Price.TabIndex = 3;
            // 
            // textBox_Book_ISBN
            // 
            this.textBox_Book_ISBN.Location = new System.Drawing.Point(3, 127);
            this.textBox_Book_ISBN.Name = "textBox_Book_ISBN";
            this.textBox_Book_ISBN.ReadOnly = true;
            this.textBox_Book_ISBN.Size = new System.Drawing.Size(145, 21);
            this.textBox_Book_ISBN.TabIndex = 4;
            // 
            // textBox_Book_EnterTime
            // 
            this.textBox_Book_EnterTime.Location = new System.Drawing.Point(3, 154);
            this.textBox_Book_EnterTime.Name = "textBox_Book_EnterTime";
            this.textBox_Book_EnterTime.ReadOnly = true;
            this.textBox_Book_EnterTime.Size = new System.Drawing.Size(145, 21);
            this.textBox_Book_EnterTime.TabIndex = 5;
            // 
            // textBox_Book_All
            // 
            this.textBox_Book_All.Location = new System.Drawing.Point(3, 181);
            this.textBox_Book_All.Name = "textBox_Book_All";
            this.textBox_Book_All.ReadOnly = true;
            this.textBox_Book_All.Size = new System.Drawing.Size(145, 21);
            this.textBox_Book_All.TabIndex = 6;
            // 
            // textBox_Book_Remain
            // 
            this.textBox_Book_Remain.Location = new System.Drawing.Point(3, 208);
            this.textBox_Book_Remain.Name = "textBox_Book_Remain";
            this.textBox_Book_Remain.ReadOnly = true;
            this.textBox_Book_Remain.Size = new System.Drawing.Size(145, 21);
            this.textBox_Book_Remain.TabIndex = 7;
            // 
            // label_Book_Remain
            // 
            this.label_Book_Remain.AutoSize = true;
            this.label_Book_Remain.CausesValidation = false;
            this.label_Book_Remain.Location = new System.Drawing.Point(38, 259);
            this.label_Book_Remain.Name = "label_Book_Remain";
            this.label_Book_Remain.Size = new System.Drawing.Size(53, 12);
            this.label_Book_Remain.TabIndex = 1;
            this.label_Book_Remain.Text = "剩余数量";
            // 
            // label_Book_All
            // 
            this.label_Book_All.AutoSize = true;
            this.label_Book_All.CausesValidation = false;
            this.label_Book_All.Location = new System.Drawing.Point(38, 232);
            this.label_Book_All.Name = "label_Book_All";
            this.label_Book_All.Size = new System.Drawing.Size(53, 12);
            this.label_Book_All.TabIndex = 2;
            this.label_Book_All.Text = "该书总数";
            // 
            // label_Book_EnterTime
            // 
            this.label_Book_EnterTime.AutoSize = true;
            this.label_Book_EnterTime.CausesValidation = false;
            this.label_Book_EnterTime.Location = new System.Drawing.Point(38, 205);
            this.label_Book_EnterTime.Name = "label_Book_EnterTime";
            this.label_Book_EnterTime.Size = new System.Drawing.Size(53, 12);
            this.label_Book_EnterTime.TabIndex = 2;
            this.label_Book_EnterTime.Text = "入库时间";
            // 
            // label_Book_ISBN
            // 
            this.label_Book_ISBN.AutoSize = true;
            this.label_Book_ISBN.CausesValidation = false;
            this.label_Book_ISBN.Location = new System.Drawing.Point(38, 178);
            this.label_Book_ISBN.Name = "label_Book_ISBN";
            this.label_Book_ISBN.Size = new System.Drawing.Size(41, 12);
            this.label_Book_ISBN.TabIndex = 2;
            this.label_Book_ISBN.Text = "ISBN码";
            // 
            // label_Book_Price
            // 
            this.label_Book_Price.AutoSize = true;
            this.label_Book_Price.CausesValidation = false;
            this.label_Book_Price.Location = new System.Drawing.Point(38, 151);
            this.label_Book_Price.Name = "label_Book_Price";
            this.label_Book_Price.Size = new System.Drawing.Size(29, 12);
            this.label_Book_Price.TabIndex = 2;
            this.label_Book_Price.Text = "价格";
            // 
            // label_Bool_Writer
            // 
            this.label_Bool_Writer.AutoSize = true;
            this.label_Bool_Writer.CausesValidation = false;
            this.label_Bool_Writer.Location = new System.Drawing.Point(38, 124);
            this.label_Bool_Writer.Name = "label_Bool_Writer";
            this.label_Bool_Writer.Size = new System.Drawing.Size(29, 12);
            this.label_Bool_Writer.TabIndex = 2;
            this.label_Bool_Writer.Text = "作者";
            // 
            // label_Book_Name
            // 
            this.label_Book_Name.AutoSize = true;
            this.label_Book_Name.CausesValidation = false;
            this.label_Book_Name.Location = new System.Drawing.Point(38, 97);
            this.label_Book_Name.Name = "label_Book_Name";
            this.label_Book_Name.Size = new System.Drawing.Size(29, 12);
            this.label_Book_Name.TabIndex = 2;
            this.label_Book_Name.Text = "书名";
            // 
            // label_Book_ID
            // 
            this.label_Book_ID.AutoSize = true;
            this.label_Book_ID.CausesValidation = false;
            this.label_Book_ID.Font = new System.Drawing.Font("宋体", 9F);
            this.label_Book_ID.Location = new System.Drawing.Point(38, 70);
            this.label_Book_ID.Name = "label_Book_ID";
            this.label_Book_ID.Size = new System.Drawing.Size(41, 12);
            this.label_Book_ID.TabIndex = 2;
            this.label_Book_ID.Text = "索书号";
            // 
            // pictureBox_BookPic
            // 
            this.pictureBox_BookPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_BookPic.Location = new System.Drawing.Point(417, 67);
            this.pictureBox_BookPic.Name = "pictureBox_BookPic";
            this.pictureBox_BookPic.Size = new System.Drawing.Size(174, 204);
            this.pictureBox_BookPic.TabIndex = 0;
            this.pictureBox_BookPic.TabStop = false;
            // 
            // frm_BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 672);
            this.Controls.Add(this.panel);
            this.Name = "frm_BookInfo";
            this.ShowIcon = false;
            this.Text = "书本信息";
            this.Load += new System.EventHandler(this.frm_BookInfo_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelForText.ResumeLayout(false);
            this.panelForText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BookPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox_BookPic;
        private System.Windows.Forms.Label label_Book_Remain;
        private System.Windows.Forms.Label label_Book_All;
        private System.Windows.Forms.Label label_Book_EnterTime;
        private System.Windows.Forms.Label label_Book_ISBN;
        private System.Windows.Forms.Label label_Book_Price;
        private System.Windows.Forms.Label label_Bool_Writer;
        private System.Windows.Forms.Label label_Book_Name;
        private System.Windows.Forms.Label label_Book_ID;
        private System.Windows.Forms.TextBox textBox_Book_Remain;
        private System.Windows.Forms.TextBox textBox_Book_All;
        private System.Windows.Forms.TextBox textBox_Book_EnterTime;
        private System.Windows.Forms.TextBox textBox_Book_ISBN;
        private System.Windows.Forms.TextBox textBox_Book_Price;
        private System.Windows.Forms.TextBox textBox_Bool_Writer;
        private System.Windows.Forms.TextBox textBox_Book_Name;
        private System.Windows.Forms.TextBox textBox_BookID;
        private System.Windows.Forms.Panel panelForText;
        private System.Windows.Forms.Label label_pic;
    }
}


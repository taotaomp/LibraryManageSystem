namespace LibraryManageSystem
{
    partial class frm_SearchResult
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
            this.button_Search = new System.Windows.Forms.Button();
            this.comboBox_BookType = new System.Windows.Forms.ComboBox();
            this.textBox_SearchInfo = new System.Windows.Forms.TextBox();
            this.panel_SearchResult = new System.Windows.Forms.Panel();
            this.label_State = new System.Windows.Forms.Label();
            this.button_Disper = new System.Windows.Forms.Button();
            this.button_AddBook = new System.Windows.Forms.Button();
            this.panel_Type = new System.Windows.Forms.Panel();
            this.checkBox_N = new System.Windows.Forms.CheckBox();
            this.checkBox_K = new System.Windows.Forms.CheckBox();
            this.checkBox_J = new System.Windows.Forms.CheckBox();
            this.checkBox_H = new System.Windows.Forms.CheckBox();
            this.checkBox8_I = new System.Windows.Forms.CheckBox();
            this.checkBox_G = new System.Windows.Forms.CheckBox();
            this.checkBox_F = new System.Windows.Forms.CheckBox();
            this.checkBox_E = new System.Windows.Forms.CheckBox();
            this.checkBox_D = new System.Windows.Forms.CheckBox();
            this.checkBox_C = new System.Windows.Forms.CheckBox();
            this.checkBox_B = new System.Windows.Forms.CheckBox();
            this.checkBox_A = new System.Windows.Forms.CheckBox();
            this.panel_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(605, 95);
            this.button_Search.Margin = new System.Windows.Forms.Padding(4);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(100, 29);
            this.button_Search.TabIndex = 11;
            this.button_Search.Text = "查找";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // comboBox_BookType
            // 
            this.comboBox_BookType.FormattingEnabled = true;
            this.comboBox_BookType.Location = new System.Drawing.Point(511, 98);
            this.comboBox_BookType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_BookType.Name = "comboBox_BookType";
            this.comboBox_BookType.Size = new System.Drawing.Size(72, 23);
            this.comboBox_BookType.TabIndex = 10;
            this.comboBox_BookType.SelectedIndexChanged += new System.EventHandler(this.comboBox_BookType_SelectedIndexChanged);
            // 
            // textBox_SearchInfo
            // 
            this.textBox_SearchInfo.Location = new System.Drawing.Point(256, 98);
            this.textBox_SearchInfo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SearchInfo.Name = "textBox_SearchInfo";
            this.textBox_SearchInfo.Size = new System.Drawing.Size(228, 25);
            this.textBox_SearchInfo.TabIndex = 9;
            this.textBox_SearchInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SearchInfo_KeyPress);
            // 
            // panel_SearchResult
            // 
            this.panel_SearchResult.Location = new System.Drawing.Point(255, 173);
            this.panel_SearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.panel_SearchResult.Name = "panel_SearchResult";
            this.panel_SearchResult.Size = new System.Drawing.Size(506, 339);
            this.panel_SearchResult.TabIndex = 12;
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(35, 34);
            this.label_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(67, 15);
            this.label_State.TabIndex = 13;
            this.label_State.Text = "当前状态";
            // 
            // button_Disper
            // 
            this.button_Disper.Location = new System.Drawing.Point(661, 548);
            this.button_Disper.Margin = new System.Windows.Forms.Padding(4);
            this.button_Disper.Name = "button_Disper";
            this.button_Disper.Size = new System.Drawing.Size(100, 29);
            this.button_Disper.TabIndex = 14;
            this.button_Disper.Text = "取消";
            this.button_Disper.UseVisualStyleBackColor = true;
            this.button_Disper.Click += new System.EventHandler(this.button_Disper_Click);
            // 
            // button_AddBook
            // 
            this.button_AddBook.Location = new System.Drawing.Point(803, 94);
            this.button_AddBook.Name = "button_AddBook";
            this.button_AddBook.Size = new System.Drawing.Size(100, 29);
            this.button_AddBook.TabIndex = 15;
            this.button_AddBook.Text = "上架";
            this.button_AddBook.UseVisualStyleBackColor = true;
            this.button_AddBook.Click += new System.EventHandler(this.button_AddBook_Click);
            // 
            // panel_Type
            // 
            this.panel_Type.Controls.Add(this.checkBox_N);
            this.panel_Type.Controls.Add(this.checkBox_K);
            this.panel_Type.Controls.Add(this.checkBox_J);
            this.panel_Type.Controls.Add(this.checkBox_H);
            this.panel_Type.Controls.Add(this.checkBox8_I);
            this.panel_Type.Controls.Add(this.checkBox_G);
            this.panel_Type.Controls.Add(this.checkBox_F);
            this.panel_Type.Controls.Add(this.checkBox_E);
            this.panel_Type.Controls.Add(this.checkBox_D);
            this.panel_Type.Controls.Add(this.checkBox_C);
            this.panel_Type.Controls.Add(this.checkBox_B);
            this.panel_Type.Controls.Add(this.checkBox_A);
            this.panel_Type.Location = new System.Drawing.Point(226, 51);
            this.panel_Type.Name = "panel_Type";
            this.panel_Type.Size = new System.Drawing.Size(535, 100);
            this.panel_Type.TabIndex = 16;
            // 
            // checkBox_N
            // 
            this.checkBox_N.AutoSize = true;
            this.checkBox_N.Location = new System.Drawing.Point(343, 74);
            this.checkBox_N.Name = "checkBox_N";
            this.checkBox_N.Size = new System.Drawing.Size(89, 19);
            this.checkBox_N.TabIndex = 11;
            this.checkBox_N.Text = "自然科学";
            this.checkBox_N.UseVisualStyleBackColor = true;
            this.checkBox_N.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_K
            // 
            this.checkBox_K.AutoSize = true;
            this.checkBox_K.Location = new System.Drawing.Point(236, 74);
            this.checkBox_K.Name = "checkBox_K";
            this.checkBox_K.Size = new System.Drawing.Size(104, 19);
            this.checkBox_K.TabIndex = 10;
            this.checkBox_K.Text = "历史·地理";
            this.checkBox_K.UseVisualStyleBackColor = true;
            this.checkBox_K.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_J
            // 
            this.checkBox_J.AutoSize = true;
            this.checkBox_J.Location = new System.Drawing.Point(129, 74);
            this.checkBox_J.Name = "checkBox_J";
            this.checkBox_J.Size = new System.Drawing.Size(59, 19);
            this.checkBox_J.TabIndex = 9;
            this.checkBox_J.Text = "艺术";
            this.checkBox_J.UseVisualStyleBackColor = true;
            this.checkBox_J.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_H
            // 
            this.checkBox_H.AutoSize = true;
            this.checkBox_H.Location = new System.Drawing.Point(343, 49);
            this.checkBox_H.Name = "checkBox_H";
            this.checkBox_H.Size = new System.Drawing.Size(104, 19);
            this.checkBox_H.TabIndex = 8;
            this.checkBox_H.Text = "语言·文字";
            this.checkBox_H.UseVisualStyleBackColor = true;
            this.checkBox_H.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox8_I
            // 
            this.checkBox8_I.AutoSize = true;
            this.checkBox8_I.Location = new System.Drawing.Point(22, 74);
            this.checkBox8_I.Name = "checkBox8_I";
            this.checkBox8_I.Size = new System.Drawing.Size(59, 19);
            this.checkBox8_I.TabIndex = 7;
            this.checkBox8_I.Text = "文学";
            this.checkBox8_I.UseVisualStyleBackColor = true;
            this.checkBox8_I.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_G
            // 
            this.checkBox_G.AutoSize = true;
            this.checkBox_G.Location = new System.Drawing.Point(235, 49);
            this.checkBox_G.Name = "checkBox_G";
            this.checkBox_G.Size = new System.Drawing.Size(104, 19);
            this.checkBox_G.TabIndex = 6;
            this.checkBox_G.Text = "文化·教育";
            this.checkBox_G.UseVisualStyleBackColor = true;
            this.checkBox_G.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_F
            // 
            this.checkBox_F.AutoSize = true;
            this.checkBox_F.Location = new System.Drawing.Point(129, 49);
            this.checkBox_F.Name = "checkBox_F";
            this.checkBox_F.Size = new System.Drawing.Size(59, 19);
            this.checkBox_F.TabIndex = 5;
            this.checkBox_F.Text = "经济";
            this.checkBox_F.UseVisualStyleBackColor = true;
            this.checkBox_F.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_E
            // 
            this.checkBox_E.AutoSize = true;
            this.checkBox_E.Location = new System.Drawing.Point(22, 49);
            this.checkBox_E.Name = "checkBox_E";
            this.checkBox_E.Size = new System.Drawing.Size(59, 19);
            this.checkBox_E.TabIndex = 4;
            this.checkBox_E.Text = "军事";
            this.checkBox_E.UseVisualStyleBackColor = true;
            this.checkBox_E.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_D
            // 
            this.checkBox_D.AutoSize = true;
            this.checkBox_D.Location = new System.Drawing.Point(343, 21);
            this.checkBox_D.Name = "checkBox_D";
            this.checkBox_D.Size = new System.Drawing.Size(104, 19);
            this.checkBox_D.TabIndex = 3;
            this.checkBox_D.Text = "政治·法律";
            this.checkBox_D.UseVisualStyleBackColor = true;
            this.checkBox_D.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_C
            // 
            this.checkBox_C.AutoSize = true;
            this.checkBox_C.Location = new System.Drawing.Point(236, 21);
            this.checkBox_C.Name = "checkBox_C";
            this.checkBox_C.Size = new System.Drawing.Size(89, 19);
            this.checkBox_C.TabIndex = 2;
            this.checkBox_C.Text = "社会科学";
            this.checkBox_C.UseVisualStyleBackColor = true;
            this.checkBox_C.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_B
            // 
            this.checkBox_B.AutoSize = true;
            this.checkBox_B.Location = new System.Drawing.Point(129, 21);
            this.checkBox_B.Name = "checkBox_B";
            this.checkBox_B.Size = new System.Drawing.Size(59, 19);
            this.checkBox_B.TabIndex = 1;
            this.checkBox_B.Text = "哲学";
            this.checkBox_B.UseVisualStyleBackColor = true;
            this.checkBox_B.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // checkBox_A
            // 
            this.checkBox_A.AutoSize = true;
            this.checkBox_A.Location = new System.Drawing.Point(22, 21);
            this.checkBox_A.Name = "checkBox_A";
            this.checkBox_A.Size = new System.Drawing.Size(104, 19);
            this.checkBox_A.TabIndex = 0;
            this.checkBox_A.Text = "马克思主义";
            this.checkBox_A.UseVisualStyleBackColor = true;
            this.checkBox_A.CheckedChanged += new System.EventHandler(this.checkBox_D_CheckedChanged);
            // 
            // frm_SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 624);
            this.Controls.Add(this.panel_Type);
            this.Controls.Add(this.button_AddBook);
            this.Controls.Add(this.button_Disper);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.panel_SearchResult);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBox_BookType);
            this.Controls.Add(this.textBox_SearchInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SearchResult";
            this.Text = "查询结果";
            this.Load += new System.EventHandler(this.frm_SearchResult_Load);
            this.panel_Type.ResumeLayout(false);
            this.panel_Type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.ComboBox comboBox_BookType;
        private System.Windows.Forms.TextBox textBox_SearchInfo;
        private System.Windows.Forms.Panel panel_SearchResult;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Button button_Disper;
        private System.Windows.Forms.Button button_AddBook;
        private System.Windows.Forms.Panel panel_Type;
        private System.Windows.Forms.CheckBox checkBox_N;
        private System.Windows.Forms.CheckBox checkBox_K;
        private System.Windows.Forms.CheckBox checkBox_J;
        private System.Windows.Forms.CheckBox checkBox_H;
        private System.Windows.Forms.CheckBox checkBox8_I;
        private System.Windows.Forms.CheckBox checkBox_G;
        private System.Windows.Forms.CheckBox checkBox_F;
        private System.Windows.Forms.CheckBox checkBox_E;
        private System.Windows.Forms.CheckBox checkBox_D;
        private System.Windows.Forms.CheckBox checkBox_C;
        private System.Windows.Forms.CheckBox checkBox_B;
        private System.Windows.Forms.CheckBox checkBox_A;
    }
}
namespace LibraryManageSystem
{
    partial class frm_Start
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
            this.components = new System.ComponentModel.Container();
            this.label_InfoShow = new System.Windows.Forms.Label();
            this.timer_Roller = new System.Windows.Forms.Timer(this.components);
            this.timer_FormCloser = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_InfoShow
            // 
            this.label_InfoShow.AutoSize = true;
            this.label_InfoShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_InfoShow.Font = new System.Drawing.Font("华文仿宋", 13F);
            this.label_InfoShow.Location = new System.Drawing.Point(0, 344);
            this.label_InfoShow.Name = "label_InfoShow";
            this.label_InfoShow.Size = new System.Drawing.Size(81, 20);
            this.label_InfoShow.TabIndex = 0;
            this.label_InfoShow.Text = "感谢使用";
            // 
            // timer_Roller
            // 
            this.timer_Roller.Tick += new System.EventHandler(this.timer_Roller_Tick);
            // 
            // timer_FormCloser
            // 
            this.timer_FormCloser.Tick += new System.EventHandler(this.timer_FormCloser_Tick);
            // 
            // frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.label_InfoShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Start";
            this.Load += new System.EventHandler(this.frm_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InfoShow;
        private System.Windows.Forms.Timer timer_Roller;
        private System.Windows.Forms.Timer timer_FormCloser;
    }
}
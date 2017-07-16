using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManageSystem
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        String[] InfoContainer = new String[2];
        int RollFlag;

        private void StartSetting()
        {
            timer_FormCloser.Interval = 2400;
            timer_FormCloser.Enabled = true;
            RollFlag = 0;
            timer_Roller.Interval = 800;
            timer_Roller.Enabled = true;
            InfoContainer[0] = "正在连接数据库";
            //InfoContainer[1] = "连接成功";
        }

        private void frm_Start_Load(object sender, EventArgs e)
        {
            StartSetting();
            DataBase DB_Statt = new DataBase();
            if (DB_Statt.SqlConnect() == true)
            {
                InfoContainer[1] = "连接成功";
            }
            else
            {
                InfoContainer[1] = "连接失败";
            }
        }

        private void timer_Roller_Tick(object sender, EventArgs e)
        {
            label_InfoShow.Text = InfoContainer[RollFlag++];
            if (RollFlag == 2)
            {
                timer_Roller.Stop();
            }
        }

        private void timer_FormCloser_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login Login = new frm_Login();
            Login.Show();
            timer_FormCloser.Stop();
        }
    }
}

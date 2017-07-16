using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//使用ArrayList的引用

namespace LibraryManageSystem
{
    public partial class frm_Login : Form
    {
        public static string Login = "";//全局静态变量，代表登录状态
        public static string Login_Name;//记录登录的学号
        public frm_Login()
        {
            InitializeComponent();
        }

        private void button_PassLogin_Click(object sender, EventArgs e)
        {
            Login = "no";       //暂不登陆
            frm_Menu frm = new frm_Menu();
            frm.Show();
            this.Hide();
        }

        private void button_UserLogin_Click(object sender, EventArgs e)
        {
            if (check("Manage","Manage_Id"))
            {
                ArrayList List = new ArrayList();
                DataBase database = new DataBase();
                database.SqlConnect();
                List = database.SqlSelect("Manage_Id", "Manage", textBox_User.Text,"=");
                if (List[0].ToString().Split('#')[3] == "0")        //判断是否是超级管理员
                {
                    Login = "User";//不是超级管理员
                }
                else
                {
                    Login = "";//是超级管理员
                }
                Login_Name = textBox_User.Text;
                frm_Menu frm = new frm_Menu();
                frm.Show();
                this.Hide();
            }
        }

        private void button_ReaderLogin_Click(object sender, EventArgs e)
        {
            if (check("Reader","Reader_Id"))
            {
                Login = "Reader";       //读者登录
                Login_Name = textBox_User.Text;
                frm_Menu frm = new frm_Menu();
                frm.Show();
                this.Hide();
            }
        }

        //登录时检测用户名，密码是否正确
        //正确返回true，错误返回false
        //形参为登录人所需呀检索的表名
        private bool check(string TableName,string located)
        {
            if (textBox_User.Text == "")
            {
                MessageBox.Show("用户名不能为空！","警告！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox_User.Focus();
                return false;
            }
            else if(textBox_User.Text != "" && textBox_PassWord.Text == "")
            {
                MessageBox.Show("密码不能为空！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_PassWord.Focus();
                return false;
            }
            ArrayList List = new ArrayList();
            DataBase database=new DataBase();
            database.SqlConnect();
            List = database.SqlSelect(located,TableName,textBox_User.Text,"=");
            if (List.Count > 0)
            {
                string[] s = List[0].ToString().Split('#');
                int q;
                if (TableName == "Manage") { q = 2; }
                else { q = 6; }
                if (s[q].Trim() != textBox_PassWord.Text)
                {
                    MessageBox.Show("密码错误！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_PassWord.SelectAll();
                    textBox_PassWord.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("用户名不存在！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_User.SelectAll();
                textBox_User.Focus();
                return false;
            }
        }

        private void textBox_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                textBox_PassWord.Focus();
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            textBox_PassWord.PasswordChar = '*';
        }
    }
}

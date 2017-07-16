using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManageSystem
{
    public partial class frm_Info : Form
    {
    public static byte[] byte_Image = null;//添加照片
    public static byte[] byte_Image2 = null;//查看图片
    public frm_Info()
        {
            InitializeComponent();
        }
    public void UserInfoLoad(string UserId) //加载全部用户信息的函数，调用Database内的SqlSelect
     {
         ArrayList list = new ArrayList();
         DataBase data = new DataBase();
         data.SqlConnect();
         list = data.SqlSelect("Reader_Id", "Reader", frm_Login.Login_Name, "=");
         textBox_ReaderId.Text = list.ToString().Split('#')[0];
         textBox_ReaderName.Text = list.ToString().Split('#')[1];
         textBox_ReaderType.Text = list.ToString().Split('#')[2];
         textBox_Borrow.Text = list.ToString().Split('#')[4];
         textBox_OverTime.Text = list.ToString().Split('#')[5];
         if (list.ToString().Split('#')[3] == "男")
         {
             this.radion_man.Checked = true;
         }
         if (list.ToString().Split('#')[7] != null)
         {
             byte_Image2 = System.Text.Encoding.Default.GetBytes(list.ToString().Split('#')[7]);
             MemoryStream ms = new MemoryStream(byte_Image2);
             pictureBox_PersonnalPhoto.Image = Image.FromStream(ms);
         }
     }
    public void ModifyInfo(string UserId)//修改信息函数，调用database内的SqlUpdate, UserId为用户ID
        {
         DataBase data= new DataBase();
         data.SqlConnect();
         String TempSplitValue = textBox_ReaderId.Text + '#' + textBox_ReaderName.Text+ '#' + textBox_ReaderType.Text + '#' +radion_man.Text+ '#' +textBox_Borrow.Text + '#' + textBox_OverTime.Text+ '#' +textBox_Password.Text + '#' +pictureBox_PersonnalPhoto.Image;
         data.SqlUpdate("Reader_Id", "Reader", TempSplitValue,frm_Login.Login_Name);
        }
    public bool ModifyPassword() //修改密码函数，返回值为bool型，false为修改失败，true为修改成功
       {
         string pwd = this.textBox_NewPassword.Text.Trim();//密码1
         string pwd2 = this.textBox_RepeatPassword.Text.Trim();//密码2
            if (pwd == "")
            {
                MessageBox.Show("密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (pwd2 == "")
            {
                MessageBox.Show("确认密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (pwd != pwd2)
            {
                MessageBox.Show("密码输入不相同,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.textBox_RepeatPassword.Text = "";
                return false;
            }
            else
            {
              MessageBox.Show("修改成功");
              return true;
            }
       }
    private void button_ModifyInformation_Click(object sender, EventArgs e)//修改信息按钮事件
     {
           ModifyInfo(frm_Login.Login_Name);
     }
    private void frm_Info_Load(object sender, EventArgs e)//修改信息窗体加载事件
        {
          label_NewPassword.Visible = false;
          label_RepeatPassword.Visible = false;
          textBox_NewPassword.Visible = false;            
          textBox_RepeatPassword.Visible = false;            //隐藏修改密码控件
          button_Sure.Visible = false;
          UserInfoLoad(frm_Login.Login_Name);             //根据登录者Id从数据库加载信息显示在登陆界面
         }
    private void button_ModifyImage_Click(object sender, EventArgs e)//修改头像
        {
             try
            {
                openFileDialog_Image.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                openFileDialog_Image.Filter = "图片（*.jpg;*.bmp;*.gif,*.png）|*.jpg;*.bmp;*.gif;*.png";
                if (openFileDialog_Image.ShowDialog() == DialogResult.OK)
                {
                    this.textBox_Picture.Text = openFileDialog_Image.FileName;
                    pictureBox_PersonnalPhoto.Image = Image.FromFile(textBox_Picture.Text);
                    pictureBox_PersonnalPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    FileStream fs = new FileStream(openFileDialog_Image.FileName, FileMode.Open, FileAccess.Read);
                    BinaryReader bw = new BinaryReader(fs);
                    byte_Image = bw.ReadBytes((int)fs.Length);
                }
            }
            catch
            {
                MessageBox.Show("请选择正确的图片格式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    private void button_ModifyPassword_Click(object sender, EventArgs e)//点击修改密码后，显示相应控件
        {
            label_NewPassword.Visible = true;
            label_NewPassword.Visible = true;
           textBox_NewPassword.Visible = true;
           textBox_RepeatPassword.Visible = true;
           button_Sure.Visible = true;
        }
    private void button_Sure_Click(object sender, EventArgs e)//确认修改密码事件，调用修改密码函数
        {
           if(ModifyPassword()==true)                     //如果修改密码成功，改变密码框内的内容
           {
           textBox_Password.Text=textBox_NewPassword.Text; 
           }
        }
    }
}

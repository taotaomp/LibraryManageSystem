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
    public partial class frm_InfoManage : Form
    {
        public static byte[] byte_Image2 = null;//查看图片
        public frm_InfoManage()
        {
            InitializeComponent();
        }
        private void KeepImage() //将图片位置保存在数据库中
      {

        string filename = textBox_Picture.Text;//图片文件所在的路径
        BinaryReader reader=null;
        FileStream myfilestream = new FileStream(filename,FileMode.Open); 
         try
       {
        reader=new BinaryReader(myfilestream);
        byte[] image = reader.ReadBytes((int)myfilestream.Length);//存储图片到数组中。
        DataBase data = new DataBase();
        data.SqlConnect();
        data.SqlInsert("Manager", "image");
        }
        catch(IOException ee)
       {
        MessageBox.Show(ee.Message.ToString());
        }
       finally
       {
       if(reader!=null)
       reader.Close();
   }
  }
        public void UserInfoLoad(string UserId) //加载全部用户信息的函数，调用Database内的SqlSelect
        {
            ArrayList list = new ArrayList();
            DataBase data = new DataBase();
            data.SqlConnect();
            list = data.SqlSelect("Manage_Id", "Manage", frm_Login.Login_Name, "=");
            textBox_ManageId.Text = list.ToString().Split('#')[0];
            textBox_ManageName.Text = list.ToString().Split('#')[1];
            if (list.ToString().Split('#')[3] == "超级管理员")
            {
                this.radion_SuperManage.Checked = true;
            }
            if (list.ToString().Split('#')[4] != null)
            {
                byte_Image2 = System.Text.Encoding.Default.GetBytes(list.ToString().Split('#')[4]);
                MemoryStream ms = new MemoryStream(byte_Image2);
                pictureBox_ManagePhoto.Image = Image.FromStream(ms);
            }
        }
        public void ModifyInfo(string ManageId)//修改信息函数，调用database内的SqlUpdate, UserId为用户ID
        {
            DataBase data = new DataBase();
            data.SqlConnect();
            String TempSplitValue = textBox_ManageId.Text + '#' + textBox_ManageId.Text + '#' + textBox_ManagePassword.Text + '#' + radion_SuperManage.Text + '#' + pictureBox_ManagePhoto.Image;
            data.SqlUpdate("Manage_Id", "Manage", TempSplitValue, frm_Login.Login_Name);
        }
        private void button_ModifyImage_Click(object sender, EventArgs e)//上传图片事件
        {
            KeepImage();
        }
    }
}

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

namespace LibraryManageSystem
{
    public partial class frm_ReturnBook : Form
    {
       public static ArrayList recieve = frm_Record.OverBookName;//声明借阅记录窗体中过期未还书接收变量
       public frm_ReturnBook()
        {
            InitializeComponent();
        }
       private void returnBook(string ReaderID)	//管理员确认归还书籍的窗体，调用Database内的SqlUpdate
        {
            DataBase data = new DataBase();
           data.SqlConnect();
           for (int i = 0; i < listBox_Returning.Items.Count; i++)  //通过循环逐条更新数据
           {
             data.SqlUpdate("Borrowd_Status", "1", "Reader_Id", "Book_Name", listBox_Returning.Items[i].ToString());    //更新借阅状态
           }
           MessageBox.Show("确认归还");
        }
       private decimal calPenalty(DateTime ReturnTime) //计算罚金函数
        {
            int overDays = 365 * (System.DateTime.Now.Year - ReturnTime.Year) + System.DateTime.Now.DayOfYear - ReturnTime.DayOfYear; //计算过期天数
            decimal fee = (decimal)0.2 * overDays;  //根据过期天数计算罚金，本实例中定为每天0.2元
            return (fee);
        }
       private void ShowMulct()//显示罚金函数
       {
           foreach (ListViewItem item in listBox_Returning.Controls) //遍历已经选择要还的书
           {
               for (int i = 0; i < listBox_OverBookName.Items.Count; i++) //循环逾期未还书籍
               {
                      if (listBox_OverBookName.Items[i] == item) //提取要还的书中有逾期未还的书籍
                      {
                         int j=i; //书名与借书时间一一对应，获取逾期未还书籍的借书时间
                         textBox_OverReturn.Text+=calPenalty((DateTime)frm_Record.OverTimeBook[j]); //调用计算罚金函数计算罚金
                       }
               }
           }
          
       }
       private void button_SureReturn_Click(object sender, EventArgs e)//确认归还事件
        {
            returnBook(textBox_ReturnReaderName.Text);//调用归还书籍函数
        }
       private void button_ReturnSeek_Click(object sender, EventArgs e) //点击查看记录的反应事件
       {
           this.Hide();                                  //隐藏还书界面
           frm_Record record = new frm_Record();
           record.button_BackReturnBook.Visible = true;  //显示阅读记录中的返回还书界面
           record.Show();                               //显示阅读记录
       }
       private void button_ReturnSeek_Click_1(object sender, EventArgs e) //查看为还书名
       {
           ArrayList recieve = frm_Record.BookName; //接受有借阅记录传递的信息
           listBox_NotReturn.DataSource = recieve;//将信息显示在listbox控件中
       }
       private void button_AddAll_Click(object sender, EventArgs e) //添加选择的所有内容
       {
           listBox_Returning.DataSource = listBox_NotReturn.Items;
       }
       private void button_AddOne_Click(object sender, EventArgs e) //添加选择的内容
       {
           listBox_Returning.Items.Add(listBox_NotReturn.SelectedItem);
       }
       private void button_CancelOne_Click(object sender, EventArgs e)//删除选择的内容
       {
           listBox_Returning.Items.Remove(listBox_Returning.SelectedItem);
       }
       private void button_CancelAll_Click(object sender, EventArgs e)//删除所有内容
       {
           listBox_Returning.Items.Clear();
       }
       private void frm_ReturnBook_Load(object sender, EventArgs e) //还书界面加载事件
       {
           button_ReturnSeek.Visible = false;  //隐藏查找按钮
           listBox_Returning.MultiColumn = true;
           listBox_NotReturn.MultiColumn = true;
           listBox_OverBookName.DataSource = recieve;//将信息显示在listbox控件中
       }
    }
}

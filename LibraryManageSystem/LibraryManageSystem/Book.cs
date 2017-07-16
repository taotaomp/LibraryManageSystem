using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManageSystem
{
    public partial class Book : UserControl
    {
        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            if (frm_Login.Login == "Reader")
            {
                button_Delete.Visible = false;
            }
            else if (frm_Login.Login == "no")
            {
                button_Delete.Visible = false;
                button_Borrow.Visible = false;
            }
            listBox_Book.SelectionMode = SelectionMode.None;     //设置该控件为不可选择内容
        }

        private void listBox_Book_Click(object sender, EventArgs e)
        {
            frm_BookInfo BookInfo = new frm_BookInfo(this.listBox_Book.Items[1].ToString().Trim(), frm_Login.Login, frm_Login.Login_Name);
            BookInfo.Show();
            //书本信息窗体
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            //弹出框提示是否确认借书
            if (DialogResult.OK == MessageBox.Show("确定借阅本书？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
            {
                DataBase database = new DataBase();
                database.SqlConnect();
                 //判断借书数量是否超出界限
                //已借书数《=可借书数
                if (int.Parse(database.SqlSelect("Reader_Id", "Reader", frm_Login.Login_Name,"=")[0].ToString().Split('#')[4]) <=int.Parse(database.SqlSelect("Reader_Type","ReaderType",database.SqlSelect("Reader_Id", "Reader", frm_Login.Login_Name,"=")[0].ToString().Split('#')[2],"=")[0].ToString().Split('#')[1]))  
                {
                    string insert = string.Empty;
                    //insert为整理的借阅纪录的信息
                    insert = insert + this.listBox_Book.Items[1].ToString().Trim() + "#" + frm_Login.Login_Name + "#";
                    insert = insert + time() + "#" + 0 + "#" + database.SqlSelect("Book_Id", "Book", this.listBox_Book.Items[1].ToString().Trim(), "=")[0].ToString().Split('#')[1];
                    //插入一条借阅纪录
                    database.SqlInsert("Borroweed", insert);
                    //lass为借阅后剩余图书
                    int lass=int.Parse(database.SqlSelect("Book_Id","Book",this.listBox_Book.Items[1].ToString().Trim(),"=")[0].ToString().Split('#')[8])-1;
                    //更新Book表中剩余图书
                    database.SqlUpdate("Book_Remain",lass+"","Book_Name","Book",database.SqlSelect("Book_Id","Book",this.listBox_Book.Items[1].ToString().Trim(),"=")[0].ToString().Split('#')[1]);
                    //yi为读者借阅后已借数量
                    int yi = int.Parse(database.SqlSelect("Reader_Id", "Raeder", frm_Login.Login_Name, "=")[0].ToString().Split('#')[4]) + 1;
                    //更新Reader表的已借数量
                    database.SqlUpdate("Reader_Borrow", yi + "", "Reader_Id", "Reader", frm_Login.Login_Name);
                }
                else
                {
                    MessageBox.Show("借书数量达到上限！","警告！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        //此函数为获得借书时间与还书时间的函数
        //返回值为借书时间与还书时间
        private string time()
        {
            DataBase database = new DataBase();
            database.SqlConnect();
            DateTime data = DateTime.Now;
            int i=data.Month;
            i+=int.Parse(database.SqlSelect("Reader_Type","ReaderType",database.SqlSelect("Reader_Id", "Reader", frm_Login.Login_Name,"=")[0].ToString().Split('#')[2],"=")[0].ToString().Split('#')[2])/30;
            string Returntime = data.ToString() + "#" + data.Year + "/" + i + "/" + data.Day + " " + data.Hour + ":" + data.Minute + ":" + data.Second;
            return Returntime;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定下架本书？", "警告！", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                DataBase database = new DataBase();
                database.SqlConnect();
                //判断书籍是否全部归还
                //if（图书总数==剩余图书）
                if (int.Parse(database.SqlSelect("Book_Id", "Book", this.listBox_Book.Items[1].ToString().Trim(), "=")[0].ToString().Split('#')[7]) == int.Parse(database.SqlSelect("Book_Id", "Book", this.listBox_Book.Items[1].ToString().Trim(), "=")[0].ToString().Split('#')[8]))
                {
                    database.SqlDelete("Book_Id", "Book", database.SqlSelect("Book_Id", "Book", this.listBox_Book.Items[1].ToString().Trim(), "=")[0].ToString().Split('#')[1]);
                }
                else
                {
                    MessageBox.Show("书籍没有收集完全，不能下架！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

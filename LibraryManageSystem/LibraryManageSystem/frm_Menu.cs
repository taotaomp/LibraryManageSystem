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
    public partial class frm_Menu : Form
    {
        public static string SearchInfo;//查找的关键词
        public static string SearchType;//查找的类型
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.Show();
            this.Close();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            panel_HotBook.AutoScroll = true;
            if (frm_Login.Login == "no")
            {
                label_State.Text = "暂未登录";
                button_UserManage.Visible = false;
                button_ReaderManage.Visible = false;
                button_BookManage.Visible = false;
                button_ReturnBook.Visible = false;
                button_Borrowed.Visible = false;
                button_PersonalInfo.Visible = false;
            }
            else if (frm_Login.Login == "User")
            {
                label_State.Text = "管理员登录";
                button_Login.Visible = false;
                button_UserManage.Visible = false;
            }
            else if (frm_Login.Login == "Reader")
            {
                label_State.Text = "读者登录";
                button_Login.Visible = false;
                button_UserManage.Visible = false;
                button_ReaderManage.Visible = false;
                button_BookManage.Visible = false;
                button_ReturnBook.Visible = false;
            }
            else
            { 
                label_State.Text="超级管理员";
                button_Login.Visible = false;
            }                                                               //以上为确定登录状态，然后隐藏一些权限
            string[] s = { "书名","作者","类型","all"};                     //设置查找类型
            comboBox_BookType.DataSource = s;
            comboBox_BookType.SelectedIndex = 0;
            comboBox_BookType.DropDownStyle = ComboBoxStyle.DropDownList;
            HotBook();                                                      //加载HotBook
        }

        private void HotBook()              //用于显示菜单界面HotBook
        {
            DataBase database = new DataBase();
            ArrayList List = new ArrayList();
            database.SqlConnect();
            List = database.SqlSelect("Borrowed");      //查询所有借阅纪录      待修改
            string[] Book_Name=new string[List.Count];
            for(int i=0;i<List.Count;i++)
            {
                Book_Name[i] = List[i].ToString().Split('#')[6];
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();    //建立字典
            for (int i = 0; i < List.Count; i++)                            //for内统计相同的借阅书籍的次数
            {
                if (Book_Name[i] != "")
                {
                    dic.Add(Book_Name[i], 0);
                }
                for (int j = i; j < List.Count; j++)
                {
                    if (dic.ContainsKey(Book_Name[j]))
                    {
                        dic[Book_Name[i]]++;
                        Book_Name[j] = "";
                    }
                }
            }
            string[] HotBook = new string[5];
            dic = (from entry in dic orderby entry.Value descending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);//将字典按values降序排列
            int n = 5;//用来防止借阅纪录的书籍不足5本
            int pass = 0;//单纯用在下面的foreach内，控制退出循环
            if (dic.Count < 5)
            {
                n = dic.Count;
            }
            foreach (string name in dic.Keys)         //提取出借阅量前五的书籍
            {
                HotBook[pass] = name + "_" + dic[name];
                pass++;
                if (pass >= n)
                {
                    break;
                }
            }
            Book book = new Book();
            if (n == 0)
            {
                book.Top = 0;
                book.listBox_Book.Items.Add("暂无热门书籍！");
                panel_HotBook.Controls.Add(book);
            }
            for (int i = 0; i < n; i++)         //向容器内加入图书控件，显示HotBOOK
            {
                book.Top = i * 50;
                book.listBox_Book.Items.Add(HotBook[i].Split('_')[0] + "\t" + database.SqlSelect("Book_Name", "Book", HotBook[i].Split('_')[0], "=")[0].ToString().Split('#')[2]);
                book.listBox_Book.Items.Add(database.SqlSelect("Book_Name", "Book", HotBook[i].Split('_')[0], "=")[0].ToString().Split('#')[0]);
                book.listBox_Book.Items.Add(database.SqlSelect("借阅次数：" + HotBook[i].Split('_')[1]+"\t剩余图书：" + "Book_Name", "Book", HotBook[i].Split('_')[0], "=")[0].ToString().Split('#')[8]+"本");
                panel_HotBook.Controls.Add(book);
            }
        }

        private void button_Eixt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if ((comboBox_BookType.Text == "书名" || comboBox_BookType.Text == "作者") && textBox_SearchInfo.Text == "")
            {
                MessageBox.Show("请输入搜索关键字！");
            }
            else
            {
                SearchInfo = textBox_SearchInfo.Text;
                SearchType = comboBox_BookType.Text;
                frm_SearchResult frm = new frm_SearchResult();
                frm.Show();
                this.Close();
            }
        }

        private void button_PersonalInfo_Click(object sender, EventArgs e)
        {
            if (frm_Login.Login == "Reader")
            {
                frm_Info Info = new frm_Info();
                Info.Show();
            }
            else if (frm_Login.Login == "" || frm_Login.Login == "User")
            {
                frm_InfoManage InfoManage = new frm_InfoManage();
                InfoManage.Show();
            }
        }

        private void button_Borrowed_Click(object sender, EventArgs e)
        {
            frm_Record record = new frm_Record();//借阅纪录窗体
        }

        private void button_ReaderManage_Click(object sender, EventArgs e)
        {
            frm_InfoManage InfoManage = new frm_InfoManage();
            InfoManage.Show();
            //个人信息窗体
        }

        private void button_BookManage_Click(object sender, EventArgs e)
        {
            SearchType = "all";
            frm_SearchResult frm = new frm_SearchResult();
            frm.Show();
            this.Close();
        }

        private void button_UserManage_Click(object sender, EventArgs e)
        {
            //个人信息窗体
        }

        private void button_ReturnBook_Click(object sender, EventArgs e)
        {
            frm_ReturnBook ReturnBook = new frm_ReturnBook();//还书窗体
            ReturnBook.Show();
        }

        private void comboBox_BookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_BookType.SelectedIndex == 3)
            {
                SearchType = "all";
                SearchInfo = "";
                frm_SearchResult frm = new frm_SearchResult();
                frm.Show();
                this.Close();
            }
            else if (comboBox_BookType.SelectedIndex == 2)
            {
                SearchType = "类型";
                frm_SearchResult frm = new frm_SearchResult();
                frm.Show();
                this.Close();
            }
        }

        private void textBox_SearchInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && (comboBox_BookType.Text == "书名" || comboBox_BookType.Text == "作者") && textBox_SearchInfo.Text == "")
            {
                MessageBox.Show("请输入搜索关键字！");
            }
            else if (e.KeyChar == 13 && comboBox_BookType.Text != String.Empty )
            {
                SearchInfo = textBox_SearchInfo.Text;
                SearchType = comboBox_BookType.Text;
                frm_SearchResult frm = new frm_SearchResult();
                frm.Show();
                this.Close();
            }
        }
    }
}

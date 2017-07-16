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
    public partial class frm_SearchResult : Form
    {
        public frm_SearchResult()
        {
            InitializeComponent();
        }

        private void frm_SearchResult_Load(object sender, EventArgs e)
        {
            panel_Type.Visible = false;
            panel_SearchResult.AutoScroll = true;
            if (frm_Menu.SearchType == "类型")       //如果为类型查找，隐藏查找框等，只能点击取消按钮退回菜单
            {
                panel_Type.Visible = true;
                textBox_SearchInfo.Visible = false;
                comboBox_BookType.Visible = false;
                button_Search.Visible = false;
            }
            else
            {
                Search(frm_Menu.SearchType, frm_Menu.SearchInfo);
            }
            string[] s = { "书名", "作者", "类型", "all" };
            comboBox_BookType.DataSource = s;
            comboBox_BookType.SelectedIndex = 0;
            comboBox_BookType.DropDownStyle = ComboBoxStyle.DropDownList;
            if (frm_Login.Login == "Reader"||frm_Login.Login=="no")        //如果是读者登录或者未登录，隐藏上架按钮
            {
                button_AddBook.Visible = false;
            }
        }

        private void button_Disper_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Menu frm = new frm_Menu();
            frm.Show();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if ((comboBox_BookType.Text == "书名" || comboBox_BookType.Text == "作者") && textBox_SearchInfo.Text == "")
            {
                MessageBox.Show("请输入搜索关键字！");
            }
            else
            {
                Search(comboBox_BookType.Text, textBox_SearchInfo.Text);
            }
        }

        private void comboBox_BookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_BookType.SelectedIndex == 3)
            {
                Search("all", "");
            }
            else if (comboBox_BookType.SelectedIndex == 2)
            {
                panel_Type.Visible = true;
                textBox_SearchInfo.Visible = false;
                comboBox_BookType.Visible = false;
                button_Search.Visible = false;
            }
        }

        //写一个查询函数
        //Type为查询类型，Searchinfo为查询信息
        private void Search(string Type, string SearchInfo)
        {
            panel_SearchResult.Controls.Clear();    //清空panel容器内的用户控件
            ArrayList List = new ArrayList();
            DataBase database = new DataBase();
            database.SqlConnect();
            if (Type == "书名")
            {
                List = database.SqlSelect("Book_Name", "Book", "%" + SearchInfo + "%", "LIKE");
            }
            else if (Type == "作者")
            {
                List = database.SqlSelect("Book_Writer", "Book", "%" + SearchInfo + "%", "LIKE");
            }
            else if (Type == "类型")
            {
                List = database.SqlSelect("Book");      //查询所有信息
                string[] a = SearchInfo.Split('#');
                for (int i = 0; i < List.Count;)
                {
                    bool n=false;            //用于判断图书是否符合类型
                    string book_type=List[i].ToString().Split('#')[0].Split('_')[0];
                    for(int j=0;j<a.Length;j++)
                    {
                        while (book_type == a[j])
                        {
                            i++;
                            n = true;
                            break;
                        }
                    }
                    if(!n)
                    {
                        List.RemoveAt(i);
                    }
                }
            }
            else if(Type=="all")
            {
                List = database.SqlSelect("Book");      //查询所有信息
                //按all查询
            }
            //为了消除相同书名的重复项
            for (int i = 0; i < List.Count; i++)
            {
                for (int j = i; j < List.Count-1; j++)
                {
                    if(List[j].ToString().Split('#')[1]==List[j+1].ToString().Split('#')[1])
                    {
                        List.RemoveAt(j+1);
                    }
                }
            }
            string[,] s = new string[List.Count, 4];        //装List的分解后的数据
            if (List.Count == 0)
            {
                Book book = new Book();
                book.Top = 0;
                book.listBox_Book.Items.Add("没有你要查找的书籍......");
                panel_SearchResult.Controls.Add(book);
            }
            //将书本信息显示出来，panel加载用户控件
            for (int i = 0; i < List.Count; i++)
            {
                s[i, 2] = List[i].ToString().Split('#')[0];
                s[i, 0] = List[i].ToString().Split('#')[1];
                s[i, 1] = List[i].ToString().Split('#')[2];
                s[i, 3] = List[i].ToString().Split('#')[8];
                Book book = new Book();
                book.Top = i * 50;
                book.listBox_Book.Items.Add(s[i, 0] + "\t" + s[i, 1]);
                book.listBox_Book.Items.Add(s[i, 2]);
                book.listBox_Book.Items.Add("剩余图书：" + s[i, 3] + "本");
                panel_SearchResult.Controls.Add(book);
            }
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            //书本信息窗体
        }

        private void checkBox_D_CheckedChanged(object sender, EventArgs e)
        {
            string Type = string.Empty;
            int i = 0;
            foreach (Control c in panel_Type.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ck=c as CheckBox;
                    if (ck.Checked == true)
                    {
                        if (i > 0)
                        {
                            Type = Type + "#"+ ck.Name.Split('_')[1];
                        }
                        else
                        {
                            Type = ck.Name.Split('_')[1];
                        }
                        i++;
                    }
                }
            }
            Search("类型", Type);
        }

        private void textBox_SearchInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && (comboBox_BookType.Text == "书名" || comboBox_BookType.Text == "作者") && textBox_SearchInfo.Text == "")
            {
                MessageBox.Show("请输入搜索关键字！");
            }
            else if (e.KeyChar == 13 && comboBox_BookType.Text != String.Empty || comboBox_BookType.Text != String.Empty)
            {
                Search(comboBox_BookType.Text, textBox_SearchInfo.Text);
            }
        }


    }
}

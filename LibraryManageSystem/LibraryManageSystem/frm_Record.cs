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


namespace LibraryManageSystem
{
    public partial class frm_Record : Form
    {
        SqlConnection ConnectObject;//声明数据库连接对象
        SqlDataAdapter sqlda;//声明数据库桥接器对象
        DataBase data;  //声明数据库类对象
        public static ArrayList BookName;//声明正在借阅中的书的数组
        public static ArrayList OverBookName;//声明超出借阅期的书的数组
        public static ArrayList OverTimeBook;//声明超出借阅期的书的借阅时间的数组
        public frm_Record()
        {
            InitializeComponent();
        }
        public void BorrowHistory(string ReaderId) //获取读者借阅记录函数
        {
            int i= 0;
            int j = 0;
            data = new DataBase();
            data.SqlConnect();
            DateTime ReturnTime = new DateTime();
            ArrayList list = new ArrayList();
            dataGridView_History.AllowUserToAddRows = false; //禁止添加行
            dataGridView_History.AllowUserToDeleteRows = false;//禁止删除
            list=data.SqlSelect("Borrowed");
            DataSet dataset = new DataSet();
            ConnectObject = new SqlConnection("Data Source=;Initial Catalog=;Integrated Security=True");
            sqlda = new SqlDataAdapter("select * from  Borrowed where Reader_Id=" + "\'" + ReaderId + "\';", ConnectObject);
            sqlda.Fill(dataset);
            dataGridView_History.DataSource=dataset.Tables[0];
            for (i = 0; i < dataGridView_History.Columns.Count; i++)  //禁用控件的排序功能
            {
                dataGridView_History.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView_History.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//设置控件中的数据能整行选择
            dataGridView_History.ReadOnly = true; //使数据只读
            textBox_BorrowTotal.Text = dataGridView_History.RowCount.ToString();//获取总共借书数
            ReturnTime = (DateTime)dataset.Tables[j].Rows[0][5];
            for (i = 0; i < dataGridView_History.Rows.Count; i++) //遍历数据
            {
                if (dataset.Tables[i].Rows[0][6] == "0")     //获取正在借阅状态的书名
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Clear();
                    li.SubItems[0].Text = dataset.Tables[i].Rows[0][1].ToString();
                    listView_BorrowNow.Items.Add(li);
                    BookName.Add(dataset.Tables[i].Rows[0][1]);
                }
                if (ReturnTime > System.DateTime.Now)   //获取超期状态的书名和借阅时间
                {
                    ListViewItem li = new ListViewItem();
                    li.SubItems.Clear();
                    li.SubItems[0].Text = dataset.Tables[i].Rows[0][1].ToString();
                    listView_BorrowOver.Items.Add(li);
                    OverTimeBook.Add(dataset.Tables[i].Rows[0][4]);
                    OverBookName.Add(dataset.Tables[i].Rows[0][1]);
                }
            }
        }
        private void frm_Record_Load(object sender, EventArgs e)//借阅记录登录事件，加载读者借阅记录
        {
            BorrowHistory(frm_Login.Login_Name);
            button_BackReturnBook.Visible = false;//隐藏返回还书界面

        }
        private void dataGridView_History_CellClick(object sender, DataGridViewCellEventArgs e)//选中表内数据时，显示其详细信息
        {
            if (e.RowIndex > 0)
            {
                data.SqlConnect();
                int ReaderId = (int)dataGridView_History.Rows[e.RowIndex].Cells[3].Value;
                sqlda= new SqlDataAdapter("select*from Borrowed where Reader_Id=" + ReaderId + "", ConnectObject);
                DataSet dataset_2= new DataSet();
                sqlda.Fill(dataset_2);
                if (dataset_2.Tables[0].Rows.Count>0)
                {
                    textBox_BookName.Text = dataset_2.Tables[0].Rows[0][1].ToString();//显示书名
                    textBox_BookId.Text = dataset_2.Tables[0].Rows[0][2].ToString();//显示书号
                    textBox_ReaderId.Text = dataset_2.Tables[0].Rows[0][3].ToString();//显示读者编号
                    textBox_BorrowTime.Text = dataset_2.Tables[0].Rows[0][4].ToString();//显示借阅时间
                    textBox_ReturnTime.Text = dataset_2.Tables[0].Rows[0][5].ToString();//显示归还时间
                }
            }
        }
        private void button_BackReturnBook_Click(object sender, EventArgs e)//点击返回还书界面按钮事件
        {
            this.Close();
            frm_ReturnBook returnbook = new frm_ReturnBook();
            returnbook.Show();
        }
    }
}

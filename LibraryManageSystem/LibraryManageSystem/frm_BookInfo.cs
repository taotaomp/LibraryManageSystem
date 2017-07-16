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
using System.IO;

namespace LibraryManageSystem
{
    public partial class frm_BookInfo : Form
    {
        /// <summary>
        /// TheBookId为书的索书号
        /// </summary>
        /// <param name="TheBookId"></param>
        public frm_BookInfo(String TheBookId,String TheUserType,String TheUserID)
        {
            InitializeComponent();
            BookId = TheBookId;
            UserType = TheUserType;
            UserID = TheUserID;
        }

        public frm_BookInfo(String TheUserType,String TheUserID)
        {
            InitializeComponent();
            UserType = TheUserType;
            UserID = TheUserID;
        }

        String BookId=String.Empty;
        String UserType;
        String UserID;
        DataBase DB_BookInfo = new DataBase();

        Button Button_Borrow;
        Button Button_ModifyInfo;
        Button Button_AddBook;
        Button Button_DeleteBook;
        Button Button_Cancel;

        public static Byte[] Byte_For_Image;
        FileStream FileStream_For_Image;

        private void frm_BookInfo_Load(object sender, EventArgs e)
        {
            DB_BookInfo.SqlConnect();       //连接数据库
            panel.AutoScroll = true;        //设置可出现滚动条
            GetBookInfo(BookId);            //获取书的信息并将其添加到信息框中
            ControlsSetting(UserType);      //根据登陆的用户的不同显示不同控件
        }

        private void ControlsSetting(String UserType)
        {
            if (UserType == "no")
            {
                Label Warning = new Label();
                Warning.AutoSize = true;
                Warning.Text = "要想借书请先登陆";
                Warning.Font = new System.Drawing.Font("宋体",20);
                Warning.Location = new Point(panel.Width * 1 / 4, panel.Height * 2 / 3);
                panel.Controls.Add(Warning);
            }
            if (UserType == "Reader")
            {
                //
                //借书按钮
                //
                Button_Borrow = new Button();
                Button_Borrow.Text = "借阅该书";
                Button_Borrow.Font = new System.Drawing.Font("宋体", 20);
                Button_Borrow.Width = 200;
                Button_Borrow.Height = 100;
                Button_Borrow.Location = new Point(panel.Width * 1 / 2, panel.Height * 2 / 3);
                Button_Borrow.Click += new System.EventHandler(this.Button_Borrow_Click);
                panel.Controls.Add(Button_Borrow);
            }
            if (UserType == "user")
            {
                //
                //修改按钮
                //
                Button_ModifyInfo = new Button();
                Button_ModifyInfo.Text = "修改信息";
                Button_ModifyInfo.Font = new System.Drawing.Font("宋体", 20);
                Button_ModifyInfo.Width = 200;
                Button_ModifyInfo.Height = 100;
                Button_ModifyInfo.Location = new Point(panel.Width * 1 / 2, panel.Height * 2 / 3);
                Button_ModifyInfo.Click += new System.EventHandler(this.Button_ModifyInfo_Click);

                panel.Controls.Add(Button_ModifyInfo);
            }
            if (UserType == "")
            {
                //
                //修改按钮
                //
                Button_ModifyInfo = new Button();
                Button_ModifyInfo.Text = "修改信息";
                Button_ModifyInfo.Font = new System.Drawing.Font("宋体", 10);
                Button_ModifyInfo.Width = 100;
                Button_ModifyInfo.Height = 50;
                Button_ModifyInfo.Location = new Point((panel.Width * 1 / 2)-70, panel.Height * 2 / 3);
                Button_ModifyInfo.Click += new System.EventHandler(this.Button_ModifyInfo_Click);
                panel.Controls.Add(Button_ModifyInfo);
                //
                //添加图书按钮
                //
                if (textBox_Book_Remain.Text.Trim() != "0")
                {
                    Button_AddBook = new Button();
                    Button_AddBook.Text = "添加图书";
                    Button_AddBook.Font = new System.Drawing.Font("宋体", 10);
                    Button_AddBook.Width = 100;
                    Button_AddBook.Height = 50;
                    Button_AddBook.Location = new Point((panel.Width * 1 / 2) - 180, panel.Height * 2 / 3);
                    Button_AddBook.Click += new System.EventHandler(this.Button_AddBook_Click);
                    panel.Controls.Add(Button_AddBook);
                }
                //
                //删除书籍按钮
                //
                Button_DeleteBook = new Button();
                Button_DeleteBook.Text = "删除该书";
                Button_DeleteBook.Font = new System.Drawing.Font("宋体", 10);
                Button_DeleteBook.Width = 100;
                Button_DeleteBook.Height = 50;
                Button_DeleteBook.Location = new Point((panel.Width * 1 / 2) + 40, panel.Height * 2 / 3);
                Button_DeleteBook.Click += new System.EventHandler(this.Button_DeleteBook_Click);
                panel.Controls.Add(Button_DeleteBook);
            }
            
        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你真的要借阅该书吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                String Borrowed_Id = (int.Parse(DB_BookInfo.SqlSelect("Borrowed")[DB_BookInfo.SqlSelect("Borrowed").Count - 1].ToString().Split('#')[0])+ 1).ToString();
                String Book_Id = BookId.ToString();
                String Reader_Id = UserID;
                String Borrowed_LendTime = DateTime.Now.ToString();
                String AllowBorrowTime = DB_BookInfo.SqlSelect("Reader_Id", "Reader", UserID, "=")[0].ToString().Split('#')[5];
                String Borrowed_ReturnTime = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString()+(int.Parse(DateTime.Now.Date.ToString())+int.Parse(AllowBorrowTime)).ToString();
                String Borrowed_Status = "0";
                String Book_Name = textBox_Book_Name.Text;

                String content = Borrowed_Id + "#" + Book_Id + "#" + Reader_Id + "#" + Borrowed_LendTime + "#" + Borrowed_ReturnTime + "#" + Borrowed_Status + "#" + Book_Name;
                DB_BookInfo.SqlInsert("Borrowed", content);

                DB_BookInfo.SqlUpdate("Book_Remain", (int.Parse(textBox_Book_Remain.Text) - 1).ToString(), "Book_Id", Book_Id);

                String Reader_Borrow_exchange = DB_BookInfo.SqlSelect("Reader_Id","Reader",Reader_Id,"=")[0].ToString().Split('#')[4] + Book_Name;
                DB_BookInfo.SqlUpdate("Reader_Borrow", Reader_Borrow_exchange, "Reader_Id", "Reader", Reader_Id);
            }
        }

        private void Button_AddBook_Click(object sender, EventArgs e)
        {
            if (Button_AddBook.Text == "添加图书")
            {
                Button_Cancel = new Button();
                Button_Cancel.Text = "取消";
                Button_Cancel.Font = new System.Drawing.Font("宋体", 20);
                Button_Cancel.Width = 100;
                Button_Cancel.Height = 50;
                Button_Cancel.Location = new Point((panel.Width * 1 / 2) + 90, panel.Height * 2 / 3);
                panel.Controls.Add(Button_Cancel);


                Button_AddBook.Text = "完成";

                panel.Controls.Remove(Button_ModifyInfo);
                panel.Controls.Remove(Button_DeleteBook);
                pictureBox_BookPic.Click += new System.EventHandler(this.pictureBox_BookPic_Click);
                AddBook();
            }
            else if (Button_AddBook.Text == "完成")
            {
                Button_AddBook.Text = "添加图书";
                panel.Controls.Remove(Button_Cancel);

                panel.Controls.Add(Button_ModifyInfo);
                panel.Controls.Add(Button_DeleteBook);
                pictureBox_BookPic.Click -= new System.EventHandler(this.pictureBox_BookPic_Click);
                for (int i = 0; i < panelForText.Controls.Count; i++)
                {
                    if(panelForText.Controls[i].Text==string.Empty)
                    {
                        panelForText.Controls[i].Text = "NULL";
                    }
                }

                String content = textBox_BookID.Text + "#" + textBox_Book_Name.Text + "#" + textBox_Bool_Writer.Text + "#" + "@image" +"#"+ textBox_Book_Price.Text + "#" + textBox_Book_ISBN.Text + "#" + DateTime.Now + "#" + textBox_Book_All.Text + "#" + textBox_Book_Remain.Text;
                DB_BookInfo.SqlInsert("Book", content, Byte_For_Image);
                textBox_BookID.ReadOnly = true;
                textBox_Book_Name.ReadOnly = true;
                textBox_Bool_Writer.ReadOnly = true;
                textBox_Book_Price.ReadOnly = true;
                textBox_Book_ISBN.ReadOnly = true;
                textBox_Book_EnterTime.ReadOnly = true;
                textBox_Book_All.ReadOnly = true;
                textBox_Book_Remain.ReadOnly = true;
                this.Close();
            }
        }

        private void Button_ModifyInfo_Click(object sender, EventArgs e)
        {
            if (Button_ModifyInfo.Text=="修改信息")
            {
                Button_Cancel = new Button();
                Button_Cancel.Text = "取消";
                Button_Cancel.Font = new System.Drawing.Font("宋体", 20);
                Button_Cancel.Width = 100;
                Button_Cancel.Height = 50;
                Button_Cancel.Location = new Point((panel.Width * 1 / 2) - 190, panel.Height * 2 / 3);
                panel.Controls.Add(Button_Cancel);

                
                Button_ModifyInfo.Text = "完成";
                
                panel.Controls.Remove(Button_AddBook);
                panel.Controls.Remove(Button_DeleteBook);

                textBox_BookID.ReadOnly=false;
                textBox_Book_Name.ReadOnly=false;
                textBox_Bool_Writer.ReadOnly=false;
                pictureBox_BookPic.Click += new System.EventHandler(pictureBox_BookPic_Click);
                textBox_Book_Price.ReadOnly=false;
                textBox_Book_ISBN.ReadOnly=false;
                textBox_Book_EnterTime.ReadOnly=false;
                textBox_Book_All.ReadOnly=false;
                textBox_Book_Remain.ReadOnly = false; 
            }
            else if(Button_ModifyInfo.Text == "完成")
            {
                panel.Controls.Remove(Button_Cancel);

                Button_ModifyInfo.Text = "修改信息";
                panel.Controls.Add(Button_AddBook);
                panel.Controls.Add(Button_DeleteBook);

                textBox_BookID.ReadOnly = true;
                textBox_Book_Name.ReadOnly = true;
                textBox_Bool_Writer.ReadOnly = true;
                pictureBox_BookPic.Click -= new System.EventHandler(pictureBox_BookPic_Click);
                textBox_Book_Price.ReadOnly = true;
                textBox_Book_ISBN.ReadOnly = true;
                textBox_Book_EnterTime.ReadOnly = true;
                textBox_Book_All.ReadOnly = true;
                textBox_Book_Remain.ReadOnly = true;

                for (int i = 0; i < panelForText.Controls.Count; i++)
                {
                    if (panelForText.Controls[i].Text == string.Empty)
                    {
                        panelForText.Controls[i].Text = "NULL";
                    }
                }

                if (textBox_Book_EnterTime.Text == "NULL")
                {
                    textBox_Book_EnterTime.Text = DateTime.Now.ToString(); ;
                }
               
                String DBInsertTemp = textBox_BookID.Text + "#" + textBox_Book_Name.Text + "#" + textBox_Bool_Writer.Text + "#" + "@image"/*图片流的占位*/ + "#"
                    + textBox_Book_Price.Text + "#" + textBox_Book_ISBN.Text + "#" + textBox_Book_EnterTime.Text + "#" + textBox_Book_All.Text + "#" + textBox_Book_Remain.Text;
                DB_BookInfo.SqlUpdate("Book_Id", "Book", DBInsertTemp, BookId, Byte_For_Image);
            }
            
        }

        private void Button_DeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你真的要删除该书吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DB_BookInfo.SqlDelete("Book_Id", "Book", BookId);
                this.Close();
            }
        }
        private void GetBookInfo(String BookID)
        {
            if (BookID != String.Empty)
            {
                ArrayList BookInfoReciver = new ArrayList();
                BookInfoReciver = DB_BookInfo.SqlSelect("Book_Id", "Book", BookID, "=");
                if (DataBase.ImageData != null)
                {
                    MemoryStream Image_Set_Stream = new MemoryStream(DataBase.ImageData);
                    System.Drawing.Image ImgFile = System.Drawing.Image.FromStream(Image_Set_Stream);
                    pictureBox_BookPic.Image = ImgFile;
                    DataBase.ImageData = null;
                }

                String[] BookInfoTempContainer = BookInfoReciver[0].ToString().Split('#');
                textBox_BookID.Text = BookInfoTempContainer[0];
                textBox_Book_Name.Text = BookInfoTempContainer[1];
                textBox_Bool_Writer.Text = BookInfoTempContainer[2];
                textBox_Book_Price.Text = BookInfoTempContainer[4];
                textBox_Book_ISBN.Text = BookInfoTempContainer[5];
                textBox_Book_EnterTime.Text = BookInfoTempContainer[6];
                textBox_Book_All.Text = BookInfoTempContainer[7];
                textBox_Book_Remain.Text = BookInfoTempContainer[8];
            }
        }

        private void DeleteBook(String BookID)
        {
            DB_BookInfo.SqlDelete("Book_Id", "Book", BookID);
        }
        private void AddBook()
        {
            textBox_BookID.Text = String.Empty;
            textBox_Book_Name.Text = String.Empty;
            textBox_Bool_Writer.Text = String.Empty;
            pictureBox_BookPic.ImageLocation = String.Empty;
            textBox_Book_Price.Text = String.Empty;
            textBox_Book_ISBN.Text = String.Empty;
            textBox_Book_EnterTime.Text = "系统自动生成";
            textBox_Book_All.Text = String.Empty;
            textBox_Book_Remain.Text = String.Empty;

            textBox_BookID.ReadOnly = false;
            textBox_Book_Name.ReadOnly = false;
            textBox_Bool_Writer.ReadOnly = false;
            textBox_Book_Price.ReadOnly = false;
            textBox_Book_ISBN.ReadOnly = false;
            textBox_Book_EnterTime.ReadOnly = true;
            textBox_Book_All.ReadOnly = false;
            textBox_Book_Remain.ReadOnly = false;
        }

        private void pictureBox_BookPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog SelectPic = new OpenFileDialog();        //文件打开窗口
            SelectPic.Filter = "Image Files((*.JPG)|*.JPG|(*.PNG)|*.PNG|(*.BMP)|*.BMP)";    //设置筛选，使打开的文件只能是图片
            SelectPic.ShowDialog();
            pictureBox_BookPic.ImageLocation = SelectPic.FileName;      //使图片框中图片的地址为文件打开窗口选择的文件的地址

            FileStream_For_Image = new FileStream(pictureBox_BookPic.ImageLocation, FileMode.Open, FileAccess.Read);    //初始化文件流对象，为后续的图片流读取做准备
            Byte_For_Image = new Byte[FileStream_For_Image.Length];                                                     //初始化文件流的字节串容器
            FileStream_For_Image.Read(Byte_For_Image,0,Convert.ToInt32(FileStream_For_Image.Length));                   //通过文件流对象的读取方法，将图片文件从磁盘读取到流的容器中
            FileStream_For_Image.Close();                                                                               //关闭文件流
        }   

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
         
        }
    }
}

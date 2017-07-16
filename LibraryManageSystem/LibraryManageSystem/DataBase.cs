using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManageSystem
{
    /// <summary>
    /// 老哥，等等
    /// 先看看这个！！！！！！！！！！！
    /// 使用database类中的函数时，要先调用SqlConnect()函数连接数据库
    /// 一定要先连接啊
    /// </summary>
    class DataBase
    {
        SqlConnection ConnectObject;                                                     //创建数据库连接对象
        public static Byte[] ImageData;

        //~DataBase()
        //{
        //    if (ConnectObject.State == ConnectionState.Open)
        //    ConnectObject.Close();
        //}
        /// <summary>
        /// 数据库连接函数，返回值为bool值
        /// </summary>
        /// <returns></returns>
        public bool SqlConnect()                                                         //数据库连接函数
        {
            try
            {
                ConnectObject = new SqlConnection("Data Source=依;Initial Catalog=LibraryManageSystem;Integrated Security=True");                                    //实例化数据库连接对象
                ConnectObject.Open();                                                   //通过对象打开数据库
                if(ConnectObject.State==ConnectionState.Open)                           //检查是否打开
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        /// <summary>
        ///数据库连接检查函数
        /// </summary>
        /// <returns></returns>
        public bool SqlConnectCheck()
        {
            if (ConnectObject.State == ConnectionState.Open)                           
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 数据库查询语句 
        /// select * from TableName where located   locatedOperation   locatedValue;
        /// locatedOperation可以为“=”、“&lt;”、“&gt;”、“[NOT] LIKE”
        /// 返回值中的每一行数据在不同属性之间以#号为分割符
        /// 查询得到的结果的属性排列顺序与数据库设计的顺序一致
        /// </summary>
        /// <param name="located"></param>
        /// <param name="TableName"></param>
        /// <param name="locatedValue"></param>
        /// <returns></returns>
        public ArrayList SqlSelect(String located, String TableName, String locatedValue,String locatedOperation)    //查找信息函数：located为定位，TableName
        {                                                                               //为表名，Content为查找的内容,locatedValue为定位值,locatedOperation为定位操作
            ArrayList ContentForReturn = new ArrayList();                               //创建并初始化一个ArrayList类的对象，用于存放返回的结果

            try
            {
                SqlCommand Commander = new SqlCommand("select * from " + TableName + " where " + located +" "+ locatedOperation + " \'" + locatedValue + "\';", ConnectObject);   //sql命令语句实现对象
                SqlDataReader DataReader = Commander.ExecuteReader();                   //使用SqlDataReader类对象以执行SqlCommand类对象的读取语句
                if (DataReader.HasRows)                                 //HasRows 指示DataReader中是否有数据
                {
                    while (DataReader.Read())                           //Read()：读取一条数据的方法
                    {
                        if (TableName == "Book")
                        {
                            if (!DataReader["Book_Image"].Equals(DBNull.Value))
                            { 
                                ImageData = (Byte[])DataReader["Book_Image"];
                            }
                        }

                        String TempGetResult = string.Empty;            //TempGetResult用以整合读取数据库而得到的一条结果
                        for (int i = 0; i < DataReader.FieldCount; i++) //FidldCount为读取到的该元组的属性个数
                        {
                            TempGetResult += DataReader[i] + "#";
                        }
                        ContentForReturn.Add(TempGetResult);            //将整合好的数据添加到，用于存放返回的结果的，ArrayList类的对象中
                    }
                }
                DataReader.Close();
                return ContentForReturn;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return ContentForReturn;
            }
        }

        /// <summary>
        /// 数据库查询语句 (全部查询)
        /// select * from TableName 
        /// 返回值中的每一行数据在不同属性之间以#号为分割符
        /// 查询得到的结果的属性排列顺序与数据库设计的顺序一致
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public ArrayList SqlSelect(String TableName)    //查找信息函数：located为定位，TableName
        {                                                                               //为表名，Content为查找的内容
            ArrayList ContentForReturn = new ArrayList();                               //创建并初始化一个ArrayList类的对象，用于存放返回的结果

            try
            {
                SqlCommand Commander = new SqlCommand("select * from " + TableName + ";", ConnectObject);   //sql命令语句实现对象
                SqlDataReader DataReader = Commander.ExecuteReader();                   //使用SqlDataReader类对象以执行SqlCommand类对象的读取语句
                if (DataReader.HasRows)                                 //HasRows 指示DataReader中是否有数据
                {
                    while (DataReader.Read())                           //Read()：读取一条数据的方法
                    {
                        String TempGetResult = string.Empty;            //TempGetResult用以整合读取数据库而得到的一条结果
                        for (int i = 0; i < DataReader.FieldCount; i++) //FidldCount为读取到的该元组的属性个数
                        {
                            TempGetResult += DataReader[i] + "#";
                        }
                        ContentForReturn.Add(TempGetResult);            //将整合好的数据添加到，用于存放返回的结果的，ArrayList类的对象中
                    }
                }
                DataReader.Close();
                return ContentForReturn;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return ContentForReturn;
            }
        }

        /// <summary>
        /// 数据插入语句，TableName为表名，Content中的最后一位不能是#号
        /// Content中数据请务必与数据库中数据顺序一致
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Content"></param>
        public void SqlInsert(String TableName, String Content)                         //插入信息函数：TableName为表名，Content为内容
        {
            try
            {
                String[] TempSplitValue = Content.Split('#');                       //分割传入的待插入参数，以待整合
                String TempSetValue = String.Empty;                                 //整合的字符串的容器
                for (int i = 0; i < TempSplitValue.Length; i++)                     //将字符串整合为sql语句
                {
                    TempSetValue += "\'" + TempSplitValue[i] + "\'" + ",";
                }
                TempSetValue = TempSetValue.Substring(0, TempSetValue.Length - 1);  //去掉语句中最后一个逗号
                SqlCommand Commander = new SqlCommand("insert into "+TableName+" values("+TempSetValue+");", ConnectObject);
                SqlParameter parmerter = new SqlParameter("a",SqlDbType.Image);
                Commander.Parameters.Add(parmerter);
                Commander.ExecuteNonQuery();                                        //执行语句
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// 数据库插入for 带image
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Content"></param>
        /// <param name="image_Stream"></param>
        public void SqlInsert(String TableName, String Content,Byte[] image_Stream = null)                         //插入信息函数：TableName为表名，Content为内容
        {
            try
            {
                String[] TempSplitValue = Content.Split('#');                       //分割传入的待插入参数，以待整合
                String TempSetValue = String.Empty;                                 //整合的字符串的容器
                for (int i = 0; i < TempSplitValue.Length; i++)                     //将字符串整合为sql语句
                {
                    if (TableName == "Book" && i == 3)
                    {
                        TempSetValue += TempSplitValue[i] + ",";
                        continue;
                    }
                    TempSetValue += "\'" + TempSplitValue[i] + "\'" + ",";
                }
                TempSetValue = TempSetValue.Substring(0, TempSetValue.Length - 1);  //去掉语句中最后一个逗号
                SqlCommand Commander = new SqlCommand("insert into " + TableName + " values(" + TempSetValue + ");", ConnectObject);
                SqlParameter parmerter = new SqlParameter("@image", SqlDbType.Image);
                parmerter.Value = image_Stream;
                Commander.Parameters.Add(parmerter);
                Commander.ExecuteNonQuery();                                        //执行语句
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //public void SqlInsertForBook(String TableName, String Content, Byte[] image_Stream)                         //插入信息函数：TableName为表名，Content为内容
        //{
        //    try
        //    {
        //        String[] TempSplitValue = Content.Split('#');                       //分割传入的待插入参数，以待整合
        //        String TempSetValue = String.Empty;                                 //整合的字符串的容器
        //        for (int i = 0; i < TempSplitValue.Length; i++)                     //将字符串整合为sql语句
        //        {
        //            TempSetValue += "\'" + TempSplitValue[i] + "\'" + ",";
        //        }
        //        TempSetValue = TempSetValue.Substring(0, TempSetValue.Length - 1);  //去掉语句中最后一个逗号
        //        SqlCommand Commander = new SqlCommand("insert into " + TableName + " values("");", ConnectObject);
        //        SqlParameter parmerter = new SqlParameter("@image", SqlDbType.Image);
        //        parmerter.Value = image_Stream;
        //        Commander.Parameters.Add(parmerter);
        //        Commander.ExecuteNonQuery();                                        //执行语句
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.ToString());
        //    }
        //}
        /// <summary>
        /// 数据库更新语句，TableName为表名，Content中的最后一位不能是#号，image不用时可不写
        /// ...where located = locatedValue
        /// Content中数据请务必与数据库中数据顺序一致
        /// </summary>
        /// <param name="located"></param>
        /// <param name="TableName"></param>
        /// <param name="Content"></param>
        /// <param name="locatedValue"></param>
        public void SqlUpdate(String located, String TableName, String Content, String locatedValue, Byte[] image_Stream = null)         //更新信息函数：located为定位，TableName为表名，Content为内容,image不用时可不写
        {
            try
            {
                SqlCommand Commander;
                switch (TableName)
                {
                    case "Book":
                        {
                            String[] TempSplitValue = Content.Split('#'); 
                            Commander = new SqlCommand("update "+TableName+" set Book_Id=\'"+TempSplitValue[0]+"\',Book_Name=\'"+TempSplitValue[1]+"\',Book_Writer=\'"
                                +TempSplitValue[2]+"\',Book_Image="+TempSplitValue[3]+",Book_Price=\'"+TempSplitValue[4]+"\',Book_ISBN=\'"+TempSplitValue[5]+"\',Book_EnterTime=\'"
                                + TempSplitValue[6] + "\',Book_All=\'" + TempSplitValue[7] + "\',Book_Remain=\'" + TempSplitValue[8] + "\' where " + located + "=\'" + locatedValue + "\';", ConnectObject);
                            SqlParameter parmerter = new SqlParameter("@image", SqlDbType.Image);
                            parmerter.Value = image_Stream;
                            Commander.Parameters.Add(parmerter);
                            Commander.ExecuteNonQuery();
                            break;
                        }
                    case "Reader": 
                        {
                            String[] TempSplitValue = Content.Split('#');
                            Commander = new SqlCommand("update " + TableName + " set Reader_Id=\'" + TempSplitValue[0] + "\',Reader_Name=\'" + TempSplitValue[1] + "\',Reader_Type=\'"
                                + TempSplitValue[2] + "\',Reader_Sex=\'" + TempSplitValue[3] + "\',Reader_Borrow=\'" + TempSplitValue[4] + "\',Reader_OverTime=\'" + TempSplitValue[5] + "\',Reader_Password=\'"
                                + TempSplitValue[6] + "\' where " + located + "=\'" + locatedValue + "\';", ConnectObject);
                            Commander.ExecuteNonQuery();
                            break; 
                        }
                    case "Manage": 
                        {
                            String[] TempSplitValue = Content.Split('#');
                            Commander = new SqlCommand("update " + TableName + " set Manage_Id=\'" + TempSplitValue[0] + "\',Manage_Name=\'" + TempSplitValue[1] + "\',Manage_Password=\'"
                                + TempSplitValue[2] + "\',Manage_Type=\'" + TempSplitValue[3] + "\',Manage_Image=\'" + TempSplitValue[4] + "\' where " + located + "=\'" + locatedValue + "\';", ConnectObject);
                            Commander.ExecuteNonQuery();
                            break; 
                        }
                    case "Borrowed": 
                        {
                            String[] TempSplitValue = Content.Split('#');
                            Commander = new SqlCommand("update " + TableName + " set Borrowed_Id=\'" + TempSplitValue[0] + "\',Book_Id=\'" + TempSplitValue[1] + "\',Reader_Id=\'"
                                + TempSplitValue[2] + "\',Borrowed_LendTime=\'" + TempSplitValue[3] + "\',Borrowed_ReturnTime=\'" + TempSplitValue[4] + "\',Borrowed_Status=\'" + TempSplitValue[5]
                                + "\',Book_Name=\'" + TempSplitValue[6] + "\' where " + located + "=\'" + locatedValue + "\';", ConnectObject);
                            Commander.ExecuteNonQuery();
                            break;
                        }
                    case "ReaderType": 
                        {
                            String[] TempSplitValue = Content.Split('#');
                            Commander = new SqlCommand("update " + TableName + " set ReaderType_Type=\'" + TempSplitValue[0] + "\',ReaderType_LeadNumber=\'" + TempSplitValue[1] + "\',ReaderType_LeadDays=\'"
                                + TempSplitValue[2] + "\' where " + located + "=\'" + locatedValue + "\';", ConnectObject);
                            Commander.ExecuteNonQuery();
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// 数据库更新语句
        /// update TableName set Uplocated = Content  where  located = locatedValue
        /// </summary>
        /// <param name="Uplocated"></param>
        /// <param name="Content"></param>
        /// <param name="located"></param>
        /// <param name="TableName"></param>
        /// <param name="locatedValue"></param>
        public void SqlUpdate(string Uplocated, String Content, String located, String TableName, String locatedValue)
        {
            try
            {
                SqlCommand Commander = new SqlCommand("update " + TableName + " set " + Uplocated + "=\'" + Content + "\' where " + located + "=\'" + locatedValue + "\';",ConnectObject);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        /// 数据删除语句 
        /// delete from TableName where located = locatedValue;
        /// </summary>
        /// <param name="located"></param>
        /// <param name="TableName"></param>
        /// <param name="locatedValue"></param>
        public void SqlDelete(String located, String TableName, String locatedValue)                         //删除信息函数：located为定位，TableName为表名
        {
            try
            {
                SqlCommand Commander = new SqlCommand("delete from " + TableName + " where " + located + "=\'" + locatedValue + "\';", ConnectObject);
                Commander.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}

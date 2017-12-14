/*
* author:;
* time:2016/7/13 22:19:59;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;//导入数据库需要的命名空间

namespace 航班预定查询
{
    class DBHelper
    {
        //数据库连接字符串
        private string connStr = @"Server=******;database=******;uid=******;pwd=******";
        //private string connStr = @"Server=DESKTOP-00EOEPS;database=MyTicket;uid=sa;pwd=";
        //windows账号登陆 连接语句是 Initial Catalog=；Data Source=；Integrated Security=true；
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get 
            { 
                if(connection==null)
                {
                    connection = new SqlConnection(connStr);
                }
                return connection;
            }
            set { connection = value; }
        }
        /// <summary>
        /// 打开数据库
        /// </summary>
       public void OpenConnention()
        {
           if(connection.State==ConnectionState.Closed)
           {
               connection.Open();
           }
           else if (connection.State == ConnectionState.Broken)
           {
               connection.Close();
               connection.Open();
           }
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void CloseConnection()
       {
           if (connection == null)
           {
               connection = new SqlConnection(connStr);
           }
           if (connection.State == ConnectionState.Broken || connection.State == ConnectionState.Open)
               connection.Close();
       }
    }
}

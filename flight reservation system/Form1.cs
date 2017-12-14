using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 航班预定查询
{
    public partial class Form1 : Form
    {
        #region 构造函数

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region 绑定cbo
        /// <summary>
        /// 绑定cbo
        /// </summary>
        private void BindCbo()
        {
            DBHelper dbhelper = new DBHelper();
            //sql语句
            string sql = "select * from cityinfo";
            string sql1 = "select flightNo,times from flightinfo";
            //适配器adapter
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbhelper.Connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(sql1, dbhelper.Connection);
            //数据集
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            //填充数据集
            adapter.Fill(ds, "cityinfo");
            adapter1.Fill(ds1, "flightinfo");
            //新的一行
            DataRow row = ds.Tables["cityinfo"].NewRow();
            DataRow ro = ds1.Tables["flightinfo"].NewRow();
            row[0] = -1;
            row[1] = "请选择";
            //ro[0] = -1;
            //ro[1] = "请选择";
            //插入
            ds.Tables["cityinfo"].Rows.InsertAt(row, 0);
            ds1.Tables["flightinfo"].Rows.InsertAt(ro,0);
            //获取视图
            DataView dv1 = new DataView(ds.Tables["cityinfo"]);
            DataView dv2 = new DataView(ds.Tables["cityinfo"]);
            DataView dv3 = new DataView(ds1.Tables["flightinfo"]);
            //绑定
            this.cboLeaveCity.DataSource = dv1;
            this.cboLeaveCity.DisplayMember = "cityname";//需要显示的是cityname而不是id
            this.cboLeaveCity.ValueMember = "id";//将id隐藏

            this.cboDestination.DataSource = dv2;
            this.cboDestination.DisplayMember = "cityname";
            this.cboDestination.ValueMember = "id";

            this.cbo_times.DataSource = dv3;
            this.cbo_times.DisplayMember = "times";
            this.cbo_times.ValueMember = "flightNo";

        }
        #endregion

        #region 绑定datagridview
        private void BindDgv()
        {
            string sql = string.Format(@"select flightNo,airways,leaveTime,landTime,price
                         from flightinfo,airwaysinfo
                         where flightinfo.airwaysId=airwaysinfo.id
                         and leaveCity={0}
                         and destination={1}", cboLeaveCity.SelectedValue, cboDestination.SelectedValue);
            DBHelper dbhelper = new DBHelper();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, dbhelper.Connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "flightinfo");
            this.dgvTicketInfo.DataSource = ds.Tables["flightinfo"];
        }



        #endregion

        #region 验证预定部分的用户输入
        private bool ValidateInput()
        {
            if (tb_FlightNo.Text == string.Empty)
            {
                MessageBox.Show("请选择一个航班");
                return false;
            }
            if (dt_LeaveTime.Value < DateTime.Now)
            {
                MessageBox.Show("请选择正确出发日期");
                dt_LeaveTime.Focus();//获得焦点
                return false;
            }
            return true;
        }
        #endregion

        #region 事件
        private void Form1_Load(object sender, EventArgs e)
        {

            BindCbo();

        }
        //查询事件
        private void bt_seacher_Click(object sender, EventArgs e)
        {
            if (cboLeaveCity.Text == "请选择" || cboDestination.Text == "请选择")
            {
                MessageBox.Show("请选择出发地和目的地");
                this.dgvTicketInfo.DataSource = null;
                return;
            }
            BindDgv();
            if(cbo_times.Text!="")
            {
                BindDgv();
            }
            
            //每次单击查询都将下面的订单信息清空
            foreach (Control c in gb_orderinfo.Controls)//control代表控件
            {
                if (c is TextBox)
                    c.Text = string.Empty;//如果控件是textbox每次再次单击就将内容清空
            }
        }//单击dgv
        private void dgvTivketInfo_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTicketInfo.Rows.Count > 0)
            {
                this.tb_FlightNo.Text = dgvTicketInfo.CurrentRow.Cells["flightNo"].Value.ToString();
                this.tb_Airways.Text = dgvTicketInfo.CurrentRow.Cells["airways"].Value.ToString();
                this.tb_LeaveCity.Text = cboLeaveCity.Text;
                this.tb_Destionation.Text = cboDestination.Text;
                this.tb_leaveTime.Text = dgvTicketInfo.CurrentRow.Cells["leaveTime"].Value.ToString();
                this.tb_landTime.Text = dgvTicketInfo.CurrentRow.Cells["landTime"].Value.ToString();
                this.tb_Price.Text = dgvTicketInfo.CurrentRow.Cells["price"].Value.ToString();
            }
        }
        //单击关闭按钮
        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        //单击预定按钮预定之前先进行预定部分是否为空
        private void bt_yuding_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Random random = new Random();
                int orderId = random.Next(100000, 9999999);//随机产生定单号
                string flightNo = this.tb_FlightNo.Text;
                string leaveTime = this.dt_LeaveTime.Value.ToShortDateString();
                string landTime = this.tb_landTime.Text;
                int num = (int)this.nu_tickets.Value;
                int price = num *int.Parse(tb_Price.Text);
                Console.WriteLine(int.Parse("360"));
                string sql = string.Format(@"insert into orderinfo(orderId,flightNo,leaveTime,landTime,price,Number)
values({0},'{1}','{2}','{3}',{4},{5})", orderId, flightNo, leaveTime, landTime,price,num);
                Console.WriteLine(sql);
                DBHelper dbhelper = new DBHelper();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql,dbhelper.Connection);
                    Console.Write("1");
                    dbhelper.OpenConnention();
                    Console.Write("2");
                    int result = cmd.ExecuteNonQuery();//执行增删改操作,返回受影响的行数
                    Console.Write("3");
                    if(result>0)
                    {
                        MessageBox.Show("预定成功，订单编号为:"+orderId);
                    }
                    else
                    {
                        MessageBox.Show("预定失败请重试!");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("发生错误请联系管理员,错误原因"+ex.Message);
                }
                finally
                {
                    dbhelper.CloseConnection();
                }
            }
        }
        #endregion
       


    }
}

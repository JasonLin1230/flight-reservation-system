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
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_flinghtinfo = new System.Windows.Forms.GroupBox();
            this.cbo_times = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTicketInfo = new System.Windows.Forms.DataGridView();
            this.flightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airways = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_seacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.出发地 = new System.Windows.Forms.Label();
            this.cboLeaveCity = new System.Windows.Forms.ComboBox();
            this.gb_orderinfo = new System.Windows.Forms.GroupBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_yuding = new System.Windows.Forms.Button();
            this.dt_LeaveTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.nu_tickets = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_landTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_leaveTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Destionation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LeaveCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Airways = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FlightNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_flinghtinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketInfo)).BeginInit();
            this.gb_orderinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_flinghtinfo
            // 
            this.gb_flinghtinfo.Controls.Add(this.cbo_times);
            this.gb_flinghtinfo.Controls.Add(this.label8);
            this.gb_flinghtinfo.Controls.Add(this.dgvTicketInfo);
            this.gb_flinghtinfo.Controls.Add(this.bt_seacher);
            this.gb_flinghtinfo.Controls.Add(this.label1);
            this.gb_flinghtinfo.Controls.Add(this.cboDestination);
            this.gb_flinghtinfo.Controls.Add(this.出发地);
            this.gb_flinghtinfo.Controls.Add(this.cboLeaveCity);
            this.gb_flinghtinfo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_flinghtinfo.Location = new System.Drawing.Point(46, 22);
            this.gb_flinghtinfo.Name = "gb_flinghtinfo";
            this.gb_flinghtinfo.Size = new System.Drawing.Size(804, 313);
            this.gb_flinghtinfo.TabIndex = 0;
            this.gb_flinghtinfo.TabStop = false;
            this.gb_flinghtinfo.Text = "航班信息";
            this.gb_flinghtinfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo_times
            // 
            this.cbo_times.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_times.FormattingEnabled = true;
            this.cbo_times.Location = new System.Drawing.Point(496, 38);
            this.cbo_times.Name = "cbo_times";
            this.cbo_times.Size = new System.Drawing.Size(121, 32);
            this.cbo_times.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(391, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "出发时间：";
            // 
            // dgvTicketInfo
            // 
            this.dgvTicketInfo.AllowUserToAddRows = false;
            this.dgvTicketInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicketInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNo,
            this.airways,
            this.leavetime,
            this.landtime,
            this.price});
            this.dgvTicketInfo.Location = new System.Drawing.Point(31, 85);
            this.dgvTicketInfo.MultiSelect = false;
            this.dgvTicketInfo.Name = "dgvTicketInfo";
            this.dgvTicketInfo.RowTemplate.Height = 23;
            this.dgvTicketInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicketInfo.Size = new System.Drawing.Size(766, 220);
            this.dgvTicketInfo.TabIndex = 5;
            this.dgvTicketInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTivketInfo_Click);
            // 
            // flightNo
            // 
            this.flightNo.DataPropertyName = "flightNo";
            this.flightNo.HeaderText = "航班号";
            this.flightNo.Name = "flightNo";
            this.flightNo.ReadOnly = true;
            // 
            // airways
            // 
            this.airways.DataPropertyName = "airways";
            this.airways.HeaderText = "航空公司";
            this.airways.Name = "airways";
            this.airways.ReadOnly = true;
            // 
            // leavetime
            // 
            this.leavetime.DataPropertyName = "leaveTime";
            this.leavetime.HeaderText = "出发时间";
            this.leavetime.Name = "leavetime";
            this.leavetime.ReadOnly = true;
            // 
            // landtime
            // 
            this.landtime.DataPropertyName = "landTime";
            this.landtime.HeaderText = "到达时间";
            this.landtime.Name = "landtime";
            this.landtime.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "成人票价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // bt_seacher
            // 
            this.bt_seacher.Location = new System.Drawing.Point(657, 37);
            this.bt_seacher.Name = "bt_seacher";
            this.bt_seacher.Size = new System.Drawing.Size(93, 32);
            this.bt_seacher.TabIndex = 4;
            this.bt_seacher.Text = "查询";
            this.bt_seacher.UseVisualStyleBackColor = true;
            this.bt_seacher.Click += new System.EventHandler(this.bt_seacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(208, 45);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "目的地:";
            // 
            // cboDestination
            // 
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(293, 38);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(86, 32);
            this.cboDestination.TabIndex = 2;
            // 
            // 出发地
            // 
            this.出发地.AutoSize = true;
            this.出发地.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.出发地.Location = new System.Drawing.Point(15, 44);
            this.出发地.Name = "出发地";
            this.出发地.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.出发地.Size = new System.Drawing.Size(79, 20);
            this.出发地.TabIndex = 1;
            this.出发地.Text = "出发地:";
            this.出发地.Click += new System.EventHandler(this.出发地_Click);
            // 
            // cboLeaveCity
            // 
            this.cboLeaveCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLeaveCity.FormattingEnabled = true;
            this.cboLeaveCity.Location = new System.Drawing.Point(100, 37);
            this.cboLeaveCity.Name = "cboLeaveCity";
            this.cboLeaveCity.Size = new System.Drawing.Size(89, 32);
            this.cboLeaveCity.TabIndex = 0;
            this.cboLeaveCity.SelectedIndexChanged += new System.EventHandler(this.comboleave_SelectedIndexChanged);
            // 
            // gb_orderinfo
            // 
            this.gb_orderinfo.Controls.Add(this.bt_close);
            this.gb_orderinfo.Controls.Add(this.bt_yuding);
            this.gb_orderinfo.Controls.Add(this.dt_LeaveTime);
            this.gb_orderinfo.Controls.Add(this.label12);
            this.gb_orderinfo.Controls.Add(this.nu_tickets);
            this.gb_orderinfo.Controls.Add(this.label11);
            this.gb_orderinfo.Controls.Add(this.tb_Price);
            this.gb_orderinfo.Controls.Add(this.label9);
            this.gb_orderinfo.Controls.Add(this.tb_landTime);
            this.gb_orderinfo.Controls.Add(this.label6);
            this.gb_orderinfo.Controls.Add(this.tb_leaveTime);
            this.gb_orderinfo.Controls.Add(this.label7);
            this.gb_orderinfo.Controls.Add(this.tb_Destionation);
            this.gb_orderinfo.Controls.Add(this.label4);
            this.gb_orderinfo.Controls.Add(this.tb_LeaveCity);
            this.gb_orderinfo.Controls.Add(this.label5);
            this.gb_orderinfo.Controls.Add(this.tb_Airways);
            this.gb_orderinfo.Controls.Add(this.label3);
            this.gb_orderinfo.Controls.Add(this.tb_FlightNo);
            this.gb_orderinfo.Controls.Add(this.label2);
            this.gb_orderinfo.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb_orderinfo.Location = new System.Drawing.Point(46, 341);
            this.gb_orderinfo.Name = "gb_orderinfo";
            this.gb_orderinfo.Size = new System.Drawing.Size(842, 346);
            this.gb_orderinfo.TabIndex = 1;
            this.gb_orderinfo.TabStop = false;
            this.gb_orderinfo.Text = " ";
            this.gb_orderinfo.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(645, 308);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(93, 32);
            this.bt_close.TabIndex = 23;
            this.bt_close.Text = "关闭";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_yuding
            // 
            this.bt_yuding.Location = new System.Drawing.Point(524, 308);
            this.bt_yuding.Name = "bt_yuding";
            this.bt_yuding.Size = new System.Drawing.Size(93, 32);
            this.bt_yuding.TabIndex = 22;
            this.bt_yuding.Text = "预定";
            this.bt_yuding.UseVisualStyleBackColor = true;
            this.bt_yuding.Click += new System.EventHandler(this.bt_yuding_Click);
            // 
            // dt_LeaveTime
            // 
            this.dt_LeaveTime.Location = new System.Drawing.Point(565, 210);
            this.dt_LeaveTime.Name = "dt_LeaveTime";
            this.dt_LeaveTime.Size = new System.Drawing.Size(173, 35);
            this.dt_LeaveTime.TabIndex = 21;
            this.dt_LeaveTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(453, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "出发时间：";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // nu_tickets
            // 
            this.nu_tickets.Location = new System.Drawing.Point(136, 253);
            this.nu_tickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_tickets.Name = "nu_tickets";
            this.nu_tickets.Size = new System.Drawing.Size(71, 35);
            this.nu_tickets.TabIndex = 19;
            this.nu_tickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nu_tickets.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(41, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "预定数量：";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(136, 188);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(164, 35);
            this.tb_Price.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(41, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "成人票价：";
            // 
            // tb_landTime
            // 
            this.tb_landTime.Location = new System.Drawing.Point(565, 138);
            this.tb_landTime.Name = "tb_landTime";
            this.tb_landTime.Size = new System.Drawing.Size(164, 35);
            this.tb_landTime.TabIndex = 11;
            this.tb_landTime.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(465, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "到达时间：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tb_leaveTime
            // 
            this.tb_leaveTime.Location = new System.Drawing.Point(136, 138);
            this.tb_leaveTime.Name = "tb_leaveTime";
            this.tb_leaveTime.Size = new System.Drawing.Size(164, 35);
            this.tb_leaveTime.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(41, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "出发时间：";
            // 
            // tb_Destionation
            // 
            this.tb_Destionation.Location = new System.Drawing.Point(565, 84);
            this.tb_Destionation.Name = "tb_Destionation";
            this.tb_Destionation.Size = new System.Drawing.Size(164, 35);
            this.tb_Destionation.TabIndex = 7;
            this.tb_Destionation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(465, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "目的地：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_LeaveCity
            // 
            this.tb_LeaveCity.Location = new System.Drawing.Point(136, 84);
            this.tb_LeaveCity.Name = "tb_LeaveCity";
            this.tb_LeaveCity.Size = new System.Drawing.Size(164, 35);
            this.tb_LeaveCity.TabIndex = 5;
            this.tb_LeaveCity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(61, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "出发地：";
            // 
            // tb_Airways
            // 
            this.tb_Airways.Location = new System.Drawing.Point(565, 33);
            this.tb_Airways.Name = "tb_Airways";
            this.tb_Airways.Size = new System.Drawing.Size(164, 35);
            this.tb_Airways.TabIndex = 3;
            this.tb_Airways.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(465, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "航空公司：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_FlightNo
            // 
            this.tb_FlightNo.Location = new System.Drawing.Point(136, 38);
            this.tb_FlightNo.Name = "tb_FlightNo";
            this.tb_FlightNo.Size = new System.Drawing.Size(164, 35);
            this.tb_FlightNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(61, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "航班号：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 685);
            this.Controls.Add(this.gb_orderinfo);
            this.Controls.Add(this.gb_flinghtinfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_flinghtinfo.ResumeLayout(false);
            this.gb_flinghtinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketInfo)).EndInit();
            this.gb_orderinfo.ResumeLayout(false);
            this.gb_orderinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nu_tickets)).EndInit();
            this.ResumeLayout(false);

        }

        //private void Form1_Load(object sender, System.EventArgs e)
        //{
        //    //throw new System.NotImplementedException();
        //}

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label12_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label11_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label6_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox5_TextChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox4_TextChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void 出发地_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void comboleave_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gb_flinghtinfo;
        private System.Windows.Forms.Label 出发地;
        private System.Windows.Forms.ComboBox cboLeaveCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.DataGridView dgvTicketInfo;
        private System.Windows.Forms.Button bt_seacher;
        private System.Windows.Forms.GroupBox gb_orderinfo;
        private System.Windows.Forms.TextBox tb_Airways;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FlightNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_landTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_leaveTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Destionation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LeaveCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nu_tickets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_yuding;
        private System.Windows.Forms.DateTimePicker dt_LeaveTime;
        private System.Windows.Forms.Label label12;
        private DataGridViewTextBoxColumn flightNo;
        private DataGridViewTextBoxColumn airways;
        private DataGridViewTextBoxColumn leavetime;
        private DataGridViewTextBoxColumn landtime;
        private DataGridViewTextBoxColumn price;
        private Label label8;
        private ComboBox cbo_times;
    }
}


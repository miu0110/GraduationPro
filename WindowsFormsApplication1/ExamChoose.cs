﻿using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ExamChoose : CCSkinMain
    {
        //设置窗体显示字体格式
        Font font = new Font("微软雅黑", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
        public string exam_p_id = null;//保存选择的课程id信息
        public string exam_p_name = null;//保存选择的课程名信息
        public ExamChoose()
        {
            InitializeComponent();
        }
        private void ExamChoose_Load(object sender, EventArgs e)
        {
            exam_p_id = null;
            HideControls();
            string select_sql = "select exam_p_name,(select u_name from [User] where u_id = created) AS created_name,created_time,start_time,end_time,exam_p_id from exam_paper";
            showExamInfo(select_sql);
        }
        //查询按钮事件处理
        private void ec_btn_find_Click(object sender, EventArgs e)
        {
            string keyword = this.ec_tBx_findkeywords.Text;
            if (keyword == null)
            {
                ExamChoose_Load(sender, e);                
            }
            else
            {
                string select_sql = "select exam_p_name,(select u_name from [User] where u_id = created) AS created_name,created_time,start_time,end_time,exam_p_id from exam_paper where exam_p_name = '%" + keyword + "%' or created in (select u_id from [User] where u_name = '%" + keyword + "%')";
                showExamInfo(select_sql);
            }
            
        }
        private void showExamInfo(string sql)
        {
            //每次显示数据时先清空控件中原来的数据
            this.ec_fLP_Exam_Info.Controls.Clear();
            DataBaseConnection dc = new DataBaseConnection();
            DataSet ds = dc.ExecuteQuery(sql);
            //在窗口添加课程信息
            if (ds.Tables["user"].Rows.Count > 0)
            {
                //考试标题标签
                var lbl_rb = new Label { Text = "考试标题" };
                lbl_rb.Font = font;
                lbl_rb.Width = 100;
                lbl_rb.TextAlign = ContentAlignment.MiddleCenter;
                //创建人标签
                var lbl_Loadman = new Label { Text = "创建人" };
                lbl_Loadman.Font = font;
                lbl_Loadman.Width = 50;
                lbl_Loadman.TextAlign = ContentAlignment.MiddleCenter;
                //创建时间标签
                var lbl_introducation = new Label { Text = "创建时间" };
                lbl_introducation.Font = font;
                lbl_introducation.Width = 90;
                lbl_introducation.TextAlign = ContentAlignment.MiddleCenter;
                //开始时间标签
                var lbl_credit = new Label { Text = "开始时间" };
                lbl_credit.Font = font;
                lbl_credit.Width = 90;
                lbl_credit.TextAlign = ContentAlignment.MiddleCenter;
                //结束时间标签
                var lbl_recommendTime = new Label { Text = "结束时间" };
                lbl_recommendTime.Font = font;
                lbl_recommendTime.Width = 90;
                lbl_recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                //编辑课程信息标签
                var lbl_btnedit = new Label { Text = "" };
                lbl_btnedit.Width = 50;
                lbl_btnedit.TextAlign = ContentAlignment.MiddleCenter;
                //查看试题信息标签
                var lbl_btn_check = new Label { Text = "" };
                lbl_btn_check.Width = 50;
                lbl_btn_check.TextAlign = ContentAlignment.MiddleCenter;
                //s删除课程信息标签
                var lbl_btn_delete = new Label { Text = "" };
                lbl_btn_delete.Width = 50;
                lbl_btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                ec_fLP_Exam_Info.Controls.Add(lbl_rb);
                ec_fLP_Exam_Info.Controls.Add(lbl_Loadman);
                ec_fLP_Exam_Info.Controls.Add(lbl_introducation);
                ec_fLP_Exam_Info.Controls.Add(lbl_credit);
                ec_fLP_Exam_Info.Controls.Add(lbl_recommendTime);
                ec_fLP_Exam_Info.Controls.Add(lbl_btnedit); 
                ec_fLP_Exam_Info.Controls.Add(lbl_btn_check);
                ec_fLP_Exam_Info.Controls.Add(lbl_btn_delete); 
                ec_fLP_Exam_Info.SetFlowBreak(lbl_btn_delete, true);
                for (var i = 0; i < ds.Tables["user"].Rows.Count; i++)
                {
                    //考试标题
                    var rb = new CheckBox { Text = ds.Tables["user"].Rows[i][0].ToString() };
                    rb.Font = font;
                    rb.Width = 100;
                    rb.Name = ds.Tables["user"].Rows[i][5].ToString();
                    rb.TextAlign = ContentAlignment.MiddleCenter;
                    rb.Click += new EventHandler(btn_oK_Click);
                    //创建人
                    var Loadman = new Label { Text = ds.Tables["user"].Rows[i][1].ToString() };
                    Loadman.Font = font;
                    Loadman.Width = 50;
                    Loadman.TextAlign = ContentAlignment.MiddleCenter;
                    //创建时间
                    var introducation = new Label { Text = ds.Tables["user"].Rows[i][2].ToString() };
                    introducation.Font = font;
                    introducation.Width = 90;
                    introducation.TextAlign = ContentAlignment.MiddleCenter;
                    //开始时间
                    var credit = new Label { Text = ds.Tables["user"].Rows[i][3].ToString() };
                    credit.Font = font;
                    credit.Width = 90;
                    credit.TextAlign = ContentAlignment.MiddleCenter;
                    //结束时间
                    var recommendTime = new Label { Text = ds.Tables["user"].Rows[i][4].ToString() };
                    recommendTime.Font = font;
                    recommendTime.Width = 90;
                    recommendTime.TextAlign = ContentAlignment.MiddleCenter;
                    //查看考试详细信息
                    var btn_edit = new Button { Text = "编辑" };
                    btn_edit.Width = 50;
                    btn_edit.TextAlign = ContentAlignment.MiddleCenter;
                    btn_edit.Name = ds.Tables["user"].Rows[i][5].ToString();
                    exam_p_id = btn_edit.Name;
                    btn_edit.Click += new EventHandler(EditExamInfo);
                    //查看考试详细信息
                    var btn_check = new Button { Text = "查看" };
                    btn_check.Width = 50;
                    btn_check.TextAlign = ContentAlignment.MiddleCenter;
                    btn_check.Name = ds.Tables["user"].Rows[i][5].ToString();
                    btn_check.Click += new EventHandler(CheckExamInfo);
                    //删除考试信息
                    var btn_delete = new Button { Text = "删除" };
                    btn_delete.Width = 50;
                    btn_delete.TextAlign = ContentAlignment.MiddleCenter;
                    btn_delete.Name = ds.Tables["user"].Rows[i][5].ToString();
                    btn_delete.Click += new EventHandler(deleteExam);
                    ec_fLP_Exam_Info.Controls.Add(rb);
                    ec_fLP_Exam_Info.Controls.Add(Loadman);
                    ec_fLP_Exam_Info.Controls.Add(introducation);
                    ec_fLP_Exam_Info.Controls.Add(credit);
                    ec_fLP_Exam_Info.Controls.Add(recommendTime);
                    ec_fLP_Exam_Info.Controls.Add(btn_edit);
                    ec_fLP_Exam_Info.Controls.Add(btn_check);
                    ec_fLP_Exam_Info.Controls.Add(btn_delete);
                    ec_fLP_Exam_Info.SetFlowBreak(btn_delete, true);
                }
            }
            else
            {
                //查询不到数据时提示无数据
                var lbl_no_data = new Label { Text = string.Concat("抱歉，当前没有查询到任何数据！") };
                lbl_no_data.Font = font;
                lbl_no_data.TextAlign = ContentAlignment.MiddleCenter;
                lbl_no_data.Width = 579;
                lbl_no_data.Height = 150;
                ec_fLP_Exam_Info.Controls.Add(lbl_no_data);
            }
        }
        //将复选框勾选到的考试信息传到父页面
        private void btn_oK_Click(object sender, EventArgs e)
        {
            //遍历
            foreach (Control ctl in ec_fLP_Exam_Info.Controls)
            {
                if (ctl is CheckBox)
                {
                    if ((ctl as CheckBox).Checked == true)
                    {
                        //处理代码
                        exam_p_name = ctl.Text;
                        exam_p_id = ctl.Name;
                    }
                }
            }
            //传递选定的课程
            EditPeriod.exam_name = exam_p_name;
            EditPeriod.exam_p_id = exam_p_id;
            //获取上一界面的已选课程窗口
            EditPeriod editperoid = (EditPeriod)this.Owner;
            editperoid.showClass_Exam_Info();
            this.Owner.Show();
            this.Dispose();
        }
        private void EditExamInfo(object sender, EventArgs e)
        {
            ShowControls();
            Button button = (Button)sender;
            int exam_id = -1;
            int.TryParse(button.Name, out exam_id);
            DataBaseConnection dc = new DataBaseConnection();
            string select_sql = "select exam_p_name,start_time,end_time from exam_paper where exam_p_id ="+ exam_id;
            DataSet ds = dc.ExecuteQuery(select_sql);
            this.ec_tBx_Exam_Name.Text = ds.Tables["user"].Rows[0][0].ToString();
            this.ec_dtp_Start_Time.Text = ds.Tables["user"].Rows[0][1].ToString();
            this.ec_dtp_End_Time.Text = ds.Tables["user"].Rows[0][2].ToString();
        }
        //查看考试详细信息,跳转到详细信息页面
        private void CheckExamInfo(object sender, EventArgs e)
        {

        }
        private void deleteExam(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int exam_id = -1;
            int.TryParse(button.Name,out exam_id);
            DataBaseConnection dc = new DataBaseConnection();
            if (MessageBox.Show("您确定要修改该阶段信息吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
            {
                string delete_sql = "delete from exam_paper where exam_p_id = "+exam_id;
                int flag = dc.ExecuteUpdate(delete_sql);
                if (flag == 1)
                {
                    MessageBox.Show("删除考试信息成功！");                    
                }
                else
                {
                    MessageBox.Show("删除考试信息失败，请联系系统管理员！");
                }
                ExamChoose_Load(sender, e);
            }
        }
        //新增考试信息按钮事件处理
        private void ec_btn_Add_Exam_Click(object sender, EventArgs e)
        {
            exam_p_id = null;
            ShowControls();
        }
        //显示新增考试信息的控件
        private void ShowControls()
        {
            this.ec_fLP_Exam_Info.Height = 290;
            this.ec_lbl_Exam_Name.Visible = true;
            this.ec_tBx_Exam_Name.Visible = true;
            this.ec_tBx_Exam_Name.Text = null;
            this.ec_lbl_Start_Time.Visible = true;
            this.ec_dtp_Start_Time.Visible = true;
            this.ec_dtp_Start_Time.Value = DateTime.Now.Date;
            this.ec_lbl_End_Time.Visible = true;
            this.ec_dtp_End_Time.Visible = true;
            this.ec_dtp_End_Time.Value = DateTime.Now.Date;
        }
        //隐藏新增考试信息的控件
        private void HideControls()
        {
            this.ec_fLP_Exam_Info.Height = 360;
            this.ec_lbl_Exam_Name.Visible = false;
            this.ec_tBx_Exam_Name.Visible = false;
            this.ec_lbl_Start_Time.Visible = false;
            this.ec_dtp_Start_Time.Visible = false;
            this.ec_lbl_End_Time.Visible = false;
            this.ec_dtp_End_Time.Visible = false;
        }
        //确认按钮事件处理
        private void ec_btn_confirm_Click(object sender, EventArgs e)
        {
            string exam_p_name = this.ec_tBx_Exam_Name.Text;
            DateTime start_time = Convert.ToDateTime(this.ec_dtp_Start_Time.Value);
            DateTime end_time = Convert.ToDateTime(this.ec_dtp_End_Time.Value);
            DataBaseConnection dc = new DataBaseConnection();
            int exam_id = -1;
            if (exam_p_id == null)
            {                
                string insert_sql = "insert into exam_paper values(next value for exam_paper_s," + Model.User.userId + ",convert(varchar(100),GETDATE(),23),convert(varchar(100),'" + start_time + "',23),convert(varchar(100),'" + end_time + "',23),'"+exam_p_name+"')";
                int flag = dc.ExecuteUpdate(insert_sql);
                if (flag == 1)
                {
                    MessageBox.Show("新增考试信息成功！");
                }
                else
                {
                    MessageBox.Show("新增考试信息失败，请联系系统管理员！");
                }
            }else
            {
                int.TryParse(exam_p_id, out exam_id);
                if (MessageBox.Show("您确定要修改该阶段信息吗？", "判断", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string update_sql = "update exam_paper set exam_p_name = '" + exam_p_name + "',start_time = convert(varchar(100),'" + start_time + "',23),end_time = convert(varchar(100),'" + end_time + "',23) where exam_p_id = " + exam_id;
                    int flag = dc.ExecuteUpdate(update_sql);
                    if (flag == 1)
                    {
                        MessageBox.Show("修改考试信息成功！");
                    }
                    else
                    {
                        MessageBox.Show("修改考试信息失败，请联系管理员！");
                    }
                }
            }
            ExamChoose_Load(sender,e);
        }
        //返回按钮事件处理
        private void ec_btn_back_Click(object sender, EventArgs e)
        {
            exam_p_id = null;
            this.Owner.Show();
            this.Dispose();
        }
    }
}

﻿namespace WindowsFormsApplication1
{
    partial class Classes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.c_lblTitle = new System.Windows.Forms.Label();
            this.p_lblCurPerson = new System.Windows.Forms.Label();
            this.p_lblWelcome = new System.Windows.Forms.Label();
            this.c_flpClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.c_lblClassesName = new System.Windows.Forms.Label();
            this.c_lblClassesCredit = new System.Windows.Forms.Label();
            this.c_lblOwner = new System.Windows.Forms.Label();
            this.c_lblPeriod = new System.Windows.Forms.Label();
            this.p_btnQuit = new CCWin.SkinControl.SkinButton();
            this.c_btnNecessary = new CCWin.SkinControl.SkinButton();
            this.c_btnOptional = new CCWin.SkinControl.SkinButton();
            this.c_btnAll = new CCWin.SkinControl.SkinButton();
            this.btn_chooseLesson = new CCWin.SkinControl.SkinButton();
            this.c_btnMine = new CCWin.SkinControl.SkinButton();
            this.btn_loadClasses = new CCWin.SkinControl.SkinButton();
            this.btn_PlanArrangement = new CCWin.SkinControl.SkinButton();
            this.p_btnHome = new CCWin.SkinControl.SkinButton();
            this.btn_ManagePlan = new CCWin.SkinControl.SkinButton();
            this.c_lbl_recommend_c = new System.Windows.Forms.Label();
            this.c_flp_recommend_c = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // c_lblTitle
            // 
            this.c_lblTitle.AutoSize = true;
            this.c_lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this.c_lblTitle.Location = new System.Drawing.Point(17, 31);
            this.c_lblTitle.Name = "c_lblTitle";
            this.c_lblTitle.Size = new System.Drawing.Size(160, 46);
            this.c_lblTitle.TabIndex = 0;
            this.c_lblTitle.Text = "课程中心";
            // 
            // p_lblCurPerson
            // 
            this.p_lblCurPerson.AutoSize = true;
            this.p_lblCurPerson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCurPerson.Location = new System.Drawing.Point(618, 45);
            this.p_lblCurPerson.Name = "p_lblCurPerson";
            this.p_lblCurPerson.Size = new System.Drawing.Size(32, 17);
            this.p_lblCurPerson.TabIndex = 8;
            this.p_lblCurPerson.Text = "XXX";
            // 
            // p_lblWelcome
            // 
            this.p_lblWelcome.AutoSize = true;
            this.p_lblWelcome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblWelcome.Location = new System.Drawing.Point(562, 45);
            this.p_lblWelcome.Name = "p_lblWelcome";
            this.p_lblWelcome.Size = new System.Drawing.Size(56, 17);
            this.p_lblWelcome.TabIndex = 7;
            this.p_lblWelcome.Text = "欢迎您，";
            // 
            // c_flpClasses
            // 
            this.c_flpClasses.AutoScroll = true;
            this.c_flpClasses.Location = new System.Drawing.Point(167, 131);
            this.c_flpClasses.Margin = new System.Windows.Forms.Padding(10);
            this.c_flpClasses.Name = "c_flpClasses";
            this.c_flpClasses.Size = new System.Drawing.Size(450, 292);
            this.c_flpClasses.TabIndex = 15;
            // 
            // c_lblClassesName
            // 
            this.c_lblClassesName.AutoSize = true;
            this.c_lblClassesName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_lblClassesName.Location = new System.Drawing.Point(201, 110);
            this.c_lblClassesName.Name = "c_lblClassesName";
            this.c_lblClassesName.Size = new System.Drawing.Size(44, 17);
            this.c_lblClassesName.TabIndex = 16;
            this.c_lblClassesName.Text = "课程名";
            // 
            // c_lblClassesCredit
            // 
            this.c_lblClassesCredit.AutoSize = true;
            this.c_lblClassesCredit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_lblClassesCredit.Location = new System.Drawing.Point(285, 109);
            this.c_lblClassesCredit.Name = "c_lblClassesCredit";
            this.c_lblClassesCredit.Size = new System.Drawing.Size(56, 17);
            this.c_lblClassesCredit.TabIndex = 17;
            this.c_lblClassesCredit.Text = "课程学分";
            // 
            // c_lblOwner
            // 
            this.c_lblOwner.AutoSize = true;
            this.c_lblOwner.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_lblOwner.Location = new System.Drawing.Point(360, 109);
            this.c_lblOwner.Name = "c_lblOwner";
            this.c_lblOwner.Size = new System.Drawing.Size(68, 17);
            this.c_lblOwner.TabIndex = 18;
            this.c_lblOwner.Text = "课程上传人";
            // 
            // c_lblPeriod
            // 
            this.c_lblPeriod.AutoSize = true;
            this.c_lblPeriod.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_lblPeriod.Location = new System.Drawing.Point(445, 109);
            this.c_lblPeriod.Name = "c_lblPeriod";
            this.c_lblPeriod.Size = new System.Drawing.Size(56, 17);
            this.c_lblPeriod.TabIndex = 19;
            this.c_lblPeriod.Text = "推荐学时";
            // 
            // p_btnQuit
            // 
            this.p_btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnQuit.DownBack = null;
            this.p_btnQuit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_btnQuit.Location = new System.Drawing.Point(666, 36);
            this.p_btnQuit.MouseBack = null;
            this.p_btnQuit.Name = "p_btnQuit";
            this.p_btnQuit.NormlBack = null;
            this.p_btnQuit.Size = new System.Drawing.Size(59, 35);
            this.p_btnQuit.TabIndex = 20;
            this.p_btnQuit.Text = "注销";
            this.p_btnQuit.UseVisualStyleBackColor = false;
            this.p_btnQuit.Click += new System.EventHandler(this.p_btnQuit_Click);
            // 
            // c_btnNecessary
            // 
            this.c_btnNecessary.BackColor = System.Drawing.Color.Transparent;
            this.c_btnNecessary.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.c_btnNecessary.DownBack = null;
            this.c_btnNecessary.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_btnNecessary.Location = new System.Drawing.Point(64, 123);
            this.c_btnNecessary.MouseBack = null;
            this.c_btnNecessary.Name = "c_btnNecessary";
            this.c_btnNecessary.NormlBack = null;
            this.c_btnNecessary.Size = new System.Drawing.Size(88, 54);
            this.c_btnNecessary.TabIndex = 21;
            this.c_btnNecessary.Text = "必修课程";
            this.c_btnNecessary.UseVisualStyleBackColor = false;
            this.c_btnNecessary.Click += new System.EventHandler(this.c_btnNecessary_Click);
            // 
            // c_btnOptional
            // 
            this.c_btnOptional.BackColor = System.Drawing.Color.Transparent;
            this.c_btnOptional.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.c_btnOptional.DownBack = null;
            this.c_btnOptional.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_btnOptional.Location = new System.Drawing.Point(64, 206);
            this.c_btnOptional.MouseBack = null;
            this.c_btnOptional.Name = "c_btnOptional";
            this.c_btnOptional.NormlBack = null;
            this.c_btnOptional.Size = new System.Drawing.Size(88, 54);
            this.c_btnOptional.TabIndex = 22;
            this.c_btnOptional.Text = "选修课程";
            this.c_btnOptional.UseVisualStyleBackColor = false;
            this.c_btnOptional.Click += new System.EventHandler(this.c_btnOptional_Click);
            // 
            // c_btnAll
            // 
            this.c_btnAll.BackColor = System.Drawing.Color.Transparent;
            this.c_btnAll.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.c_btnAll.DownBack = null;
            this.c_btnAll.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_btnAll.Location = new System.Drawing.Point(64, 289);
            this.c_btnAll.MouseBack = null;
            this.c_btnAll.Name = "c_btnAll";
            this.c_btnAll.NormlBack = null;
            this.c_btnAll.Size = new System.Drawing.Size(88, 54);
            this.c_btnAll.TabIndex = 23;
            this.c_btnAll.Text = "全部课程";
            this.c_btnAll.UseVisualStyleBackColor = false;
            this.c_btnAll.Click += new System.EventHandler(this.c_btnAll_Click);
            // 
            // btn_chooseLesson
            // 
            this.btn_chooseLesson.BackColor = System.Drawing.Color.Transparent;
            this.btn_chooseLesson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_chooseLesson.DownBack = null;
            this.btn_chooseLesson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_chooseLesson.Location = new System.Drawing.Point(64, 375);
            this.btn_chooseLesson.MouseBack = null;
            this.btn_chooseLesson.Name = "btn_chooseLesson";
            this.btn_chooseLesson.NormlBack = null;
            this.btn_chooseLesson.Size = new System.Drawing.Size(88, 54);
            this.btn_chooseLesson.TabIndex = 24;
            this.btn_chooseLesson.Text = "选课";
            this.btn_chooseLesson.UseVisualStyleBackColor = false;
            this.btn_chooseLesson.Click += new System.EventHandler(this.btn_chooseLesson_Click);
            // 
            // c_btnMine
            // 
            this.c_btnMine.BackColor = System.Drawing.Color.Transparent;
            this.c_btnMine.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.c_btnMine.DownBack = null;
            this.c_btnMine.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.c_btnMine.Location = new System.Drawing.Point(637, 123);
            this.c_btnMine.MouseBack = null;
            this.c_btnMine.Name = "c_btnMine";
            this.c_btnMine.NormlBack = null;
            this.c_btnMine.Size = new System.Drawing.Size(88, 54);
            this.c_btnMine.TabIndex = 25;
            this.c_btnMine.Text = "我上传的";
            this.c_btnMine.UseVisualStyleBackColor = false;
            this.c_btnMine.Visible = false;
            this.c_btnMine.Click += new System.EventHandler(this.c_btnMine_Click);
            // 
            // btn_loadClasses
            // 
            this.btn_loadClasses.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadClasses.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_loadClasses.DownBack = null;
            this.btn_loadClasses.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_loadClasses.Location = new System.Drawing.Point(637, 206);
            this.btn_loadClasses.MouseBack = null;
            this.btn_loadClasses.Name = "btn_loadClasses";
            this.btn_loadClasses.NormlBack = null;
            this.btn_loadClasses.Size = new System.Drawing.Size(88, 54);
            this.btn_loadClasses.TabIndex = 26;
            this.btn_loadClasses.Text = "上传课程";
            this.btn_loadClasses.UseVisualStyleBackColor = false;
            this.btn_loadClasses.Visible = false;
            this.btn_loadClasses.Click += new System.EventHandler(this.btn_loadClasses_Click);
            // 
            // btn_PlanArrangement
            // 
            this.btn_PlanArrangement.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlanArrangement.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_PlanArrangement.DownBack = null;
            this.btn_PlanArrangement.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_PlanArrangement.Location = new System.Drawing.Point(637, 375);
            this.btn_PlanArrangement.MouseBack = null;
            this.btn_PlanArrangement.Name = "btn_PlanArrangement";
            this.btn_PlanArrangement.NormlBack = null;
            this.btn_PlanArrangement.Size = new System.Drawing.Size(88, 54);
            this.btn_PlanArrangement.TabIndex = 27;
            this.btn_PlanArrangement.Text = "安排学习计划";
            this.btn_PlanArrangement.UseVisualStyleBackColor = false;
            this.btn_PlanArrangement.Visible = false;
            this.btn_PlanArrangement.Click += new System.EventHandler(this.btn_lessonArrangement_Click);
            // 
            // p_btnHome
            // 
            this.p_btnHome.BackColor = System.Drawing.Color.Transparent;
            this.p_btnHome.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnHome.DownBack = null;
            this.p_btnHome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_btnHome.Location = new System.Drawing.Point(676, 610);
            this.p_btnHome.MouseBack = null;
            this.p_btnHome.Name = "p_btnHome";
            this.p_btnHome.NormlBack = null;
            this.p_btnHome.Size = new System.Drawing.Size(91, 37);
            this.p_btnHome.TabIndex = 28;
            this.p_btnHome.Text = "返回主页";
            this.p_btnHome.UseVisualStyleBackColor = false;
            this.p_btnHome.Click += new System.EventHandler(this.p_btnHome_Click);
            // 
            // btn_ManagePlan
            // 
            this.btn_ManagePlan.BackColor = System.Drawing.Color.Transparent;
            this.btn_ManagePlan.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ManagePlan.DownBack = null;
            this.btn_ManagePlan.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_ManagePlan.Location = new System.Drawing.Point(637, 289);
            this.btn_ManagePlan.MouseBack = null;
            this.btn_ManagePlan.Name = "btn_ManagePlan";
            this.btn_ManagePlan.NormlBack = null;
            this.btn_ManagePlan.Size = new System.Drawing.Size(88, 54);
            this.btn_ManagePlan.TabIndex = 29;
            this.btn_ManagePlan.Text = "学习计划管理";
            this.btn_ManagePlan.UseVisualStyleBackColor = false;
            this.btn_ManagePlan.Visible = false;
            this.btn_ManagePlan.Click += new System.EventHandler(this.btn_ManagePlan_Click);
            // 
            // c_lbl_recommend_c
            // 
            this.c_lbl_recommend_c.AutoSize = true;
            this.c_lbl_recommend_c.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_lbl_recommend_c.Location = new System.Drawing.Point(125, 444);
            this.c_lbl_recommend_c.Name = "c_lbl_recommend_c";
            this.c_lbl_recommend_c.Size = new System.Drawing.Size(79, 20);
            this.c_lbl_recommend_c.TabIndex = 30;
            this.c_lbl_recommend_c.Text = "推荐课程：";
            // 
            // c_flp_recommend_c
            // 
            this.c_flp_recommend_c.Location = new System.Drawing.Point(167, 483);
            this.c_flp_recommend_c.Name = "c_flp_recommend_c";
            this.c_flp_recommend_c.Size = new System.Drawing.Size(450, 130);
            this.c_flp_recommend_c.TabIndex = 31;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(810, 669);
            this.Controls.Add(this.c_flp_recommend_c);
            this.Controls.Add(this.c_lbl_recommend_c);
            this.Controls.Add(this.btn_ManagePlan);
            this.Controls.Add(this.p_btnHome);
            this.Controls.Add(this.btn_PlanArrangement);
            this.Controls.Add(this.btn_loadClasses);
            this.Controls.Add(this.c_btnMine);
            this.Controls.Add(this.btn_chooseLesson);
            this.Controls.Add(this.c_btnAll);
            this.Controls.Add(this.c_btnOptional);
            this.Controls.Add(this.c_btnNecessary);
            this.Controls.Add(this.p_btnQuit);
            this.Controls.Add(this.c_lblPeriod);
            this.Controls.Add(this.c_lblOwner);
            this.Controls.Add(this.c_lblClassesCredit);
            this.Controls.Add(this.c_lblClassesName);
            this.Controls.Add(this.c_flpClasses);
            this.Controls.Add(this.p_lblCurPerson);
            this.Controls.Add(this.p_lblWelcome);
            this.Controls.Add(this.c_lblTitle);
            this.Name = "Classes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程中心";
            this.Load += new System.EventHandler(this.Classes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c_lblTitle;
        private System.Windows.Forms.Label p_lblCurPerson;
        private System.Windows.Forms.Label p_lblWelcome;
        private System.Windows.Forms.FlowLayoutPanel c_flpClasses;
        private System.Windows.Forms.Label c_lblClassesName;
        private System.Windows.Forms.Label c_lblClassesCredit;
        private System.Windows.Forms.Label c_lblOwner;
        private System.Windows.Forms.Label c_lblPeriod;
        private CCWin.SkinControl.SkinButton p_btnQuit;
        private CCWin.SkinControl.SkinButton c_btnNecessary;
        private CCWin.SkinControl.SkinButton c_btnOptional;
        private CCWin.SkinControl.SkinButton c_btnAll;
        private CCWin.SkinControl.SkinButton btn_chooseLesson;
        private CCWin.SkinControl.SkinButton c_btnMine;
        private CCWin.SkinControl.SkinButton btn_loadClasses;
        private CCWin.SkinControl.SkinButton btn_PlanArrangement;
        private CCWin.SkinControl.SkinButton p_btnHome;
        private CCWin.SkinControl.SkinButton btn_ManagePlan;
        private System.Windows.Forms.Label c_lbl_recommend_c;
        private System.Windows.Forms.FlowLayoutPanel c_flp_recommend_c;
    }
}
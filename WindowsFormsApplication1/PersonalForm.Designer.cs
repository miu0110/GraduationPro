﻿namespace WindowsFormsApplication1
{
    partial class PersonalForm
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
            this.p_lblTitle = new System.Windows.Forms.Label();
            this.p_lblWelcome = new System.Windows.Forms.Label();
            this.p_lblCurPerson = new System.Windows.Forms.Label();
            this.p_lbl_Name = new System.Windows.Forms.Label();
            this.p_lblName = new System.Windows.Forms.Label();
            this.p_lbl_Account = new System.Windows.Forms.Label();
            this.p_lblAccount = new System.Windows.Forms.Label();
            this.p_lbl_Group = new System.Windows.Forms.Label();
            this.p_lblGroup = new System.Windows.Forms.Label();
            this.p_lbl_Credit = new System.Windows.Forms.Label();
            this.p_lblCredit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.p_lblPhone = new System.Windows.Forms.Label();
            this.p_flpClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.p_btnQuit = new CCWin.SkinControl.SkinButton();
            this.Btn_classfinished = new CCWin.SkinControl.SkinButton();
            this.btn_classunfinished = new CCWin.SkinControl.SkinButton();
            this.p_btnHome = new CCWin.SkinControl.SkinButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_ApplyUndisposed = new CCWin.SkinControl.SkinButton();
            this.Btn_MyApply = new CCWin.SkinControl.SkinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.p_lblEntryTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p_lblTitle
            // 
            this.p_lblTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold);
            this.p_lblTitle.Location = new System.Drawing.Point(17, 31);
            this.p_lblTitle.Name = "p_lblTitle";
            this.p_lblTitle.Size = new System.Drawing.Size(168, 42);
            this.p_lblTitle.TabIndex = 0;
            this.p_lblTitle.Text = "个人中心";
            // 
            // p_lblWelcome
            // 
            this.p_lblWelcome.AutoSize = true;
            this.p_lblWelcome.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblWelcome.Location = new System.Drawing.Point(556, 42);
            this.p_lblWelcome.Name = "p_lblWelcome";
            this.p_lblWelcome.Size = new System.Drawing.Size(56, 17);
            this.p_lblWelcome.TabIndex = 1;
            this.p_lblWelcome.Text = "欢迎您，";
            // 
            // p_lblCurPerson
            // 
            this.p_lblCurPerson.AutoSize = true;
            this.p_lblCurPerson.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCurPerson.Location = new System.Drawing.Point(618, 42);
            this.p_lblCurPerson.Name = "p_lblCurPerson";
            this.p_lblCurPerson.Size = new System.Drawing.Size(32, 17);
            this.p_lblCurPerson.TabIndex = 2;
            this.p_lblCurPerson.Text = "XXX";
            // 
            // p_lbl_Name
            // 
            this.p_lbl_Name.AutoSize = true;
            this.p_lbl_Name.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Name.Location = new System.Drawing.Point(96, 89);
            this.p_lbl_Name.Name = "p_lbl_Name";
            this.p_lbl_Name.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Name.TabIndex = 5;
            this.p_lbl_Name.Text = "姓名：";
            // 
            // p_lblName
            // 
            this.p_lblName.AutoSize = true;
            this.p_lblName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblName.Location = new System.Drawing.Point(179, 89);
            this.p_lblName.Name = "p_lblName";
            this.p_lblName.Size = new System.Drawing.Size(32, 17);
            this.p_lblName.TabIndex = 6;
            this.p_lblName.Text = "张三";
            // 
            // p_lbl_Account
            // 
            this.p_lbl_Account.AutoSize = true;
            this.p_lbl_Account.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Account.Location = new System.Drawing.Point(96, 119);
            this.p_lbl_Account.Name = "p_lbl_Account";
            this.p_lbl_Account.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Account.TabIndex = 7;
            this.p_lbl_Account.Text = "工号：";
            // 
            // p_lblAccount
            // 
            this.p_lblAccount.AutoSize = true;
            this.p_lblAccount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblAccount.Location = new System.Drawing.Point(179, 119);
            this.p_lblAccount.Name = "p_lblAccount";
            this.p_lblAccount.Size = new System.Drawing.Size(36, 17);
            this.p_lblAccount.TabIndex = 8;
            this.p_lblAccount.Text = "1001";
            // 
            // p_lbl_Group
            // 
            this.p_lbl_Group.AutoSize = true;
            this.p_lbl_Group.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Group.Location = new System.Drawing.Point(96, 147);
            this.p_lbl_Group.Name = "p_lbl_Group";
            this.p_lbl_Group.Size = new System.Drawing.Size(68, 17);
            this.p_lbl_Group.TabIndex = 9;
            this.p_lbl_Group.Text = "所在分组：";
            // 
            // p_lblGroup
            // 
            this.p_lblGroup.AutoSize = true;
            this.p_lblGroup.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblGroup.Location = new System.Drawing.Point(179, 147);
            this.p_lblGroup.Name = "p_lblGroup";
            this.p_lblGroup.Size = new System.Drawing.Size(32, 17);
            this.p_lblGroup.TabIndex = 10;
            this.p_lblGroup.Text = "涂装";
            // 
            // p_lbl_Credit
            // 
            this.p_lbl_Credit.AutoSize = true;
            this.p_lbl_Credit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lbl_Credit.Location = new System.Drawing.Point(96, 177);
            this.p_lbl_Credit.Name = "p_lbl_Credit";
            this.p_lbl_Credit.Size = new System.Drawing.Size(44, 17);
            this.p_lbl_Credit.TabIndex = 11;
            this.p_lbl_Credit.Text = "学分：";
            // 
            // p_lblCredit
            // 
            this.p_lblCredit.AutoSize = true;
            this.p_lblCredit.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblCredit.Location = new System.Drawing.Point(179, 177);
            this.p_lblCredit.Name = "p_lblCredit";
            this.p_lblCredit.Size = new System.Drawing.Size(22, 17);
            this.p_lblCredit.TabIndex = 12;
            this.p_lblCredit.Text = "63";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label8.Location = new System.Drawing.Point(96, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "我的课程：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.Location = new System.Drawing.Point(96, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "电话号码：";
            // 
            // p_lblPhone
            // 
            this.p_lblPhone.AutoSize = true;
            this.p_lblPhone.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblPhone.Location = new System.Drawing.Point(179, 269);
            this.p_lblPhone.Name = "p_lblPhone";
            this.p_lblPhone.Size = new System.Drawing.Size(85, 17);
            this.p_lblPhone.TabIndex = 17;
            this.p_lblPhone.Text = "15686323256";
            // 
            // p_flpClasses
            // 
            this.p_flpClasses.AutoScroll = true;
            this.p_flpClasses.Location = new System.Drawing.Point(99, 335);
            this.p_flpClasses.Name = "p_flpClasses";
            this.p_flpClasses.Size = new System.Drawing.Size(572, 189);
            this.p_flpClasses.TabIndex = 18;
            // 
            // p_btnQuit
            // 
            this.p_btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.p_btnQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnQuit.DownBack = null;
            this.p_btnQuit.Location = new System.Drawing.Point(665, 34);
            this.p_btnQuit.MouseBack = null;
            this.p_btnQuit.Name = "p_btnQuit";
            this.p_btnQuit.NormlBack = null;
            this.p_btnQuit.Size = new System.Drawing.Size(61, 34);
            this.p_btnQuit.TabIndex = 19;
            this.p_btnQuit.Text = "注销";
            this.p_btnQuit.UseVisualStyleBackColor = false;
            this.p_btnQuit.Click += new System.EventHandler(this.p_btnQuit_Click);
            // 
            // Btn_classfinished
            // 
            this.Btn_classfinished.BackColor = System.Drawing.Color.Transparent;
            this.Btn_classfinished.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_classfinished.DownBack = null;
            this.Btn_classfinished.Location = new System.Drawing.Point(182, 224);
            this.Btn_classfinished.MouseBack = null;
            this.Btn_classfinished.Name = "Btn_classfinished";
            this.Btn_classfinished.NormlBack = null;
            this.Btn_classfinished.Size = new System.Drawing.Size(77, 34);
            this.Btn_classfinished.TabIndex = 20;
            this.Btn_classfinished.Text = "已完成";
            this.Btn_classfinished.UseVisualStyleBackColor = false;
            this.Btn_classfinished.Click += new System.EventHandler(this.Btn_classfinished_Click);
            // 
            // btn_classunfinished
            // 
            this.btn_classunfinished.BackColor = System.Drawing.Color.Transparent;
            this.btn_classunfinished.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_classunfinished.DownBack = null;
            this.btn_classunfinished.Location = new System.Drawing.Point(274, 224);
            this.btn_classunfinished.MouseBack = null;
            this.btn_classunfinished.Name = "btn_classunfinished";
            this.btn_classunfinished.NormlBack = null;
            this.btn_classunfinished.Size = new System.Drawing.Size(77, 34);
            this.btn_classunfinished.TabIndex = 21;
            this.btn_classunfinished.Text = "尚未完成";
            this.btn_classunfinished.UseVisualStyleBackColor = false;
            this.btn_classunfinished.Click += new System.EventHandler(this.btn_classunfinished_Click);
            // 
            // p_btnHome
            // 
            this.p_btnHome.BackColor = System.Drawing.Color.Transparent;
            this.p_btnHome.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.p_btnHome.DownBack = null;
            this.p_btnHome.Location = new System.Drawing.Point(621, 533);
            this.p_btnHome.MouseBack = null;
            this.p_btnHome.Name = "p_btnHome";
            this.p_btnHome.NormlBack = null;
            this.p_btnHome.Size = new System.Drawing.Size(91, 37);
            this.p_btnHome.TabIndex = 22;
            this.p_btnHome.Text = "返回主页";
            this.p_btnHome.UseVisualStyleBackColor = false;
            this.p_btnHome.Click += new System.EventHandler(this.p_btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(96, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "请假申请：";
            // 
            // Btn_ApplyUndisposed
            // 
            this.Btn_ApplyUndisposed.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ApplyUndisposed.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_ApplyUndisposed.DownBack = null;
            this.Btn_ApplyUndisposed.Location = new System.Drawing.Point(182, 294);
            this.Btn_ApplyUndisposed.MouseBack = null;
            this.Btn_ApplyUndisposed.Name = "Btn_ApplyUndisposed";
            this.Btn_ApplyUndisposed.NormlBack = null;
            this.Btn_ApplyUndisposed.Size = new System.Drawing.Size(77, 34);
            this.Btn_ApplyUndisposed.TabIndex = 24;
            this.Btn_ApplyUndisposed.Text = "未处理";
            this.Btn_ApplyUndisposed.UseVisualStyleBackColor = false;
            this.Btn_ApplyUndisposed.Click += new System.EventHandler(this.Btn_ApplyUndisposed_Click);
            // 
            // Btn_MyApply
            // 
            this.Btn_MyApply.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MyApply.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Btn_MyApply.DownBack = null;
            this.Btn_MyApply.Location = new System.Drawing.Point(274, 294);
            this.Btn_MyApply.MouseBack = null;
            this.Btn_MyApply.Name = "Btn_MyApply";
            this.Btn_MyApply.NormlBack = null;
            this.Btn_MyApply.Size = new System.Drawing.Size(77, 34);
            this.Btn_MyApply.TabIndex = 25;
            this.Btn_MyApply.Text = "我的申请";
            this.Btn_MyApply.UseVisualStyleBackColor = false;
            this.Btn_MyApply.Click += new System.EventHandler(this.Btn_MyApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(96, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "入职时间：";
            // 
            // p_lblEntryTime
            // 
            this.p_lblEntryTime.AutoSize = true;
            this.p_lblEntryTime.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.p_lblEntryTime.Location = new System.Drawing.Point(179, 204);
            this.p_lblEntryTime.Name = "p_lblEntryTime";
            this.p_lblEntryTime.Size = new System.Drawing.Size(36, 17);
            this.p_lblEntryTime.TabIndex = 27;
            this.p_lblEntryTime.Text = "2342";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.ControlBox = false;
            this.Controls.Add(this.p_lblEntryTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_MyApply);
            this.Controls.Add(this.Btn_ApplyUndisposed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_btnHome);
            this.Controls.Add(this.btn_classunfinished);
            this.Controls.Add(this.Btn_classfinished);
            this.Controls.Add(this.p_btnQuit);
            this.Controls.Add(this.p_flpClasses);
            this.Controls.Add(this.p_lblPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.p_lblCredit);
            this.Controls.Add(this.p_lbl_Credit);
            this.Controls.Add(this.p_lblGroup);
            this.Controls.Add(this.p_lbl_Account);
            this.Controls.Add(this.p_lbl_Name);
            this.Controls.Add(this.p_lbl_Group);
            this.Controls.Add(this.p_lblAccount);
            this.Controls.Add(this.p_lblName);
            this.Controls.Add(this.p_lblCurPerson);
            this.Controls.Add(this.p_lblWelcome);
            this.Controls.Add(this.p_lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "PersonalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalForm";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_lblTitle;
        private System.Windows.Forms.Label p_lblWelcome;
        private System.Windows.Forms.Label p_lblCurPerson;
        private System.Windows.Forms.Label p_lbl_Name;
        private System.Windows.Forms.Label p_lblName;
        private System.Windows.Forms.Label p_lbl_Account;
        private System.Windows.Forms.Label p_lblAccount;
        private System.Windows.Forms.Label p_lbl_Group;
        private System.Windows.Forms.Label p_lblGroup;
        private System.Windows.Forms.Label p_lbl_Credit;
        private System.Windows.Forms.Label p_lblCredit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label p_lblPhone;
        private System.Windows.Forms.FlowLayoutPanel p_flpClasses;
        private CCWin.SkinControl.SkinButton p_btnQuit;
        private CCWin.SkinControl.SkinButton Btn_classfinished;
        private CCWin.SkinControl.SkinButton btn_classunfinished;
        private CCWin.SkinControl.SkinButton p_btnHome;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinButton Btn_ApplyUndisposed;
        private CCWin.SkinControl.SkinButton Btn_MyApply;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label p_lblEntryTime;
    }
}
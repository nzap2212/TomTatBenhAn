﻿namespace UI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            departmentCB = new TextBox();
            userCodeCB = new TextBox();
            userNameCB = new TextBox();
            label3 = new Label();
            loginBtn = new Button();
            exitBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(230, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên người sử dụng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 127);
            label2.Name = "label2";
            label2.Size = new Size(198, 28);
            label2.TabIndex = 1;
            label2.Text = "Nhập tên phòng ban:";
            // 
            // panel1
            // 
            panel1.Controls.Add(departmentCB);
            panel1.Controls.Add(userCodeCB);
            panel1.Controls.Add(userNameCB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 195);
            panel1.TabIndex = 3;
            // 
            // departmentCB
            // 
            departmentCB.Location = new Point(251, 131);
            departmentCB.Name = "departmentCB";
            departmentCB.Size = new Size(315, 27);
            departmentCB.TabIndex = 8;
            // 
            // userCodeCB
            // 
            userCodeCB.Location = new Point(251, 80);
            userCodeCB.Name = "userCodeCB";
            userCodeCB.Size = new Size(315, 27);
            userCodeCB.TabIndex = 7;
            // 
            // userNameCB
            // 
            userNameCB.Location = new Point(251, 28);
            userNameCB.Name = "userNameCB";
            userNameCB.Size = new Size(315, 27);
            userNameCB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 76);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 5;
            label3.Text = "Nhập mã nhân viên:";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(507, 213);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Đồng ý";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(382, 213);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 256);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tóm tắt hồ sơ bệnh án";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button loginBtn;
        private Button exitBtn;
        private Label label3;
        private TextBox departmentCB;
        private TextBox userCodeCB;
        private TextBox userNameCB;
    }
}
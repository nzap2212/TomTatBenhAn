﻿namespace UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox1 = new GroupBox();
            usage_txb = new TextBox();
            department_txb = new TextBox();
            user_txb = new TextBox();
            server_status = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            label9 = new Label();
            groupBox3 = new GroupBox();
            CCCDtxb = new TextBox();
            label14 = new Label();
            BN_bhyt = new TextBox();
            BN_name = new TextBox();
            label8 = new Label();
            label4 = new Label();
            TomTat_btn = new Button();
            SoBenhAn_input = new TextBox();
            MaYTe_input = new TextBox();
            MaYTe_checkbox = new CheckBox();
            SoBenhAn_checkbox = new CheckBox();
            menuStrip1 = new MenuStrip();
            kiểmTraCậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            kToolStripMenuItem = new ToolStripMenuItem();
            kiểmTraCấuHìnhToolStripMenuItem = new ToolStripMenuItem();
            groupBox4 = new GroupBox();
            GoiYPhacDoBtn = new Button();
            doctorName = new TextBox();
            label19 = new Label();
            orderReport = new TextBox();
            label7 = new Label();
            editReportBtn = new Button();
            groupBox6 = new GroupBox();
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            TienSuBenhlbl = new Label();
            TomTatInfolbl = new Label();
            Lydovaovienlbl = new Label();
            label13 = new Label();
            tabPage2 = new TabPage();
            KQXNlbl = new Label();
            tabPage3 = new TabPage();
            ppDieuTrilbl = new Label();
            tabPage4 = new TabPage();
            TTNBlbl = new Label();
            groupBox5 = new GroupBox();
            groupBox8 = new GroupBox();
            BenhPhuICD2 = new Label();
            BenhChinhICD2 = new Label();
            BenhPhu2 = new Label();
            BenhChinh2 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            groupBox7 = new GroupBox();
            BenhPhuICD1 = new Label();
            BenhChinhICD1 = new Label();
            BenhPhu1 = new Label();
            BenhChinh1 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            groupBox2 = new GroupBox();
            DayOutlbl = new Label();
            DayInlbl = new Label();
            MaYTeRs = new Label();
            SoBenhAnRs = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            SoBenhAnlst = new ComboBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(usage_txb);
            groupBox1.Controls.Add(department_txb);
            groupBox1.Controls.Add(user_txb);
            groupBox1.Controls.Add(server_status);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 54);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(719, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin người dùng";
            // 
            // usage_txb
            // 
            usage_txb.Enabled = false;
            usage_txb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usage_txb.Location = new Point(214, 139);
            usage_txb.Margin = new Padding(4);
            usage_txb.Name = "usage_txb";
            usage_txb.ReadOnly = true;
            usage_txb.Size = new Size(449, 36);
            usage_txb.TabIndex = 11;
            // 
            // department_txb
            // 
            department_txb.Enabled = false;
            department_txb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department_txb.Location = new Point(214, 86);
            department_txb.Margin = new Padding(4);
            department_txb.Name = "department_txb";
            department_txb.ReadOnly = true;
            department_txb.Size = new Size(449, 36);
            department_txb.TabIndex = 10;
            // 
            // user_txb
            // 
            user_txb.Enabled = false;
            user_txb.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_txb.Location = new Point(214, 35);
            user_txb.Margin = new Padding(4);
            user_txb.Name = "user_txb";
            user_txb.ReadOnly = true;
            user_txb.Size = new Size(449, 36);
            user_txb.TabIndex = 9;
            // 
            // server_status
            // 
            server_status.AutoSize = true;
            server_status.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            server_status.ForeColor = Color.Red;
            server_status.Location = new Point(349, 192);
            server_status.Margin = new Padding(4, 0, 4, 0);
            server_status.Name = "server_status";
            server_status.Size = new Size(144, 30);
            server_status.TabIndex = 8;
            server_status.Text = "Chưa kết nối";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 2;
            label3.Text = "Số lượt sử dụng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 1;
            label2.Text = "Phòng ban:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 194);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(307, 30);
            label6.TabIndex = 3;
            label6.Text = "Trạng thái kết nối với máy chủ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 0;
            label1.Text = "Người sử dụng:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 32);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 30);
            label9.TabIndex = 12;
            label9.Text = "Bệnh án số:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(CCCDtxb);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(BN_bhyt);
            groupBox3.Controls.Add(BN_name);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(TomTat_btn);
            groupBox3.Controls.Add(SoBenhAn_input);
            groupBox3.Controls.Add(MaYTe_input);
            groupBox3.Controls.Add(MaYTe_checkbox);
            groupBox3.Controls.Add(SoBenhAn_checkbox);
            groupBox3.Location = new Point(791, 54);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(991, 241);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng chính";
            // 
            // CCCDtxb
            // 
            CCCDtxb.Location = new Point(622, 181);
            CCCDtxb.Margin = new Padding(4);
            CCCDtxb.Name = "CCCDtxb";
            CCCDtxb.Size = new Size(324, 31);
            CCCDtxb.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(524, 186);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(88, 25);
            label14.TabIndex = 11;
            label14.Text = "Số CCCD:";
            // 
            // BN_bhyt
            // 
            BN_bhyt.Location = new Point(622, 114);
            BN_bhyt.Margin = new Padding(4);
            BN_bhyt.Name = "BN_bhyt";
            BN_bhyt.ReadOnly = true;
            BN_bhyt.Size = new Size(324, 31);
            BN_bhyt.TabIndex = 10;
            // 
            // BN_name
            // 
            BN_name.Location = new Point(622, 44);
            BN_name.Margin = new Padding(4);
            BN_name.Name = "BN_name";
            BN_name.ReadOnly = true;
            BN_name.Size = new Size(324, 31);
            BN_name.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 119);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 8;
            label8.Text = "Số thẻ BHYT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 46);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 6;
            label4.Text = "Tên bệnh nhân:";
            // 
            // TomTat_btn
            // 
            TomTat_btn.Location = new Point(21, 172);
            TomTat_btn.Margin = new Padding(4);
            TomTat_btn.Name = "TomTat_btn";
            TomTat_btn.Size = new Size(418, 54);
            TomTat_btn.TabIndex = 4;
            TomTat_btn.Text = "Tóm tắt bệnh án";
            TomTat_btn.UseVisualStyleBackColor = true;
            TomTat_btn.Click += TomTat_btn_Click;
            // 
            // SoBenhAn_input
            // 
            SoBenhAn_input.Enabled = false;
            SoBenhAn_input.Location = new Point(186, 110);
            SoBenhAn_input.Margin = new Padding(4);
            SoBenhAn_input.Name = "SoBenhAn_input";
            SoBenhAn_input.Size = new Size(252, 31);
            SoBenhAn_input.TabIndex = 3;
            SoBenhAn_input.Enter += SoBenhAn_input_Enter;
            // 
            // MaYTe_input
            // 
            MaYTe_input.Enabled = false;
            MaYTe_input.Location = new Point(186, 46);
            MaYTe_input.Margin = new Padding(4);
            MaYTe_input.Name = "MaYTe_input";
            MaYTe_input.Size = new Size(252, 31);
            MaYTe_input.TabIndex = 2;
            MaYTe_input.Enter += MaYTe_input_Enter;
            // 
            // MaYTe_checkbox
            // 
            MaYTe_checkbox.AutoSize = true;
            MaYTe_checkbox.Location = new Point(34, 46);
            MaYTe_checkbox.Margin = new Padding(4);
            MaYTe_checkbox.Name = "MaYTe_checkbox";
            MaYTe_checkbox.Size = new Size(101, 29);
            MaYTe_checkbox.TabIndex = 1;
            MaYTe_checkbox.Text = "Mã y tế:";
            MaYTe_checkbox.UseVisualStyleBackColor = true;
            MaYTe_checkbox.CheckedChanged += MaYTe_checkbox_CheckedChanged;
            // 
            // SoBenhAn_checkbox
            // 
            SoBenhAn_checkbox.AutoSize = true;
            SoBenhAn_checkbox.Location = new Point(34, 114);
            SoBenhAn_checkbox.Margin = new Padding(4);
            SoBenhAn_checkbox.Name = "SoBenhAn_checkbox";
            SoBenhAn_checkbox.Size = new Size(132, 29);
            SoBenhAn_checkbox.TabIndex = 0;
            SoBenhAn_checkbox.Text = "Số bệnh án:";
            SoBenhAn_checkbox.UseVisualStyleBackColor = true;
            SoBenhAn_checkbox.CheckedChanged += SoBenhAn_checkbox_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kiểmTraCậpNhậtToolStripMenuItem, kToolStripMenuItem, kiểmTraCấuHìnhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 4, 0, 4);
            menuStrip1.Size = new Size(1828, 37);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // kiểmTraCậpNhậtToolStripMenuItem
            // 
            kiểmTraCậpNhậtToolStripMenuItem.Name = "kiểmTraCậpNhậtToolStripMenuItem";
            kiểmTraCậpNhậtToolStripMenuItem.Size = new Size(166, 29);
            kiểmTraCậpNhậtToolStripMenuItem.Text = "Kiểm tra cập nhật";
            kiểmTraCậpNhậtToolStripMenuItem.Click += kiểmTraCậpNhậtToolStripMenuItem_Click;
            // 
            // kToolStripMenuItem
            // 
            kToolStripMenuItem.Name = "kToolStripMenuItem";
            kToolStripMenuItem.Size = new Size(224, 29);
            kToolStripMenuItem.Text = "Kiểm tra kết nối máy chủ";
            kToolStripMenuItem.Click += kToolStripMenuItem_Click;
            // 
            // kiểmTraCấuHìnhToolStripMenuItem
            // 
            kiểmTraCấuHìnhToolStripMenuItem.Name = "kiểmTraCấuHìnhToolStripMenuItem";
            kiểmTraCấuHìnhToolStripMenuItem.Size = new Size(164, 29);
            kiểmTraCấuHìnhToolStripMenuItem.Text = "Kiểm tra cấu hình";
            kiểmTraCấuHìnhToolStripMenuItem.Click += kiểmTraCấuHìnhToolStripMenuItem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(GoiYPhacDoBtn);
            groupBox4.Controls.Add(doctorName);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(orderReport);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(editReportBtn);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox2);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(SoBenhAnlst);
            groupBox4.Location = new Point(35, 302);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(1768, 914);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kết quả";
            // 
            // GoiYPhacDoBtn
            // 
            GoiYPhacDoBtn.BackColor = SystemColors.ScrollBar;
            GoiYPhacDoBtn.Enabled = false;
            GoiYPhacDoBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoiYPhacDoBtn.ForeColor = SystemColors.ControlText;
            GoiYPhacDoBtn.Location = new Point(1325, 39);
            GoiYPhacDoBtn.Margin = new Padding(4);
            GoiYPhacDoBtn.Name = "GoiYPhacDoBtn";
            GoiYPhacDoBtn.Size = new Size(210, 54);
            GoiYPhacDoBtn.TabIndex = 9;
            GoiYPhacDoBtn.Text = "Gợi ý phác đồ";
            GoiYPhacDoBtn.UseVisualStyleBackColor = false;
            GoiYPhacDoBtn.Click += GoiYPhacDoBtn_Click;
            // 
            // doctorName
            // 
            doctorName.Location = new Point(1121, 50);
            doctorName.Margin = new Padding(4);
            doctorName.Name = "doctorName";
            doctorName.Size = new Size(196, 31);
            doctorName.TabIndex = 8;
            doctorName.Text = "TsBs. Vũ Trung Kiên";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(915, 54);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(194, 25);
            label19.TabIndex = 7;
            label19.Text = "Bác sỹ tóm tắt bệnh án";
            // 
            // orderReport
            // 
            orderReport.Location = new Point(709, 49);
            orderReport.Margin = new Padding(4);
            orderReport.Name = "orderReport";
            orderReport.Size = new Size(198, 31);
            orderReport.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(520, 48);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(181, 30);
            label7.TabIndex = 5;
            label7.Text = "Nhập số báo cáo:";
            // 
            // editReportBtn
            // 
            editReportBtn.BackColor = SystemColors.ScrollBar;
            editReportBtn.Enabled = false;
            editReportBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editReportBtn.ForeColor = SystemColors.ControlText;
            editReportBtn.Location = new Point(1543, 39);
            editReportBtn.Margin = new Padding(4);
            editReportBtn.Name = "editReportBtn";
            editReportBtn.Size = new Size(209, 54);
            editReportBtn.TabIndex = 3;
            editReportBtn.Text = "Chỉnh sửa tóm tắt";
            editReportBtn.UseVisualStyleBackColor = false;
            editReportBtn.Click += editReportBtn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(tabControl1);
            groupBox6.Location = new Point(14, 362);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(1726, 544);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "TÓM TẮT QUÁ TRÌNH ĐIỀU TRỊ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(11, 28);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1722, 509);
            tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.AutoScroll = true;
            tab1.Controls.Add(TienSuBenhlbl);
            tab1.Controls.Add(TomTatInfolbl);
            tab1.Controls.Add(Lydovaovienlbl);
            tab1.Controls.Add(label13);
            tab1.Location = new Point(4, 34);
            tab1.Margin = new Padding(4);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(4);
            tab1.Size = new Size(1714, 471);
            tab1.TabIndex = 0;
            tab1.Text = "a. Quá trình bệnh lí và diễn biến lâm sàng";
            tab1.UseVisualStyleBackColor = true;
            // 
            // TienSuBenhlbl
            // 
            TienSuBenhlbl.AutoSize = true;
            TienSuBenhlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TienSuBenhlbl.Location = new Point(8, 72);
            TienSuBenhlbl.Margin = new Padding(4, 0, 4, 0);
            TienSuBenhlbl.MaximumSize = new Size(1500, 0);
            TienSuBenhlbl.Name = "TienSuBenhlbl";
            TienSuBenhlbl.Size = new Size(0, 30);
            TienSuBenhlbl.TabIndex = 3;
            // 
            // TomTatInfolbl
            // 
            TomTatInfolbl.AutoSize = true;
            TomTatInfolbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TomTatInfolbl.Location = new Point(9, 41);
            TomTatInfolbl.Margin = new Padding(4, 0, 4, 0);
            TomTatInfolbl.MaximumSize = new Size(1500, 0);
            TomTatInfolbl.Name = "TomTatInfolbl";
            TomTatInfolbl.Size = new Size(0, 30);
            TomTatInfolbl.TabIndex = 2;
            TomTatInfolbl.SizeChanged += TomTatInfolbl_SizeChanged;
            // 
            // Lydovaovienlbl
            // 
            Lydovaovienlbl.AutoSize = true;
            Lydovaovienlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lydovaovienlbl.Location = new Point(174, 10);
            Lydovaovienlbl.Margin = new Padding(4, 0, 4, 0);
            Lydovaovienlbl.Name = "Lydovaovienlbl";
            Lydovaovienlbl.Size = new Size(0, 30);
            Lydovaovienlbl.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(10, 10);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(160, 30);
            label13.TabIndex = 0;
            label13.Text = "Lý do vào viện:";
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.Controls.Add(KQXNlbl);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1714, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "b. Tóm tắt kết quả xét nghiệm cận lâm sàng có giá trị chẩn đoán";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // KQXNlbl
            // 
            KQXNlbl.AutoSize = true;
            KQXNlbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KQXNlbl.Location = new Point(4, 4);
            KQXNlbl.Margin = new Padding(4, 0, 4, 0);
            KQXNlbl.MaximumSize = new Size(1562, 0);
            KQXNlbl.Name = "KQXNlbl";
            KQXNlbl.Size = new Size(0, 30);
            KQXNlbl.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ppDieuTrilbl);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4);
            tabPage3.Size = new Size(1714, 471);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "c. Phương pháp điều trị";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ppDieuTrilbl
            // 
            ppDieuTrilbl.AutoSize = true;
            ppDieuTrilbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ppDieuTrilbl.Location = new Point(0, 4);
            ppDieuTrilbl.Margin = new Padding(4, 0, 4, 0);
            ppDieuTrilbl.Name = "ppDieuTrilbl";
            ppDieuTrilbl.Size = new Size(0, 38);
            ppDieuTrilbl.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.AutoScroll = true;
            tabPage4.Controls.Add(TTNBlbl);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4);
            tabPage4.Size = new Size(1714, 471);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "d. Tình trạng người bệnh ra viện";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // TTNBlbl
            // 
            TTNBlbl.AutoSize = true;
            TTNBlbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TTNBlbl.Location = new Point(8, 0);
            TTNBlbl.Margin = new Padding(4, 0, 4, 0);
            TTNBlbl.MaximumSize = new Size(1562, 0);
            TTNBlbl.Name = "TTNBlbl";
            TTNBlbl.Size = new Size(0, 38);
            TTNBlbl.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox8);
            groupBox5.Controls.Add(groupBox7);
            groupBox5.Location = new Point(478, 101);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(1274, 254);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "CHẨN ĐOÁN";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(BenhPhuICD2);
            groupBox8.Controls.Add(BenhChinhICD2);
            groupBox8.Controls.Add(BenhPhu2);
            groupBox8.Controls.Add(BenhChinh2);
            groupBox8.Controls.Add(label20);
            groupBox8.Controls.Add(label21);
            groupBox8.Controls.Add(label22);
            groupBox8.Controls.Add(label23);
            groupBox8.Location = new Point(605, 32);
            groupBox8.Margin = new Padding(4);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4);
            groupBox8.Size = new Size(596, 218);
            groupBox8.TabIndex = 1;
            groupBox8.TabStop = false;
            groupBox8.Text = "Chẩn đoán ra viện";
            // 
            // BenhPhuICD2
            // 
            BenhPhuICD2.AutoSize = true;
            BenhPhuICD2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhPhuICD2.Location = new Point(174, 184);
            BenhPhuICD2.Margin = new Padding(4, 0, 4, 0);
            BenhPhuICD2.Name = "BenhPhuICD2";
            BenhPhuICD2.Size = new Size(0, 30);
            BenhPhuICD2.TabIndex = 33;
            // 
            // BenhChinhICD2
            // 
            BenhChinhICD2.AutoSize = true;
            BenhChinhICD2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhChinhICD2.Location = new Point(174, 91);
            BenhChinhICD2.Margin = new Padding(4, 0, 4, 0);
            BenhChinhICD2.Name = "BenhChinhICD2";
            BenhChinhICD2.Size = new Size(0, 30);
            BenhChinhICD2.TabIndex = 32;
            // 
            // BenhPhu2
            // 
            BenhPhu2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhPhu2.Location = new Point(174, 125);
            BenhPhu2.Margin = new Padding(4, 0, 4, 0);
            BenhPhu2.Name = "BenhPhu2";
            BenhPhu2.Size = new Size(411, 58);
            BenhPhu2.TabIndex = 31;
            // 
            // BenhChinh2
            // 
            BenhChinh2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhChinh2.Location = new Point(174, 31);
            BenhChinh2.Margin = new Padding(4, 0, 4, 0);
            BenhChinh2.Name = "BenhChinh2";
            BenhChinh2.Size = new Size(411, 58);
            BenhChinh2.TabIndex = 30;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(76, 181);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(88, 30);
            label20.TabIndex = 29;
            label20.Text = "Mã ICD:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(2, 128);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(163, 30);
            label21.TabIndex = 28;
            label21.Text = "Bệnh kèm theo:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(76, 90);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(88, 30);
            label22.TabIndex = 27;
            label22.Text = "Mã ICD:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(41, 30);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(123, 30);
            label23.TabIndex = 26;
            label23.Text = "Bệnh chính:";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(BenhPhuICD1);
            groupBox7.Controls.Add(BenhChinhICD1);
            groupBox7.Controls.Add(BenhPhu1);
            groupBox7.Controls.Add(BenhChinh1);
            groupBox7.Controls.Add(label18);
            groupBox7.Controls.Add(label17);
            groupBox7.Controls.Add(label16);
            groupBox7.Controls.Add(label15);
            groupBox7.Location = new Point(8, 32);
            groupBox7.Margin = new Padding(4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(592, 221);
            groupBox7.TabIndex = 0;
            groupBox7.TabStop = false;
            groupBox7.Text = "Chẩn đoán vào viện";
            // 
            // BenhPhuICD1
            // 
            BenhPhuICD1.AutoSize = true;
            BenhPhuICD1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhPhuICD1.Location = new Point(179, 180);
            BenhPhuICD1.Margin = new Padding(4, 0, 4, 0);
            BenhPhuICD1.Name = "BenhPhuICD1";
            BenhPhuICD1.Size = new Size(0, 30);
            BenhPhuICD1.TabIndex = 27;
            // 
            // BenhChinhICD1
            // 
            BenhChinhICD1.AutoSize = true;
            BenhChinhICD1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhChinhICD1.Location = new Point(179, 91);
            BenhChinhICD1.Margin = new Padding(4, 0, 4, 0);
            BenhChinhICD1.Name = "BenhChinhICD1";
            BenhChinhICD1.Size = new Size(0, 30);
            BenhChinhICD1.TabIndex = 26;
            // 
            // BenhPhu1
            // 
            BenhPhu1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhPhu1.Location = new Point(179, 124);
            BenhPhu1.Margin = new Padding(4, 0, 4, 0);
            BenhPhu1.Name = "BenhPhu1";
            BenhPhu1.Size = new Size(411, 58);
            BenhPhu1.TabIndex = 25;
            // 
            // BenhChinh1
            // 
            BenhChinh1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BenhChinh1.Location = new Point(179, 30);
            BenhChinh1.Margin = new Padding(4, 0, 4, 0);
            BenhChinh1.Name = "BenhChinh1";
            BenhChinh1.Size = new Size(411, 58);
            BenhChinh1.TabIndex = 24;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(81, 180);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(88, 30);
            label18.TabIndex = 23;
            label18.Text = "Mã ICD:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(8, 124);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(163, 30);
            label17.TabIndex = 22;
            label17.Text = "Bệnh kèm theo:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(81, 89);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(88, 30);
            label16.TabIndex = 21;
            label16.Text = "Mã ICD:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(46, 30);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(123, 30);
            label15.TabIndex = 20;
            label15.Text = "Bệnh chính:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DayOutlbl);
            groupBox2.Controls.Add(DayInlbl);
            groupBox2.Controls.Add(MaYTeRs);
            groupBox2.Controls.Add(SoBenhAnRs);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(14, 101);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(442, 254);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "HÀNH CHÍNH";
            // 
            // DayOutlbl
            // 
            DayOutlbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayOutlbl.Location = new Point(172, 190);
            DayOutlbl.Margin = new Padding(4, 0, 4, 0);
            DayOutlbl.Name = "DayOutlbl";
            DayOutlbl.Size = new Size(224, 60);
            DayOutlbl.TabIndex = 19;
            // 
            // DayInlbl
            // 
            DayInlbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayInlbl.Location = new Point(172, 121);
            DayInlbl.Margin = new Padding(4, 0, 4, 0);
            DayInlbl.Name = "DayInlbl";
            DayInlbl.Size = new Size(224, 60);
            DayInlbl.TabIndex = 18;
            // 
            // MaYTeRs
            // 
            MaYTeRs.AutoSize = true;
            MaYTeRs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaYTeRs.Location = new Point(172, 76);
            MaYTeRs.Margin = new Padding(4, 0, 4, 0);
            MaYTeRs.Name = "MaYTeRs";
            MaYTeRs.Size = new Size(0, 30);
            MaYTeRs.TabIndex = 17;
            // 
            // SoBenhAnRs
            // 
            SoBenhAnRs.AutoSize = true;
            SoBenhAnRs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoBenhAnRs.Location = new Point(172, 32);
            SoBenhAnRs.Margin = new Padding(4, 0, 4, 0);
            SoBenhAnRs.Name = "SoBenhAnRs";
            SoBenhAnRs.Size = new Size(0, 30);
            SoBenhAnRs.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 190);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(140, 30);
            label12.TabIndex = 15;
            label12.Text = "Ra viện ngày:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(11, 121);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(151, 30);
            label11.TabIndex = 14;
            label11.Text = "Vào viện ngày:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(74, 76);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(90, 30);
            label10.TabIndex = 13;
            label10.Text = "Mã y tế:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 50);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(221, 25);
            label5.TabIndex = 1;
            label5.Text = "Chọn số bệnh án cần xem:";
            // 
            // SoBenhAnlst
            // 
            SoBenhAnlst.DropDownStyle = ComboBoxStyle.DropDownList;
            SoBenhAnlst.Enabled = false;
            SoBenhAnlst.FormattingEnabled = true;
            SoBenhAnlst.Location = new Point(248, 46);
            SoBenhAnlst.Margin = new Padding(4);
            SoBenhAnlst.Name = "SoBenhAnlst";
            SoBenhAnlst.Size = new Size(264, 33);
            SoBenhAnlst.TabIndex = 0;
            SoBenhAnlst.SelectionChangeCommitted += SoBenhAnlst_SelectionChangeCommitted;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1828, 1220);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximumSize = new Size(1850, 1276);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tóm tắt hồ sơ bệnh án";
            FormClosed += MainForm_FormClosed;
            KeyDown += MainForm_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kiểmTraCậpNhậtToolStripMenuItem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private CheckBox MaYTe_checkbox;
        private CheckBox SoBenhAn_checkbox;
        private Button TomTat_btn;
        private TextBox SoBenhAn_input;
        private TextBox MaYTe_input;
        private TextBox BN_bhyt;
        private TextBox BN_name;
        private Label label8;
        private Label label4;
        private ToolStripMenuItem kToolStripMenuItem;
        public Label server_status;
        private TextBox usage_txb;
        private TextBox department_txb;
        private TextBox user_txb;
        private GroupBox groupBox4;
        private Label label5;
        private ComboBox SoBenhAnlst;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label DayOutlbl;
        private Label DayInlbl;
        private Label MaYTeRs;
        private Label SoBenhAnRs;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label BenhChinh1;
        private Label BenhPhu2;
        private Label BenhChinh2;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label BenhChinhICD1;
        private Label BenhPhu1;
        private Label BenhPhuICD2;
        private Label BenhChinhICD2;
        private Label BenhPhuICD1;
        private TabControl tabControl1;
        private TabPage tab1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label Lydovaovienlbl;
        private Label label13;
        private Label TomTatInfolbl;
        private Label KQXNlbl;
        private Button editReportBtn;
        private Label TTNBlbl;
        private Label TienSuBenhlbl;
        private Label ppDieuTrilbl;
        private TextBox orderReport;
        private Label label7;
        private TextBox CCCDtxb;
        private Label label14;
        private TextBox doctorName;
        private Label label19;
        private ToolStripMenuItem kiểmTraCấuHìnhToolStripMenuItem;
        private Button GoiYPhacDoBtn;
    }
}

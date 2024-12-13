using BUS_;
using BUS_.MainLogic;
using Services;
using System.Diagnostics;
using System.Reflection;
using UI.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private static MainForm instance;

        // Hàm khởi tạo các sự kiện khi load form
        private MainForm()
        {
            InitializeComponent();
            try
            {
                ReadFileEnv.Instance.ReadConfig_file();

            }
            catch (ServicesErr ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Load += async (s, e) => await UpdateUI.Instance.Mainform_load(server_status, ReadFileEnv.Instance.envData);
            this.Load += async (s, e) => await UpdateUI.Instance.PrintUserData(user_txb, department_txb, usage_txb);
            this.KeyPreview = true;
        }
        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm();
                }
                return instance;
            }
        }

        private LoginForm loginForm;

        #region Các hàm sử lý UI chỉ để người dùng chọn số bệnh án hoặc mã y tế
        // Hàm check Mã y tế đầu vào
        private void MaYTe_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            switch (MaYTe_checkbox.CheckState)
            {
                case CheckState.Checked:
                    MaYTe_input.Enabled = true;
                    SoBenhAn_checkbox.Enabled = false;
                    SoBenhAn_input.Clear();
                    break;
                case CheckState.Unchecked:
                    MaYTe_input.Enabled = false;
                    SoBenhAn_checkbox.Enabled = true;
                    MaYTe_input.Clear();
                    break;
            }

        }
        private void MaYTe_input_Enter(object sender, EventArgs e)
        {
            MaYTe_input.Clear();
        }

        // Hàm check Số bệnh án đầu vào
        private void SoBenhAn_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            switch (SoBenhAn_checkbox.CheckState)
            {
                case CheckState.Checked:
                    SoBenhAn_input.Enabled = true;
                    MaYTe_checkbox.Enabled = false;
                    MaYTe_input.Clear();
                    break;
                case CheckState.Unchecked:
                    SoBenhAn_input.Enabled = false;
                    MaYTe_checkbox.Enabled = true;
                    SoBenhAn_input.Clear();
                    break;
            }
        }
        private void SoBenhAn_input_Enter(object sender, EventArgs e)
        {
            SoBenhAn_input.Clear();
        }

        public void SetLoginForm(LoginForm loginForm)
        {
            this.loginForm = loginForm;
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Các hàm xử lý chức năng khi người dùng tương tác với UI
        private async void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await UpdateUI.Instance.Mainform_load(server_status, ReadFileEnv.Instance.envData);
        }

        // Hàm xử lý sự kiện click button tóm tắt
        private async void TomTat_btn_Click(object sender, EventArgs e)
        {
            UpdateUI.Instance.AllData.Clear();

            // xử lý số bệnh án
            if (SoBenhAn_checkbox.Checked)
            {
                if (ValidateInput.Instance.ValidateInputData(SoBenhAn_input.Name, SoBenhAn_input.Text))
                {
                    Lydovaovienlbl.Text = string.Empty;
                    TomTatInfolbl.Text = string.Empty;
                    KQXNlbl.Text = string.Empty;
                    TTNBlbl.Text = string.Empty;
                    TienSuBenhlbl.Text = string.Empty;
                    ppDieuTrilbl.Text = string.Empty;
                    SoBenhAnlst.Enabled = false;
                    using (WaitForm waitform = WaitForm.Instance)
                    {
                        try
                        {
                            waitform.Show();
                            editReportBtn.Enabled = false;
                            UpdateUI.Instance.PrintPatientData(BN_name, BN_bhyt, SoBenhAn_input.Text);
                            UpdateUI.Instance.PrintHanhChinh(SoBenhAnRs, MaYTeRs, DayInlbl, DayOutlbl, SoBenhAn_input.Text);
                            UpdateUI.Instance.PrintChanDoan(BenhChinh1, BenhPhu1,
                                                            BenhChinhICD1, BenhPhuICD1,
                                                            BenhChinh2, BenhPhu2,
                                                            BenhChinhICD2, BenhPhuICD2,
                                                            SoBenhAn_input.Text);
                            // Chạy các tác vụ nặng trên luồng nền
                            await Task.Run(async () =>
                            {
                                await UpdateUI.Instance.PrintBenhAnType(SoBenhAn_input.Text, TomTatInfolbl, Lydovaovienlbl, TienSuBenhlbl, ppDieuTrilbl);
                                await UpdateUI.Instance.PrintKetQuaXetNghiemCLS(SoBenhAn_input.Text, BenhChinh2.Text, KQXNlbl);
                                await UpdateUI.Instance.PrintTinhTrangNguoiBenh(SoBenhAn_input.Text, TTNBlbl);
                            });
                            if (await UpdateUsage.Instance.UpdateUsage_user(LoginForm.Instance.userName, LoginForm.Instance.userDepartment, LoginForm.Instance.empCode))
                            {
                                await UpdateUI.Instance.PrintUserData(user_txb, department_txb, usage_txb);
                            }
                            editReportBtn.Enabled = true;
                            waitform.Close();
                        }
                        catch (Exception ex)
                        {
                            waitform.Close();
                            MessageBox.Show("Lỗi tại hàm Main: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số bệnh án không hợp lệ, vui lòng nhập lại!!!");
                }
            }
            // xử lý mã y tế
            else if (MaYTe_checkbox.Checked)
            {
                if (ValidateInput.Instance.ValidateInputData(MaYTe_input.Name, MaYTe_input.Text))
                {
                    UpdateUI.Instance.PrintlistSoBenhAn(MaYTe_input.Text, SoBenhAnlst);
                    if (SoBenhAnlst.Items.Count > 0)
                    {
                        SoBenhAnlst.SelectedIndex = 0; // Chọn phần tử đầu tiên (index = 0)
                    }
                    SoBenhAnlst.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã Y Tế không hợp lệ!!!");
                }
            }
        }

        // Hàm xử lý sự kiện chọn số bệnh án
        private async void SoBenhAnlst_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateUI.Instance.AllData.Clear();
            Lydovaovienlbl.Text = string.Empty;
            TomTatInfolbl.Text = string.Empty;
            KQXNlbl.Text = string.Empty;
            TTNBlbl.Text = string.Empty;
            TienSuBenhlbl.Text = string.Empty;
            ppDieuTrilbl.Text = string.Empty;
            using (WaitForm waitform = WaitForm.Instance)
            {
                waitform.Show();
                try
                {
                    editReportBtn.Enabled = false;
                    UpdateUI.Instance.PrintPatientData(BN_name, BN_bhyt, SoBenhAnlst.SelectedItem.ToString());
                    UpdateUI.Instance.PrintHanhChinh(SoBenhAnRs, MaYTeRs, DayInlbl, DayOutlbl, SoBenhAnlst.SelectedItem.ToString());
                    UpdateUI.Instance.PrintChanDoan(BenhChinh1, BenhPhu1,
                                                    BenhChinhICD1, BenhPhuICD1,
                                                    BenhChinh2, BenhPhu2,
                                                    BenhChinhICD2, BenhPhuICD2,
                                                    SoBenhAnlst.SelectedItem.ToString());
                    await UpdateUI.Instance.PrintBenhAnType(SoBenhAnlst.SelectedItem.ToString(), TomTatInfolbl, Lydovaovienlbl, TienSuBenhlbl, ppDieuTrilbl);
                    await UpdateUI.Instance.PrintKetQuaXetNghiemCLS(SoBenhAnlst.SelectedItem.ToString(), BenhChinh2.Text, KQXNlbl);
                    await UpdateUI.Instance.PrintTinhTrangNguoiBenh(SoBenhAnlst.SelectedItem.ToString(), TTNBlbl);
                    if (await UpdateUsage.Instance.UpdateUsage_user(LoginForm.Instance.userName, LoginForm.Instance.userDepartment, LoginForm.Instance.empCode))
                    {
                        await UpdateUI.Instance.PrintUserData(user_txb, department_txb, usage_txb);
                    }
                    editReportBtn.Enabled = true;
                    waitform.Close();
                }
                catch (Exception ex)
                {
                    waitform.Close();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }

        //Hàm xử lý sự kiện ấn vào nút xuất file word
        private void editReportBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                DateTime now = DateTime.Now;
                string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string filePath = Path.Combine(currentDirectory, "TemplateTomTat.doc");
                UpdateUI.Instance.AllData["BN_orderReport"] = orderReport.Text;
                UpdateUI.Instance.AllData["BN_CCCD"] = CCCDtxb.Text;
                UpdateUI.Instance.AllData["DoctorName"] = doctorName.Text;
                UpdateUI.Instance.AllData["DateTime"] = $"Ngày {now.Day} tháng {now.Month} năm {now.Year}";
                ReportEditor.Instance.GenFileAndPrintData(filePath, UpdateUI.Instance.AllData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại hàm in bản báo cáo: " + ex.Message);
            }
        }

        //Hàm responsivw
        private void TomTatInfolbl_SizeChanged(object sender, EventArgs e)
        {
            TienSuBenhlbl.Location = new Point(TomTatInfolbl.Location.X, TomTatInfolbl.Location.Y + TomTatInfolbl.Height + 5);
        }
        #endregion

        #region Hàm kiểm tra thông tin phiên bản ứng dụng
        //Hàm kiểm tra thông tin cập nhật và tiến hành cập nhật ứng dụng
        private string UpdateURL = "http://api-hospital.zigisoft.com/api/version/check";
        private async void kiểmTraCậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var waitForm = WaitForm.Instance; // Lấy instance

            try
            {
                waitForm.ShowForm(); // Hiển thị form mà không dispose

                // Lấy phiên bản hiện tại của ứng dụng
                string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                // Kiểm tra cập nhật
                string updateUrl = await CheckUpdate.Instance.CheckForUpdate(currentVersion, UpdateURL);

                waitForm.CloseForm(); // Ẩn form sau khi hoàn thành kiểm tra

                if (!string.IsNullOrEmpty(updateUrl))
                {
                    // Hiển thị thông báo nếu có bản cập nhật mới
                    DialogResult result = MessageBox.Show(
                        "Phiên bản mới đang có sẵn. Bạn có muốn tải và cài đặt không?",
                        "Cập nhật",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.Yes)
                    {
                        waitForm.ShowForm(); // Hiển thị lại nếu cần tải xuống
                        string downloadedFile = await CheckUpdate.Instance.DownloadAndOpenAsync(updateUrl);
                        waitForm.CloseForm(); // Đóng lại form sau khi tải
                        MessageBox.Show($"Đã tải tệp về: {downloadedFile}");

                        if (System.IO.File.Exists(downloadedFile))
                        {
                            Process.Start("explorer.exe", $"/select,\"{downloadedFile}\"");
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("File cập nhật không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hiện không có bản cài đặt nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                waitForm.CloseForm(); // Đảm bảo form được đóng trong mọi trường hợp
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TomTat_btn.PerformClick();
            }
        }
        #endregion

        
    }
}

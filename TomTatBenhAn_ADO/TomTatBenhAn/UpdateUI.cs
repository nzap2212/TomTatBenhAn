using BUS_;
using BUS_.MainLogic;
using BUS_.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using RestSharp;
using UI.Forms;
using BUS_.ObjectBUS;
using DTO;
using Sprache;

namespace UI
{
    public class UpdateUI
    {
        private static UpdateUI instance;
        public static UpdateUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UpdateUI();
                }
                return instance;
            }
        }
        private UpdateUI() { }

        public Dictionary<string, string> AllData = new Dictionary<string, string>();

        //Hàm khởi tạo các sự kiện khi load form
        public async Task Mainform_load(Label server_status, Dictionary<string, string> envData)
        {
            try
            {
                await GetServerStatus.Instance.get_server_status(envData);
                if (GetServerStatus.Instance.IsConnected)
                {
                    MessageBox.Show("Kết nối thành công");
                    server_status.Text = "Đã kết nối thành công";
                    server_status.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại");
                    server_status.Text = "Chưa kết nối";
                    server_status.ForeColor = Color.Red;
                    Application.Exit();
                }
            }
            catch (GetStatusErr ex)
            {
                server_status.Text = "Chưa kết nối";
                server_status.ForeColor = Color.Red;
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        //Hàm in thông tin người sử dụng
        public async Task PrintUserData(TextBox userName, TextBox userDepartment, TextBox userUsage)
        {
            try
            {
                userUsage.Text = await HandleLogin.Instance.printUserUsage
                    (
                    LoginForm.Instance.userName, 
                    LoginForm.Instance.userDepartment,
                    LoginForm.Instance.empCode
                    );
                userName.Text = LoginForm.Instance.userName.ToUpper();
                userDepartment.Text = LoginForm.Instance.userDepartment.ToUpper();
            }
            catch (GetStatusErr ex)
            {
                MessageBox.Show($"Lỗi tại hàm PrintUserData: {ex.Message}");
            }
        }

        //Hàm in thông tin bệnh nhân
        public void PrintPatientData(TextBox BN_name, TextBox BN_bhyt, string ID)
        {
            try
            {
                BenhNhanBUS benhNhanBUS = new BenhNhanBUS();
                List<BenhNhanDTO> benhNhan = benhNhanBUS.GetBenhNhanBUS(ID);
                BN_name.Text = benhNhan[0].Name;
                BN_bhyt.Text = benhNhan[0].Bhyt;
                AllData.Add("BN_Name", benhNhan[0].Name);
                AllData.Add("BN_Bd", benhNhan[0].NgaySinh);
                AllData.Add("BN_Age", benhNhan[0].Tuoi);
                AllData.Add("BN_Sex", benhNhan[0].Sex);
                AllData.Add("BN_Addr", benhNhan[0].Address);
                AllData.Add("BN_Bhyt", benhNhan[0].Bhyt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại hàm PrintPatientData: " + ex.Message);
            }
        }

        // Hàm in thông tin chẩn đoán
        public void PrintChanDoan(Label BenhChinh1, Label BenhPhu1,
                                  Label ICDBenhChinh1, Label ICDBenhPhu1,
                                  Label BenhChinh2, Label BenhPhu2,
                                  Label ICDBenhChinh2, Label ICDBenhPhu2,
                                  string ID)
        {
            try
            {
                ChanDoanVaoVienBUS chanDoanVaoVienBUS = new ChanDoanVaoVienBUS();
                ChanDoanRaVienBUS chanDoanRaVienBUS = new ChanDoanRaVienBUS();

                List<ChanDoanVaoVienDTO> chanDoanVaoVien = chanDoanVaoVienBUS.GetChanDoanVaoVien(ID);
                List<ChanDoanRaVienDTO> chanDoanRaVien = chanDoanRaVienBUS.GetChanDoanRaVien(ID);

                BenhChinh1.Text = chanDoanVaoVien[0].BenhChinh;
                BenhPhu1.Text = chanDoanVaoVien[0].BenhPhu;
                ICDBenhChinh1.Text = chanDoanVaoVien[0].ICDBenhChinh;
                ICDBenhPhu1.Text = chanDoanVaoVien[0].ICDBenhPhu;

                BenhChinh2.Text = chanDoanRaVien[0].BenhChinh;
                BenhPhu2.Text = chanDoanRaVien[0].BenhPhu;
                ICDBenhChinh2.Text = chanDoanRaVien[0].ICDBenhChinh;
                ICDBenhPhu2.Text = chanDoanRaVien[0].ICDBenhPhu;

                AllData.Add("BN_ChanDoanBenhChinhVao", chanDoanVaoVien[0].BenhChinh);
                AllData.Add("BN_ICDBenhChinhVao", chanDoanVaoVien[0].ICDBenhChinh);
                AllData.Add("BN_ChanDoanBenhPhuVao", chanDoanVaoVien[0].BenhPhu);
                AllData.Add("BN_ICDBenhPhuVao", chanDoanVaoVien[0].ICDBenhPhu);

                AllData.Add("BN_ChanDoanBenhChinhRa", chanDoanRaVien[0].BenhChinh);
                AllData.Add("BN_ICDBenhChinhRa", chanDoanRaVien[0].ICDBenhChinh);
                AllData.Add("BN_ChanDoanBenhPhuRa", chanDoanRaVien[0].BenhPhu);
                AllData.Add("BN_ICDBenhPhuRa", chanDoanRaVien[0].ICDBenhPhu);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại hàm PrintChanDoan: " + ex.Message);
            }
        }

        //Hàm in thông tin hành chính
        public void PrintHanhChinh(Label SoBenhAn, Label MaYTe, Label NgayVaoVien, Label NgayRaVien, string ID)
        {
            try
            {
                HanhChinhBUS hanhChinhBus = new HanhChinhBUS();
                List<HanhChinhDTO> hanhchinh = hanhChinhBus.GetHanhChinh(ID);
                SoBenhAn.Text = hanhchinh[0].SoBenhAn;
                MaYTe.Text = hanhchinh[0].MaYte;
                NgayVaoVien.Text = hanhchinh[0].NgayVaoVien;
                NgayRaVien.Text = hanhchinh[0].NgayRaVien;

                AllData.Add("BN_SoBenhAn", hanhchinh[0].SoBenhAn);
                AllData.Add("BN_MaYTe", hanhchinh[0].MaYte);
                AllData.Add("BN_NgayVaoVien", hanhchinh[0].NgayVaoVien);
                AllData.Add("BN_NgayRaVien", hanhchinh[0].NgayRaVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại hàm PrintHanhChinh: " + ex.Message);
            }
        }

        //Hàm in thông tin kết quả xét nghiệm cls có giá trị chẩn đoán
        public async Task PrintKetQuaXetNghiemCLS(string ID, string ChanDoanChinh, Label KQXNlbl)
        {
            try
            {
                string a = await AskAIa.Instance.TomTatKetQuaXN(ID, ChanDoanChinh);
                if (KQXNlbl.InvokeRequired)
                {
                    KQXNlbl.Invoke((MethodInvoker)(() =>
                    {
                        KQXNlbl.Text = a;
                    }));
                }
                else
                {
                    KQXNlbl.Text = a;
                }
                AllData.Add("BN_KetQuaXetNghiem", a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại hàm PrintKetQuaXetNghiem: " + ex.Message);
            }
        }

        //Hàm in thông tin tình trạng người bệnh ra viện
        public async Task PrintTinhTrangNguoiBenh(string ID, Label TinhTrangNguoiBenh)
        {
            try
            {
                string a = await AskAIa.Instance.TomTatTTNBRaVien(ID);

                if (TinhTrangNguoiBenh.InvokeRequired)
                {
                    TinhTrangNguoiBenh.Invoke((MethodInvoker)(() =>
                    {
                        TinhTrangNguoiBenh.Text = a;
                    }));
                }
                else
                {
                    TinhTrangNguoiBenh.Text = a;
                }
                AllData.Add("BN_TTNguoiBenhRaVien", a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tại hàm PrintTinhTrangNguoiBenh: " + ex.Message);
            }
        }

        //Hàm in danh sách số bệnh án của mã y tế
        public void PrintlistSoBenhAn(string ID, ComboBox ListBox)
        {
            ListBox.Items.Clear();
            SoBenhAnBUS soBenhAnBus = new SoBenhAnBUS();
            List<SoBenhAnDTO> lstSoBenhAn = soBenhAnBus.GetSoBenhAn(ID);
            foreach (var item in lstSoBenhAn)
            {
                ListBox.Items.Add(item.SoBenhAn);
            }
        }

        public async Task PrintBenhAnType(string ID, Label TomTatlbl, Label LyDoVaoVien, Label TienSuBenh, Label ppDieuTri)
        {
            var result = await CheckBenhAnType.Instance.CheckBenhAn(ID);
            if (result is bool isfalse && !isfalse)
            {
                MessageBox.Show("Loại bệnh án này chưa hỗ trợ tóm tắt, tính năng này sẽ được cập nhật trong tương lai!!");
            }
            else
            {
                var result_data = (Dictionary<string, string>)result;
                // lý do vào viện
                if (LyDoVaoVien.InvokeRequired)
                {
                    LyDoVaoVien.Invoke((MethodInvoker)(() =>
                    {
                        LyDoVaoVien.Text = result_data["lyDoVaoVien"];
                    }));
                }
                else
                {
                    LyDoVaoVien.Text = result_data["lyDoVaoVien"];
                }

                // tóm tắt quá trình bệnh lý và dấu hiệu lâm sàng
                if (TomTatlbl.InvokeRequired)
                {
                    TomTatlbl.Invoke((MethodInvoker)(() =>
                    {
                        TomTatlbl.Text = result_data["quaTrinhBenhLy"];
                    }));
                }
                else
                {
                    TomTatlbl.Text = result_data["quaTrinhBenhLy"];
                }

                // tiền sử bệnh
                if (TienSuBenh.InvokeRequired)
                {
                    TienSuBenh.Invoke((MethodInvoker)(() =>
                    {
                        TienSuBenh.Text = "Tiền sử bệnh: " + result_data["tienSuBenh"];
                    }));
                }
                else
                {
                    TienSuBenh.Text = "Tiền sử bệnh: " + result_data["tienSuBenh"];
                }

                // phương pháp điều trị
                if (ppDieuTri.InvokeRequired)
                {
                    ppDieuTri.Invoke((MethodInvoker)(() =>
                    {
                        ppDieuTri.Text = "Phương pháp điều trị: " + result_data["phuongPhapDieuTri"];
                    }));
                }
                else
                {
                    ppDieuTri.Text = "Phương pháp điều trị: " + result_data["phuongPhapDieuTri"];
                }

                string input = result_data["quaTrinhBenhLy"];
                string start = "Quá trình bệnh lý và diễn biến lâm sàng:";
                string end = "Những dấu hiệu lâm sàng chính:";

                int startIndex = input.IndexOf(start) + start.Length; // Vị trí bắt đầu
                int endIndex = input.IndexOf(end); // Vị trí kết thúc

                if (startIndex >= 0 && endIndex > startIndex)
                {
                    string qtbl = input.Substring(startIndex, endIndex - startIndex).Trim();
                    AllData.Add("BN_TomTatQuaTrinhBenhLy", qtbl);
                }
                if (endIndex >= 0)
                {
                    int contentStartIndex = endIndex + end.Length; // Bỏ qua tiêu đề
                    string dhls = input.Substring(contentStartIndex).Trim();
                    AllData.Add("BN_DauHieuLamSang", dhls);
                }


                AllData.Add("BN_LyDoVaoVien", result_data["lyDoVaoVien"]);
                AllData.Add("BN_TienSuBenh", result_data["tienSuBenh"]);
                AllData.Add("BN_PPDT", result_data["phuongPhapDieuTri"]);
            }
        }


    }
}

using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_.ObjectDAL
{
    public class KetQuaXetNghiemclsDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<KetQuaXetNghiemclsDTO> GetKetQuaXetNghiemInfo(string ID)
        {
            List<KetQuaXetNghiemclsDTO> ketQuaXetNghiemLst = new List<KetQuaXetNghiemclsDTO> ();
            string query = @$"SELECT 
                              ndv.TenNhomDichVu, 
                              clsyc.NoiDungChiTiet, 
                              pb.TenPhongBan, 
                              dv.TenDichVu,
                              clskqct.KetQua,
                              clskqct.MucBinhThuong,
                              clskqct.MucBinhThuongMin,
                              clskqct.MucBinhThuongMax,
                              clskqct.BatThuong,
                              clskq.ThoiGianThucHien,
                              clskq.KetLuan,
                              clskq.MoTa_Text
                            FROM 
                              dbo.CLSYeuCau clsyc 
                              LEFT JOIN ehosdict.DM_NhomDichVu ndv ON clsyc.NhomDichVu_Id = ndv.NhomDichVu_Id 
                              LEFT JOIN dbo.CLSKetQua clskq ON clsyc.CLSYeuCau_Id = clskq.CLSYeuCau_Id 
                              LEFT JOIN ehosdict.DM_PhongBan pb ON clsyc.NoiYeuCau_Id = pb.PhongBan_Id 
                              LEFT JOIN dbo.CLSKetQuaChiTiet clskqct ON clskq.CLSKetQua_Id = clskqct.CLSKetQua_Id 
                              LEFT JOIN ehosdict.DM_DichVu dv ON clskqct.DichVu_Id = dv.DichVu_Id
                            WHERE 
                              clsyc.BenhAn_Id = (
                                SELECT 
                                  benhan_id 
                                FROM 
                                  benhan 
                                WHERE 
                                  SoBenhAn = '{ID}'
                              ) 
                              AND clskq.CLSKetQua_Id IS NOT NULL 
                              AND (clskqct.BatThuong = 1 OR clskq.PhanLoaiKetQua_Id IS NOT NULL OR (clskqct.MucBinhThuong is null and clskqct.MucBinhThuongMin is null and clskqct.MucBinhThuongMax is null and clskqct.KetQua is not null))
                            ORDER BY 
                              clskq.ThoiGianThucHien desc";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows) // Kiểm tra nếu không có kết quả
                    {
                        // Log hoặc xử lý thêm nếu cần
                        return new List<KetQuaXetNghiemclsDTO>(); // Trả về danh sách rỗng
                    }
                    while (reader.Read())
                    {
                        ketQuaXetNghiemLst.Add(new KetQuaXetNghiemclsDTO()
                        {
                            NhomDichVu = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin",
                            NoiDungChiTiet = !reader.IsDBNull(1) ? reader.GetString(1) : "Không có thông tin",
                            TenPhongBan = !reader.IsDBNull(2) ? reader.GetString(2) : "Không có thông tin",
                            DichVu = !reader.IsDBNull(3) ? reader.GetString(3) : "Không có thông tin",
                            KetQua = !reader.IsDBNull(4) ? reader.GetString(4) : "Không có thông tin",
                            MucBinhThuong = !reader.IsDBNull(5) ? reader.GetString(5) : "Không có thông tin",
                            MucBinhThuongMin = !reader.IsDBNull(6) ? reader.GetString(6) : "Không có thông tin",
                            MucBinhThuongMax = !reader.IsDBNull(7) ? reader.GetString(7) : "Không có thông tin",
                            BatThuong = !reader.IsDBNull(8) ? reader.GetBoolean(8).ToString() : "Không có thông tin",
                            ThoiGianThucHien = !reader.IsDBNull(9) ? reader.GetDateTime(9).ToString() : "Không có thông tin",
                            KetLuan = !reader.IsDBNull(10) ? reader.GetString(10) : "Không có thông tin",
                            MoTa = !reader.IsDBNull(11) ? reader.GetString(11) : "Không có thông tin",
                        });
                    }
                }
            return ketQuaXetNghiemLst;
        }
    }
}

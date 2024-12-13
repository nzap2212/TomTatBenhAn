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
    public class TinhTrangNguoiBenhRaVienDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<TinhTrangNguoiBenhRaVienDTO> GetTinhTrangNguoiBenhRaVienInfo(string ID)
        {
            List<TinhTrangNguoiBenhRaVienDTO> tinhTrangNguoiBenhRaVien = new List<TinhTrangNguoiBenhRaVienDTO>();
            string query = $@"SELECT 
  TOP 2 ntkb.DienBien, 
  bact.LoiDanThayThuoc 
FROM 
  dbo.NoiTru_KhamBenh ntkb 
  LEFT JOIN dbo.BenhAnChiTiet bact ON ntkb.BenhAn_Id = bact.BenhAn_Id 
WHERE 
  ntkb.BenhAn_Id = (
    SELECT 
      BenhAn_Id 
    FROM 
      dbo.BenhAn 
    WHERE 
      SoBenhAn = '{ID}'
  ) 
  AND DienBien IS NOT NULL 
ORDER BY 
  ThoiGianKham DESC
";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tinhTrangNguoiBenhRaVien.Add(new TinhTrangNguoiBenhRaVienDTO()
                    {
                        DienBien = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin",
                        LoiDanThayThuoc = !reader.IsDBNull(1) ? reader.GetString(1) : "Không có thông tin",
                    });
                }
            }
            return tinhTrangNguoiBenhRaVien;
        }
    }
}

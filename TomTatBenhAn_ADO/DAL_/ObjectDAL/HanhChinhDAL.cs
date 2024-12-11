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
    public class HanhChinhDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<HanhChinhDTO> GetHanhChinhInfo(string ID)
        {
            List<HanhChinhDTO> HanhChinh = new List<HanhChinhDTO> ();
            string query = @$"SELECT 
                              ba.SoBenhAn SoBenhAn, 
                              dmbn.SoVaoVien SoVaoVien, 
                              CAST(DATEPART(HOUR,ba.ThoiGianVaoVien) AS NVARCHAR(MAX)) + N' giờ ' +
	                            CAST(DATEPART(MINUTE, ba.ThoiGianVaoVien) AS NVARCHAR(MAX)) + N', ngày ' +
	                            CAST(DAY(ba.ThoiGianVaoVien) AS NVARCHAR(MAX)) + N' tháng ' +
	                            CAST(MONTH(ba.ThoiGianVaoVien) AS NVARCHAR(MAX)) + N' năm ' +
	                            CAST(YEAR(ba.ThoiGianVaoVien) AS NVARCHAR(MAX)) AS ThoiGianVaoVien, 

                              CAST(DATEPART(HOUR,ba.ThoiGianRaVien) AS NVARCHAR(MAX)) + N' giờ ' +
	                            CAST(DATEPART(MINUTE, ba.ThoiGianRaVien) AS NVARCHAR(MAX)) + N', ngày ' +
	                            CAST(DAY(ba.ThoiGianRaVien) AS NVARCHAR(MAX)) + N' tháng ' +
	                            CAST(MONTH(ba.ThoiGianRaVien) AS NVARCHAR(MAX)) + N' năm ' +
	                            CAST(YEAR(ba.ThoiGianRaVien) AS NVARCHAR(MAX)) AS ThoiGianRaVien,
	                            td.Dictionary_Name KetQuaDieuTri
                            FROM 
                              dbo.BenhAn ba 
                              LEFT JOIN ehosdict.DM_BenhNhan dmbn ON ba.BenhNhan_Id = dmbn.BenhNhan_Id 
                              LEFT JOIN ehosdict.Lst_Dictionary td ON ba.KetQuaDieuTri_Id = td.Dictionary_Id
                            WHERE 
                              ba.SoBenhAn = N'{ID}'";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    HanhChinh.Add(new HanhChinhDTO(){
                        SoBenhAn = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin",
                        MaYte = !reader.IsDBNull(1) ? reader.GetString(1) : "Không có thông tin",
                        NgayVaoVien = !reader.IsDBNull(2) ? reader.GetString(2) : "Không có thông tin",
                        NgayRaVien = !reader.IsDBNull(3) ? reader.GetString(3) : "Không có thông tin",
                        KetQuaDieuTri = !reader.IsDBNull(4) ? reader.GetString(4) : "Chưa xác định"
                    });
                }
            }

            return HanhChinh;
        }
    }
}

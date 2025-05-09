﻿using Services;
using DTO;
using System.Data.SqlClient;

namespace DAL_.ObjectDAL
{
    public class BenhNhanDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<BenhNhanDTO> GetBenhNhan(string ID)
        {
            List<BenhNhanDTO> benhnhan = new List<BenhNhanDTO>();
            string query = @$"SELECT 
	                            dmbn.TenBenhNhan TenBN, 
	                            CONVERT(VARCHAR,dmbn.NgaySinh,103)  NgaySinh,
	                            (YEAR(GETDATE()) - dmbn.NamSinh) Tuoi,
	                            dmbn.GioiTinh GioiTinh,
	                            dmbn.DiaChi DiaChi,
	                            SUBSTRING(xncp.SoBHYT,0, 16) SoBHYT,
	                            td.Dictionary_Name DanToc
                            FROM dbo.BenhAn ba
                            LEFT JOIN dbo.XacNhanChiPhi xncp ON ba.BenhAn_Id = xncp.BenhAn_Id
                            LEFT JOIN ehosdict.DM_BenhNhan dmbn ON ba.BenhNhan_Id = dmbn.BenhNhan_Id
                            LEFT JOIN ehosdict.Lst_Dictionary td ON dmbn.DanToc_Id = td.Dictionary_Id
                            WHERE ba.SoBenhAn = N'{ID}'";

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    benhnhan.Add(new BenhNhanDTO()
                    {
                        Name = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin",
                        NgaySinh = !reader.IsDBNull(1) ? reader.GetString(1) : "Không có thông tin",
                        Tuoi = !reader.IsDBNull(2) ? reader.GetInt32(2).ToString() : "Không có thông tin",
                        Sex = !reader.IsDBNull(3) ? (reader.GetString(3) == "T" ? "Nam" : "Nữ" ) : "Không có thông tin",
                        Address = !reader.IsDBNull(4) ? reader.GetString(4) : "Không có thông tin",
                        Bhyt = !reader.IsDBNull(5) ? reader.GetString(5) : "",
                        DanToc = !reader.IsDBNull(6) ? reader.GetString(6) :""
                    });
                }
            }

            return benhnhan;
        }
    }
}

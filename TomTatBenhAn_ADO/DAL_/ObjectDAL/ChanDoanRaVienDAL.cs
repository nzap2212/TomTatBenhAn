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
    public class ChanDoanRaVienDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<ChanDoanRaVienDTO> GetChanDoanRaVienInfo(string ID)
        {
            List<ChanDoanRaVienDTO> ChanDoanRaVien = new List<ChanDoanRaVienDTO>();
            string query = @$"SELECT 
                                ba.ChanDoanRaVien AS BenhChinh, 
                                ba.ChanDoanPhuRaVien AS BenhPhu,
                                icdChinh.MaICD AS MaICDChinh, 
                                icdPhu.MaICD AS MaICDPhu 
                            FROM 
                                dbo.BenhAn ba
                            LEFT JOIN 
                                ehosdict.DM_ICD icdChinh ON ba.ICD_BenhChinh = icdChinh.ICD_Id
                            LEFT JOIN 
                                ehosdict.DM_ICD icdPhu ON ba.ICD_BenhPhu = icdPhu.ICD_Id 
	                            WHERE ba.SoBenhAn = '{ID}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChanDoanRaVien.Add(new ChanDoanRaVienDTO()
                    {
                        BenhChinh = !reader.IsDBNull(0) ? reader.GetString(0) : "",
                        BenhPhu = !reader.IsDBNull(1) ? reader.GetString(1) : "",
                        ICDBenhChinh = !reader.IsDBNull(2) ? reader.GetString(2) : "",
                        ICDBenhPhu = !reader.IsDBNull(3) ? reader.GetString(3) : ""
                    });
                }
            }

            return ChanDoanRaVien;
        }
    }
}

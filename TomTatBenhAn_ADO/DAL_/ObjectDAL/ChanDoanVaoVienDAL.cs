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
    public class ChanDoanVaoVienDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<ChanDoanVaoVienDTO> GetChanDoanVaoVienInfo(string ID)
        {
            List<ChanDoanVaoVienDTO> ChanDoanVaoVien = new List<ChanDoanVaoVienDTO>();
            string query = @$"SELECT 
                                ba.ChanDoanVaoKhoa AS BenhChinh, 
                                icdPhu.TenICD AS TenICDPhu,
                                icdChinh.MaICD AS MaICDChinh, 
                                icdPhu.MaICD AS MaICDPhu 
                            FROM 
                                dbo.BenhAn ba
                            LEFT JOIN 
                                ehosdict.DM_ICD icdChinh ON ba.ICD_VaoKhoa = icdChinh.ICD_Id
                            LEFT JOIN 
                                ehosdict.DM_ICD icdPhu ON ba.ICD_BenhPhu = icdPhu.ICD_Id
                            WHERE SoBenhAn = '{ID}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChanDoanVaoVien.Add(new ChanDoanVaoVienDTO()
                    {
                        BenhChinh = !reader.IsDBNull(0) ? reader.GetString(0) : "",
                        BenhPhu =  "",
                        ICDBenhChinh = !reader.IsDBNull(2) ? reader.GetString(2) : "",
                        ICDBenhPhu =  ""
                    });
                }
            }

            return ChanDoanVaoVien;
        }
    }
}

using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_.ObjectDAL
{
    public class BenhAnTypeDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<BenhAnTypeDTO> GetBenhAnTypeInfo(string ID)
        {
            List<BenhAnTypeDTO> benhAnTypeDTOs = new List<BenhAnTypeDTO>();
            string query = $@"SELECT TOP 1
                              Lower(lba.TenLoaiBenhAn), batq.BenhAnTongQuat_Id
                            FROM 
                              dbo.BenhAnTongQuat batq 
                              LEFT JOIN ehosdict.DM_LoaiBenhAn lba ON batq.LoaiBenhAn_Id = lba.LoaiBenhAn_Id 
                            WHERE 
                              batq.BenhAn_Id = (SELECT BenhAn_Id FROM dbo.BenhAn WHERE SoBenhAn = N'{ID}')
                            ORDER BY 
                              batq.NgayTao ASC";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    benhAnTypeDTOs.Add(new BenhAnTypeDTO() 
                    {
                        LoaiBenhAn = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin",
                        BenhAnTongQuatId = !reader.IsDBNull(1) ? reader.GetInt32(1).ToString() : "Không có thông tin"
                    });
                }
            }
            return benhAnTypeDTOs;  
        }
    }
}

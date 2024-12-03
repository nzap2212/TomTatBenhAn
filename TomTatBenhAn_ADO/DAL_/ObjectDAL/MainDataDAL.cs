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
    public class MainDataDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<MainDataDTO> GetMainDataInfo(string ID, string query)
        {
            List<MainDataDTO> mainData = new List<MainDataDTO>();
            query = query.Replace("@ID", ID);
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    mainData.Add(new MainDataDTO()
                    {
                        LyDoVaoVien = !reader.IsDBNull(0) ? reader.GetString(0) : "Không có thông tin",
                        QuaTrinhBenhLy = !reader.IsDBNull(1) ? reader.GetString(1) : "Không có thông tin",
                        TienSuBenh = !reader.IsDBNull(2) ? reader.GetString(2) : "Không có thông tin",
                        PhuongPhapDieuTri = !reader.IsDBNull(3) ? reader.GetString(3) : "Không có thông tin"
                    });
                }
            }
            return mainData;
        }
    }
}

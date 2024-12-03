using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_.ObjectDAL
{
    public class SoBenhAnDAL
    {
        private string connectionString = ReadFileEnv.Instance.envData["CONNECTION_STRING"];

        public List<SoBenhAnDTO> GetSoBenhAnInfo(string ID)
        {
            List<SoBenhAnDTO> SoBenhAnlst = new List<SoBenhAnDTO>();
            string query = $@"SELECT ba.SoBenhAn FROM ehosdict.DM_BenhNhan dmbn
                            LEFT JOIN dbo.BenhAn ba ON dmbn.BenhNhan_Id = ba.BenhNhan_Id
                            WHERE dmbn.SoVaoVien = '{ID}'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    SoBenhAnlst.Add(new SoBenhAnDTO()
                    {
                        SoBenhAn = reader.GetString(0)
                    });
                }
            }
            return SoBenhAnlst;
        }
    }
}

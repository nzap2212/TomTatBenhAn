using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Services
{
    public class ReadFileEnv
    {
        private static ReadFileEnv instance;
        public static ReadFileEnv Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReadFileEnv();
                }
                return instance;
            }
        }
        private ReadFileEnv() { }

        // Khai báo Dict để lưu trữ thông tin từ file env 
        public Dictionary<string, string> envData = new Dictionary<string, string>();

        //Hàm đọc file .env
        public void ReadConfig_file()
        {
            try
            {
                string currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string filePath = Path.Combine(currentDirectory, ".env");

                // Load file env và thêm dữ liệu vào Dictionary để sử dụng sau
                Env.Load(filePath);
                envData.Add("API_KEY_1", Env.GetString("API_KEY_1"));
                envData.Add("API_KEY_2", Env.GetString("API_KEY_2"));
                envData.Add("API_KEY_3", Env.GetString("API_KEY_3"));
                envData.Add("API_URL", Env.GetString("API_URL"));
                envData.Add("CONNECTION_STRING", Env.GetString("CONNECTION_STRING"));
                envData.Add("QUERY_SOBENHAN", Env.GetString("QUERY_SOBENHAN"));
                envData.Add("QUERY_MAYTE", Env.GetString("QUERY_MAYTE"));
                envData.Add("QUERY_KQXN", Env.GetString("QUERY_KQXN"));
                envData.Add("PROMT_BENHAN", Env.GetString("PROMT_BENHAN"));
                envData.Add("PROMT_PHACDO", Env.GetString("PROMT_PHACDO"));
                envData.Add("PROMT_KQXN", Env.GetString("PROMT_KQXN"));
                envData.Add("PROMT_TTNB", Env.GetString("PROMT_TTNB"));
                envData.Add("DANHSACHPHACDO", Env.GetString("DANHSACHPHACDO"));
                
            }
            catch (Exception ex) 
            {
                throw new ServicesErr("Lỗi khi đọc file .env, Lỗi: ", ex);
            }
        }
    }
}

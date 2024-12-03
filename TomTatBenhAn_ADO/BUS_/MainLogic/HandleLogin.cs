using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace BUS_.MainLogic
{
    public class HandleLogin
    {
        private static HandleLogin instance;
        public static HandleLogin Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new HandleLogin();
                }
                return instance;
            }
        }

        private HandleLogin() { }

        // Hàm in thông tin người dùng
        public async Task<bool> updateUser(string userName, string userDepartment, string empCode)
        {
            try
            {
                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userDepartment))
                {
                    var requestData = new
                    {
                        name = userName.ToUpper(),
                        department = userDepartment.ToUpper(),
                        employeeCode = empCode.ToUpper()
                    };
                    string json = JsonConvert.SerializeObject(requestData);
                    var client = new RestClient("http://api-hospital.zigisoft.com/api/users/add");
                    var request = new RestRequest("", Method.Post);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddJsonBody(json);

                    RestResponse response = await client.PostAsync(request);
                    if (response.IsSuccessful)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex) 
            {
                throw new GetStatusErr("Lỗi khi kiểm tra thông tin người dùng" + ex.Message);
            }
            return false;
        }
        
        // Hàm in thông tin sử dụng của người dùng
        public async Task<string> printUserUsage(string userName, string userDepartment, string empCode)
        {
            try
            {
                if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(userDepartment) && !string.IsNullOrEmpty(empCode))
                {
                    var requestData = new
                    {
                        name = userName.ToUpper(),
                        department = userDepartment.ToUpper(),
                        employeeCode = empCode.ToUpper()
                    };
                    string json = JsonConvert.SerializeObject(requestData);
                    var client = new RestClient("http://api-hospital.zigisoft.com/api/users/list");
                    var request = new RestRequest("", Method.Get);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddJsonBody(json);

                    RestResponse response = await client.GetAsync(request);
                    if (response.IsSuccessful)
                    {
                        var data = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(response.Content);
                        foreach (var item in data)
                        {
                            if (item["name"].ToString() == userName.ToUpper() && item["department"].ToString() == userDepartment.ToUpper())
                            {
                                return item["usageCount"].ToString();
                            }
                        }
                    }
                }
                return "Không lấy được thông tin sử dụng của nhân viên!!!";
            }
            catch (Exception ex)
            {
                throw new GetStatusErr(ex.Message);
            }
        }
    }
}

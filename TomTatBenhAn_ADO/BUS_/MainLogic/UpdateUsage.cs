using Newtonsoft.Json;
using RestSharp;
using Services;

namespace BUS_.MainLogic
{
    public class UpdateUsage
    {
        private static UpdateUsage instance;
        public static UpdateUsage Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new UpdateUsage();
                }
                return instance;
            }
        }

        private Dictionary<string, string> Config = ReadConfigGoogleSheet.Instance.APIConfig;

        private UpdateUsage() { }
        public async Task<bool> UpdateUsage_user(string userName, string userDepartment, string empCode)
        {
            var requestData = new
            {
                name = userName.ToUpper(),
                department = userDepartment.ToUpper(),
                employeeCode = empCode.ToUpper(),
            };
            string json = JsonConvert.SerializeObject(requestData);
            var client = new RestClient($"{Config["api_tomtatbenhan"]}api/users/update-usage");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(json);

            RestResponse response = await client.PostAsync(request);
            if (response.IsSuccessful)
            {
                return true;
            }
            return false;
        }
    }
}

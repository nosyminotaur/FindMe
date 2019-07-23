using System.Net.Http;
using System.Threading.Tasks;
using FindMe.Shared.Models;
using Newtonsoft.Json;

namespace FindMe.Services
{
    class AuthService : IAuthService
    {
        private readonly string BASE_URL = "http://10.0.2.2:5000";
        private readonly string jsonMediaType = "application/json";
        private readonly HttpClient httpClient;
        public AuthService()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new System.Uri(BASE_URL)
            };
        }
        public async Task<UserOutDTO> EmailLogin(string email, string password)
        {
            EmailLoginDTO requestObject = new EmailLoginDTO
            {
                email = email,
                password = password
            };

            var stringPayload = JsonConvert.SerializeObject(requestObject);
            var httpContent = new StringContent(stringPayload, System.Text.Encoding.UTF8, jsonMediaType);

            var response = await httpClient.PostAsync("api/auth/email-login", httpContent);
            string responseContent = await response.Content.ReadAsStringAsync();
            try
            {
                UserOutDTO objectResponse = JsonConvert.DeserializeObject<UserOutDTO>(responseContent);
                return objectResponse;
            }
            catch(System.Exception)
            {
                return null;
            }
        }

        public async Task<UserOutDTO> UsernameLogin(string username, string password)
        {
            //C# 8 does not require field = variable init
            UsernameLoginDTO requestObject = new UsernameLoginDTO
            {
                username = username,
                password = password
            };

            var stringPayload = JsonConvert.SerializeObject(requestObject);
            var httpContent = new StringContent(stringPayload, System.Text.Encoding.UTF8, jsonMediaType);

            var response = await httpClient.PostAsync("api/auth/username-login", httpContent);
            string responseContent = await response.Content.ReadAsStringAsync();
            try
            {
                UserOutDTO objectResponse = JsonConvert.DeserializeObject<UserOutDTO>(responseContent);
                return objectResponse;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}

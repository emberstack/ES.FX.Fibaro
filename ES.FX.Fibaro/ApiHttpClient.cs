using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ES.FX.Fibaro
{
    public class ApiHttpClient : HttpClient
    {
        public ApiHttpClient(string hostName, string username, string password)
        {
            BaseAddress = new Uri(hostName);
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}")));
            DefaultRequestHeaders.Add("X-Fibaro-Version", "2");
        }
    }
}
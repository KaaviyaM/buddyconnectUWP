using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.Services
{
   public class HttpService
    {
        public HttpService()
        {

        }

        public async Task<string> GetAsync(string requestUriString)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient httpClient = new HttpClient(handler);
            httpClient.MaxResponseContentBufferSize = 256000;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUriString);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

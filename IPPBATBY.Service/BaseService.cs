using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

using IPPBATBY.YahooFinance.Service.Models;

namespace IPPBATBY.YahooFinance.Service
{
    public abstract class BaseService
    {
        protected async Task<WebResult> GetJsonAsync(string requestUri)
        {
            var result = new Models.WebResult();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(requestUri);
                result.Content = await response.Content.ReadAsStringAsync();
                result.Success = response.IsSuccessStatusCode;
            }

            return result;
            
        }


    }


}

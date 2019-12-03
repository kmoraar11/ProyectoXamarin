using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Proyecto.Modelos;
using Newtonsoft.Json;


namespace Proyecto.Recursos
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<WheatherData> GetWheatherDataAsync(string uri)
        {
            WheatherData wheatherdata = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    wheatherdata = JsonConvert.DeserializeObject<WheatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return wheatherdata;
        }
       
    }
}

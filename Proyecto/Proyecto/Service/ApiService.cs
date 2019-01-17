using System;

using Xamarin.Forms;
using System.Diagnostics; using System.Net.Http; using System.Net.Http.Headers; using System.Threading.Tasks;
using Proyecto.Model;
using Newtonsoft.Json;  

namespace Proyecto.Service
{
    public class ApiService 

    {
        private const string WEB_SERVICE_URL = "https://randomuser.me/api/"; 
        public async Task<Persona[]> GetStringAsync()          {                      using (var client = new HttpClient())           {               client.BaseAddress = new Uri(WEB_SERVICE_URL);                 client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));               var response = await client.GetStringAsync("");                 var data = JsonConvert.DeserializeObject<Persona[]>(response);
               

                Debug.WriteLine(                    data                );                  return data;            } ;         }
        public async Task<Persona[]> GetAsync()
        {
            var client = new HttpClient();              client.BaseAddress = new Uri(WEB_SERVICE_URL);              client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await client.GetAsync("");

            if (!response.IsSuccessStatusCode)
            {
                return new Persona[0];             }

            var content = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<Persona[]>(content);              Debug.WriteLine(                data            );              return data;
        }     }
}


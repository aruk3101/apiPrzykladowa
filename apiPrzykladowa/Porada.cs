using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace apiPrzykladowa
{
    public static class Porada
    {
        public static async Task<string> LosujPorade()
        {
            string apiUrl = "https://api.adviceslip.com/advice";
            using (HttpClient klient = new HttpClient()) 
            {
                HttpResponseMessage odpowiedz = await klient.GetAsync(apiUrl);
                odpowiedz.EnsureSuccessStatusCode();
                return JObject.Parse(await odpowiedz.Content.ReadAsStringAsync())["slip"]["advice"].ToString();
            }
        }
    }
}

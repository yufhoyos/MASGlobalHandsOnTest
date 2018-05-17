using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Data
{
    public class ApiRepository
    {
        protected static readonly HttpClient client = new HttpClient();
        /// <summary>
        /// For Velocity, but in real life i probably use the .net Core IOptions Configurations.
        /// </summary>
        public string UrlBaseAddress { get; set; } = "http://masglobaltestapi.azurewebsites.net/api/";
        public ApiRepository()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri(UrlBaseAddress);
            }
        }
    }
}

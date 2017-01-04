using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeServices
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:64944/");

            client.DefaultRequestHeaders.Accept.Clear();

            HttpResponseMessage response = await client.GetAsync("/api/contact");

            if (response.IsSuccessStatusCode)
            {

            }
            else
            {

            }
        }
    }
}

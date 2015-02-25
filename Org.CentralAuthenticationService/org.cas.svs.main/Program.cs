using Microsoft.Owin.Hosting;
using System;
using System.Configuration;
using System.Net.Http;
using System.Text;

namespace org.cas.svs.main
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = ConfigurationManager.AppSettings["BaseAddress"];

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                //HttpClient client = new HttpClient();

                //var response = client.GetAsync(baseAddress + "api/values").Result;

                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                Console.WriteLine(ConfigurationManager.AppSettings["WelcomeMessage"]);
                Console.WriteLine("Press [Enter] key to bring the service offline.");
                Console.ReadLine(); 
            }

            Console.WriteLine("Are you sure you want to bring the service offline? Press [Enter] to continue.");
            Console.ReadLine(); 
        }
    }
}

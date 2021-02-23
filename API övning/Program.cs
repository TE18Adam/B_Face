using System;
using Newtonsoft.Json;
using RestSharp;

namespace API_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            RestClient client = new RestClient("https://swapi.dev/api/");
            
            
            RestRequest  request= new RestRequest("https://swapi.dev/api/people/1/");


            IRestResponse response = client.Get(request);

            
            Program person = JsonConvert.DeserializeObject<Program>(response.Content); 
            
            
            Console.WriteLine(response.Content);

            

            Console.ReadLine();
        }
    }
}

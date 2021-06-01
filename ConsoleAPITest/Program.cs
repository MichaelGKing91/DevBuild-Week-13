using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleAPITest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response1 = await client.GetAsync("/api/deck/new/shuffle/?deck_count=1");
            string result = await response1.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}

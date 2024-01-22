using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {



       public static void KanyeQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var KanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"");
            Console.WriteLine("-----------------");
            Console.WriteLine($" Kanye: ' {KanyeQuote} ' ");
            Console.WriteLine("-----------------");
        }
        public static void RonQuote ()
        {
            var client = new HttpClient();
            var RonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var RonResponse = client.GetStringAsync(RonURL).Result;
            var RonQoute = JArray.Parse(RonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Ron: '{RonQoute}'");
            Console.WriteLine($"-----------------------");
        }
    }
}

using System;
using System.Net.Http;
using System.Runtime.InteropServices.JavaScript;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 5; i++)
            {
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();
            }
           
        }
    }
}
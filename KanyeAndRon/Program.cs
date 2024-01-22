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
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();
        }
    }
}
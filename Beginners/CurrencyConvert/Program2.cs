using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WaehrungsRechner
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            string apiKey = "Hier API Key einfügen von exchangerate-api.com";
            string bCurr = "EUR";
            string tCurr = "USD";
            decimal bCurrVal,
                tCurrVal;

            Console.Write("Bitte gebe die Base Währung ein [EUR]: ");
            bCurr = Console.ReadLine();
            Console.Write("Bitte gebe die Target Währung ein [USD]: ");
            tCurr = Console.ReadLine();

            string url = $"https://api.exchangerate-api.com/v4/latest/{bCurr}?apikey={apiKey}";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            string searchString = $"\"{tCurr}\":";
            int startIndex = responseBody.IndexOf(searchString) + searchString.Length;
            int endIndex = responseBody.IndexOf(",", startIndex);
            if (endIndex == -1)
            {
                endIndex = responseBody.IndexOf("}", startIndex);
            }
            string exchangeRateString = responseBody
                .Substring(startIndex, endIndex - startIndex)
                .Trim();
            CultureInfo culture = new CultureInfo("en-US");
            decimal exchangeRate = decimal.Parse(exchangeRateString, culture);

            Console.WriteLine("Der Wechselkurs von {0} zu {1} ist {2}", bCurr, tCurr, exchangeRate);

            Console.Write("Bitte gebe ein, wie viel Geld du umrechnen willst: ");
            bCurrVal = Convert.ToDecimal(Console.ReadLine());
            tCurrVal = bCurrVal * exchangeRate;

            Console.WriteLine("{0} {1} sind {2} {3}", bCurrVal, bCurr, tCurrVal, tCurr);
            Console.ReadLine();
        }
    }
}

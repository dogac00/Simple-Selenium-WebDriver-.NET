using OpenQA.Selenium.Chrome;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Fintables
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void GetResponseHeaders()
        {
            var driver = new ChromeDriver(SeleniumDriverService.ChromePath);

            driver.Navigate().GoToUrl("https://www.google.com");

            string script = "var request = new XMLHttpRequest(); " +
                "request.open('GET', document.location); " +
                "request.send(null); " +
                "var headers = request.getAllResponseHeaders(); " +
                "return headers;";

            var headers = driver.Scripts().ExecuteScript(script).ToString();

            Console.WriteLine(headers);
        }

        static void RunHttpClient()
        {
            HttpClient client = new HttpClient();

            Uri url = new Uri("https://fintables.com/");

            var response = client.GetAsync(url);

            var statusCode = response.Result.StatusCode;
            var headers = response.Result.Headers;
            var content = response.Result.Content;
        }
    }
}

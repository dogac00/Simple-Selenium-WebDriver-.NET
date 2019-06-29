using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.IO;
using System.Reflection;

namespace Fintables
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new SeleniumDriverService(new ChromeDriver(SeleniumDriverService.ChromePath, SeleniumDriverService.ChromeOptions));

            driver.GoToFintables();
        }
    }
}

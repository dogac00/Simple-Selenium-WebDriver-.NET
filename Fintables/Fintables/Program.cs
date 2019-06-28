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
            ISeleniumDriver driver = new SeleniumDriverService(new ChromeDriver(SeleniumDriverService.ChromePath, SeleniumDriverService.ChromeOptions));

            HtmlAgilityPackService service = new HtmlAgilityPackService(driver);

            service.Agility();
        }
    }
}

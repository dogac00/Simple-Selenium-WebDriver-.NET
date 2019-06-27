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
            DriverUtils manager = new DriverUtils(new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

            manager.GoToFinTables();
        }
    }
}

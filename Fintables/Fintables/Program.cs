using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace Fintables
{
    class Program
    {
        static void Main(string[] args)
        {
            SeleniumUtils su = new SeleniumUtils();

            su.Run();
        }
    }

    class SeleniumUtils
    {
        public void Run()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Url = "https://fintables.com/";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Click Login Button
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div[1]/div/ul/li[10]/div/a[1]")).Click();

            // Fill Login Form
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div/div/div[2]/div[2]/form/div[1]/div[2]/div/span/input")).SendKeys("test@test.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div/div/div[2]/div[2]/form/div[2]/div[2]/div/span/input")).SendKeys("test123456");

            // Click Form Submit Button
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div/div/div[2]/div[2]/form/button")).Click();
        }
    }
}

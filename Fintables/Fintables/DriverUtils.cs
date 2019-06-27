using OpenQA.Selenium;
using System.Collections.Generic;

namespace Fintables
{
    class DriverUtils
    {
        private readonly IWebDriver driver;
        private readonly IJavaScriptExecutor js;

        public DriverUtils(IWebDriver driver)
        {
            this.driver = driver;
            this.js = (IJavaScriptExecutor)driver;
        }

        public IWebElement FindElementContains(string text)
        {
            return driver.FindElement(By.XPath($"//*[contains(text(), { text })]"));
        }

        public IList<IWebElement> FindElementsContains(string text)
        {
            return driver.FindElements(By.XPath($"//*[contains(text(), '{ text }')]"));
        }

        public void GoToFinTables()
        {
            driver.Url = "https://fintables.com/";

            driver.MaximizeWindow();
            driver.SetTimeout(10);

            // Click Login Button
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div[1]/div/ul/li[10]/div/a[1]")).Click();

            // Fill Login Form
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div/div/div[2]/div[2]/form/div[1]/div[2]/div/span/input")).SendKeys("test@test.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div/div/div[2]/div[2]/form/div[2]/div[2]/div/span/input")).SendKeys("test123456");

            // Click Form Submit Button
            driver.FindElement(By.XPath("//*[@id='root']/div/section/main/div/div/div[2]/div[2]/form/button")).Click();

            // Click Forgotten Button
            var forgottenButton = driver.FindContains("unuttum");

            forgottenButton.Click();
        }

        public void ConsoleLogJS(string val)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;

            js.ExecuteScript($"console.log('{val}')");
        }

        public string GetHtmlOfPage(string url)
        {
            driver.Url = url;

            return driver.PageSource;
        }

        public string GetInnerHTML(string xPath)
        {
            var element = driver.FindElement(By.XPath(xPath));

            return GetInnerHTML(element);
        }

        public string GetInnerHTML(IWebElement element)
        {
            return element.GetAttribute("innerHtml");
        }
    }
}

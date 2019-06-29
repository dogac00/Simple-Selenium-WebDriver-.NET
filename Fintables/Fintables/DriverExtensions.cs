using OpenQA.Selenium;
using System;

namespace Fintables
{
    static class DriverExtensions
    {
        public static void MaximizeWindow(this IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public static void SetTimeout(this IWebDriver driver, int timeOutSeconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeOutSeconds);
        }

        public static IWebElement FindContains(this IWebDriver driver, string text)
        {
            return driver.FindElement(By.XPath($"//*[contains(text(), { text })]"));
        }

        public static IJavaScriptExecutor Scripts(this IWebDriver driver)
        {
            return (IJavaScriptExecutor)driver;
        }
    }
}

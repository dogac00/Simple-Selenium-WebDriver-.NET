using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fintables
{
    public class SeleniumCookieService
    {
        private readonly IWebDriver driver;

        private SeleniumCookieService(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static SeleniumCookieService GetService(IWebDriver driver)
        {
            return new SeleniumCookieService(driver);
        }

        public ICookieJar GetCookies() =>
            driver.Manage().Cookies;

        public void AddCookie(Cookie cookie) =>
            driver.Manage().Cookies.AddCookie(cookie);

        public void DeleteCookie(Cookie cookie) =>
            driver.Manage().Cookies.DeleteCookie(cookie);
    }
}

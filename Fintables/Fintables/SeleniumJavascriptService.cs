using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fintables
{
    class SeleniumJavascriptService
    {
        public IWebDriver Driver { get; }
        public IJavaScriptExecutor Executor { get; }

        public SeleniumJavascriptService(IWebDriver driver)
        {
            Driver = driver;
        }

        public object ExecuteJavascript(string script, params object[] args)
        {
            return Executor.ExecuteAsyncScript(script: script, args);
        }

        public object GetCookies()
        {
            return ExecuteJavascript("return document.cookie");
        }

        public void Cookies()
        {
            var cookies = GetCookies();

            Console.WriteLine(cookies.GetType());
        }
    }
}

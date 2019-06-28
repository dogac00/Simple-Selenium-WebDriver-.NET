using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fintables
{
    interface ISeleniumDriver
    {
        IWebElement FindElementContains(string text);

        IList<IWebElement> FindElementsContains(string text);

        string GetHtmlOfPage(string url);

        string GetInnerHTML(IWebElement element);
    }
}

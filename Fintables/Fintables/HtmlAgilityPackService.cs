using HtmlAgilityPack;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace Fintables
{
    class HtmlAgilityPackService
    {
        private readonly ISeleniumDriver driver;

        public HtmlAgilityPackService(ISeleniumDriver driver)
        {
            this.driver = driver;
        }

        public void Agility()
        {
            var html = driver.GetHtmlOfPage("https://fintables.com/");

            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var root = htmlDocument.DocumentNode;

            var input = root
                .SelectSingleNode("//*[@id=\"root\"]/div/section/main/div[2]/div/div/div/div/div[1]/div[1]/div/div/div");

            var hello = root
                .SelectSingleNode("//*[@id=\"root\"]/div/section/main/div[2]/div/div/div/div/h3");


        }
    }
}

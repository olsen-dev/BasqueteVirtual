using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BasqueteVirtual
{
    public class Crawler
    {
        public  void BasqueteCrawler()
        {


            IWebDriver driver = new ChromeDriver(@"c:\chromedriver"); 
            driver.Navigate().GoToUrl("https://www.bet365.com/#/AVR/B2026/");

        }

    }
}

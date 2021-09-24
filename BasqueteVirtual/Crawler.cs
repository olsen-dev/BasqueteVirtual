using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using BasqueteVirtual.Controllers;
using BasqueteVirtual.Models;
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
            ApostasNoJogo apostasNoJogo_1 = new ApostasNoJogo();
            ApostasNoJogo apostasNoJogo_2 = new ApostasNoJogo();
            var horarios = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"));
            while (true)
            {
                try { 
                

                var loop = true;
                while (loop)
                {
                    horarios = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"));
                    if (horarios.Count > 0)
                    {
                        if (horarios[0].Text != null)
                            loop = false;
                    }
                }
                for (var x = 0; x < horarios.Count; x++)
                {

                    driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Click();
                    Thread.Sleep(500);
                    apostasNoJogo_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                    apostasNoJogo_1.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[1].Text;
                    apostasNoJogo_1.Handicap = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[0].Text;
                    apostasNoJogo_1.Total = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[1].Text;
                    apostasNoJogo_1.ParaGanhar = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[2].Text;
                    apostasNoJogo_1.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[1].Text;

                    apostasNoJogo_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                    apostasNoJogo_2.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[2].Text;
                    apostasNoJogo_2.Handicap = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[2].Text;
                    apostasNoJogo_2.Total = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[3].Text;
                    apostasNoJogo_2.ParaGanhar = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[5].Text;
                    apostasNoJogo_2.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[3].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[4].Text;
                    CrawlerController crawlerController = new CrawlerController();
                    if (driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[3].Text == "")
                    {
                        continue;
                    }
                    else
                    {
                        crawlerController.Create(apostasNoJogo_2);
                    }
                    if (driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[0].Text == "")
                    {
                        continue;
                    }
                    else
                    {
                        crawlerController.Create(apostasNoJogo_1);
                    }

                }
                Thread.Sleep(500);
                }
                catch (Exception ex)
                {

                }
            }
            

        }

    }
}

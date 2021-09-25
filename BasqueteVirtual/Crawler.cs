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
            driver.Navigate().GoToUrl("https://www.bet365.com/#/AVR/B2026/R^1/");

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
                        CrawlerController crawlerController = new CrawlerController();
                        driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Click();
                        Thread.Sleep(500);
                        try {
                            ApostasNoJogo apostasNoJogo_1 = new ApostasNoJogo();
                            apostasNoJogo_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            apostasNoJogo_1.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[1].Text;
                            apostasNoJogo_1.Handicap = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[0].Text;
                            apostasNoJogo_1.Total = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[1].Text;
                            apostasNoJogo_1.ParaGanhar = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[2].Text;
                            apostasNoJogo_1.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[1].Text;
                            
                            ApostasNoJogo apostasNoJogo_2 = new ApostasNoJogo();
                            apostasNoJogo_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            apostasNoJogo_2.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[2].Text;
                            apostasNoJogo_2.Handicap = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[2].Text;
                            apostasNoJogo_2.Total = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Handicap"))[3].Text;
                            apostasNoJogo_2.ParaGanhar = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[5].Text;
                            apostasNoJogo_2.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[3].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[4].Text;
                            
                            if (driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[3].Text != "")
                            {
                                crawlerController.Create_ApostasNoJogo(apostasNoJogo_2);
                            }
                            if (driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[0].Text != "")
                            {
                                crawlerController.Create_ApostasNoJogo(apostasNoJogo_1);
                            }
                        } catch(Exception ex) 
                        {
                        
                        }

                        try
                        {
                            JogoTotalMaisAlternativa jogoTotalMaisAlternativa = new JogoTotalMaisAlternativa();
                            jogoTotalMaisAlternativa.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            jogoTotalMaisAlternativa.MaisDe = driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Name"))[0].Text;
                            jogoTotalMaisAlternativa.MenosDe = driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Name"))[1].Text;
                            jogoTotalMaisAlternativa.Odds = driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Odds"))[1].Text;
                            if(driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Odds"))[0].Text != "")
                            {
                                crawlerController.Create_JogoTotalMaisAlternativa(jogoTotalMaisAlternativa);
                            }

                        } catch(Exception ex) 
                        {
                        
                        }


                        try
                        {
                            HandicapDePontosAlternativo handicapDePontosAlternativo_1 = new HandicapDePontosAlternativo();
                            handicapDePontosAlternativo_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            handicapDePontosAlternativo_1.Nome = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[0].Text;
                            handicapDePontosAlternativo_1.Odds = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[0].Text;

                            HandicapDePontosAlternativo handicapDePontosAlternativo_2 = new HandicapDePontosAlternativo();
                            handicapDePontosAlternativo_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            handicapDePontosAlternativo_2.Nome = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[1].Text;
                            handicapDePontosAlternativo_2.Odds = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[1].Text;

                            if(handicapDePontosAlternativo_1.Odds != "")
                            {
                                crawlerController.Create_HandicapDePontosAlternativo(handicapDePontosAlternativo_1);
                            }
                            if (handicapDePontosAlternativo_2.Odds != "")
                            {
                                crawlerController.Create_HandicapDePontosAlternativo(handicapDePontosAlternativo_2);
                            }

                        }
                        catch (Exception ex) { 
                        
                        }

                        try
                        {
                            ResultadoEtotal resultadoEtotal_1 = new ResultadoEtotal();
                            resultadoEtotal_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            resultadoEtotal_1.TimeMaisDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[0].Text;
                            resultadoEtotal_1.TimeMenosDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[1].Text;
                            resultadoEtotal_1.Odds = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[1].Text;

                            ResultadoEtotal resultadoEtotal_2 = new ResultadoEtotal();
                            resultadoEtotal_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            resultadoEtotal_2.TimeMaisDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[2].Text;
                            resultadoEtotal_2.TimeMenosDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[3].Text;
                            resultadoEtotal_2.Odds = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[2].Text + "-" + driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[3].Text;

                            if(resultadoEtotal_1.Odds != "-")
                            {
                                crawlerController.Create_ResultadoEtotal(resultadoEtotal_1);
                            }
                            if(resultadoEtotal_2.Odds != "-")
                            {
                                crawlerController.Create_ResultadoEtotal(resultadoEtotal_2);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        try
                        {
                            HandicapEtotai handicapEtotai_1 = new HandicapEtotai();
                            handicapEtotai_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            handicapEtotai_1.TimeMaisDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[6].Text;
                            handicapEtotai_1.TimeMenosDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[7].Text;
                            handicapEtotai_1.Odds = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[6].Text + "-" + driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[7].Text;

                            HandicapEtotai handicapEtotai_2 = new HandicapEtotai();
                            handicapEtotai_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            handicapEtotai_2.TimeMaisDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[8].Text;
                            handicapEtotai_2.TimeMenosDe = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Name"))[9].Text;
                            handicapEtotai_2.Odds = driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[8].Text + "-" + driver.FindElements(By.ClassName("gl-ParticipantBorderless_Odds"))[9].Text;

                            if (handicapEtotai_2.Odds != "-")
                            {
                                crawlerController.Create_HandicapEtotai(handicapEtotai_1);
                            }
                            if (handicapEtotai_2.Odds != "-")
                            {
                                crawlerController.Create_HandicapEtotai(handicapEtotai_2);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        try
                        {
                            TimeTotai timeTotai_1 = new TimeTotai();
                            timeTotai_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            timeTotai_1.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[0].Text;
                            timeTotai_1.MaisDe = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Handicap"))[0].Text;
                            timeTotai_1.MenosDe = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Handicap"))[1].Text;
                            timeTotai_1.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Odds"))[1].Text;

                            TimeTotai timeTotai_2 = new TimeTotai();
                            timeTotai_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            timeTotai_2.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[1].Text;
                            timeTotai_2.MaisDe = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Handicap"))[2].Text;
                            timeTotai_2.MenosDe = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Handicap"))[3].Text;
                            timeTotai_2.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Odds"))[2].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Odds"))[3].Text;


                            if (timeTotai_1.Odds != "-")
                            {
                                crawlerController.Create_TimeTotai(timeTotai_1);
                            }
                            if (timeTotai_2.Odds != "-")
                            {
                                crawlerController.Create_TimeTotai(timeTotai_2);
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    Thread.Sleep(5000);
                }
                catch (Exception ex)
                {

                }
            }
            

        }

    }
}

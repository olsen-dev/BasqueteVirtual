using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using BasqueteVirtual.Controllers;
using BasqueteVirtual.Models;
using DotRas;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BasqueteVirtual
{
    public class Crawler
    {
        public void BasqueteCrawler()
        {

            IWebDriver driver = new ChromeDriver(@"c:\chromedriver");
            driver.Navigate().GoToUrl("https://www.bet365.com/#/AVR/B2026/R^1/");

            var horarios = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"));
            while (true)
            {
                try
                {
                    var loop = true;
                    var number = 0;
                    while (loop)
                    {
                        horarios = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"));
                        if (horarios.Count > 0)
                        {
                            if (horarios[0].Text != null)
                                loop = false;
                        }
                        else
                        {
                            if (number == 5)
                            {
                                driver.Navigate().GoToUrl("https://www.bet365.com/#/AVR/B2026/?V=" + number);
                                horarios = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"));
                                break;
                                
                            }
                            else
                            {
                                number++;
                            }
                            //Thread.Sleep(500);
                        }
                    }
                    for (var x = 0; x < horarios.Count; x++)
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0 , 0)");
                        CrawlerController crawlerController = new CrawlerController();
                        driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Click();
                        Thread.Sleep(500);
                        try
                        {
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
                            else
                            {
                                continue;
                            }
                            if (driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedMarketRow_Odds"))[0].Text != "")
                            {
                                crawlerController.Create_ApostasNoJogo(apostasNoJogo_1);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        try
                        {
                            JogoTotalMaisAlternativa jogoTotalMaisAlternativa = new JogoTotalMaisAlternativa();
                            jogoTotalMaisAlternativa.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            jogoTotalMaisAlternativa.MaisDe = driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Name"))[0].Text;
                            jogoTotalMaisAlternativa.MenosDe = driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Name"))[1].Text;
                            jogoTotalMaisAlternativa.Odds = driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Odds"))[1].Text;
                            if (driver.FindElements(By.ClassName("srb-ParticipantStackedBorderless_Odds"))[0].Text != "")
                            {
                                crawlerController.Create_JogoTotalMaisAlternativa(jogoTotalMaisAlternativa);
                            }

                        }
                        catch (Exception ex)
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

                            if (handicapDePontosAlternativo_1.Odds != "")
                            {
                                crawlerController.Create_HandicapDePontosAlternativo(handicapDePontosAlternativo_1);
                            }
                            if (handicapDePontosAlternativo_2.Odds != "")
                            {
                                crawlerController.Create_HandicapDePontosAlternativo(handicapDePontosAlternativo_2);
                            }

                        }
                        catch (Exception ex)
                        {

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

                            if (resultadoEtotal_1.Odds != "-")
                            {
                                crawlerController.Create_ResultadoEtotal(resultadoEtotal_1);
                            }
                            if (resultadoEtotal_2.Odds != "-")
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
                            timeTotai_1.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[1].Text;
                            timeTotai_1.MaisDe = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Handicap"))[0].Text;
                            timeTotai_1.MenosDe = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Handicap"))[1].Text;
                            timeTotai_1.Odds = driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Odds"))[0].Text + "-" + driver.FindElements(By.ClassName("srb-ParticipantCenteredStackedWithMarketBorders_Odds"))[1].Text;

                            TimeTotai timeTotai_2 = new TimeTotai();
                            timeTotai_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            timeTotai_2.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[2].Text;
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

                        try
                        {
                            TotaldoJogoIntervalos5Ponto totaldoJogoIntervalos5Pontos = new TotaldoJogoIntervalos5Ponto();
                            totaldoJogoIntervalos5Pontos.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            totaldoJogoIntervalos5Pontos.MenosDe180 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[0].Text;
                            totaldoJogoIntervalos5Pontos.De180Ate184 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[1].Text;
                            totaldoJogoIntervalos5Pontos.De185Ate189 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[2].Text;
                            totaldoJogoIntervalos5Pontos.De190Ate194 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[3].Text;
                            totaldoJogoIntervalos5Pontos.De195Ate199 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[4].Text;
                            totaldoJogoIntervalos5Pontos.De200Ate204 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[5].Text;
                            totaldoJogoIntervalos5Pontos.De205Ate209 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[6].Text;
                            totaldoJogoIntervalos5Pontos.De210Ate214 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[7].Text;
                            totaldoJogoIntervalos5Pontos.De215Ate219 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[8].Text;
                            totaldoJogoIntervalos5Pontos.De220Ate224 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[9].Text;
                            totaldoJogoIntervalos5Pontos.De225Ate229 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[10].Text;
                            totaldoJogoIntervalos5Pontos.De230Ate234 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[11].Text;
                            totaldoJogoIntervalos5Pontos.De235Ate239 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[12].Text;
                            totaldoJogoIntervalos5Pontos.De240Ate244 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[13].Text;
                            totaldoJogoIntervalos5Pontos.De245Ate249 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[14].Text;
                            totaldoJogoIntervalos5Pontos.MaisDe249 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[15].Text;


                            if (totaldoJogoIntervalos5Pontos.MenosDe180 != "")
                            {
                                crawlerController.Create_TotaldoJogoIntervalos5Ponto(totaldoJogoIntervalos5Pontos);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        try
                        {
                            TotaldoJogoIntervalos10Ponto totaldoJogoIntervalos10Pontos = new TotaldoJogoIntervalos10Ponto();
                            totaldoJogoIntervalos10Pontos.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            totaldoJogoIntervalos10Pontos.MenosDe180 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[16].Text;
                            totaldoJogoIntervalos10Pontos.De180Ate189 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[17].Text;
                            totaldoJogoIntervalos10Pontos.De190Ate199 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[18].Text;
                            totaldoJogoIntervalos10Pontos.De200Ate209 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[19].Text;
                            totaldoJogoIntervalos10Pontos.De210Ate219 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[20].Text;
                            totaldoJogoIntervalos10Pontos.De220Ate229 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[21].Text;
                            totaldoJogoIntervalos10Pontos.De230Ate239 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[22].Text;
                            totaldoJogoIntervalos10Pontos.De240Ate249 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[23].Text;
                            totaldoJogoIntervalos10Pontos.De250Ate259 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[24].Text;
                            totaldoJogoIntervalos10Pontos.MaisDe259 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[25].Text;



                            if (totaldoJogoIntervalos10Pontos.MenosDe180 != "")
                            {
                                crawlerController.Create_TotaldoJogoIntervalos10Ponto(totaldoJogoIntervalos10Pontos);
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        try
                        {
                            MargemDeVitoria5Opco margemDeVitoria5Opco_1 = new MargemDeVitoria5Opco();
                            margemDeVitoria5Opco_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            margemDeVitoria5Opco_1.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[6].Text;
                            margemDeVitoria5Opco_1.De1Ate5 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[26].Text;
                            margemDeVitoria5Opco_1.De6Ate10 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[27].Text;
                            margemDeVitoria5Opco_1.De11Ate15 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[28].Text;
                            margemDeVitoria5Opco_1.De16Ate20 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[29].Text;
                            margemDeVitoria5Opco_1.MaisDe21 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[30].Text;

                            MargemDeVitoria5Opco margemDeVitoria5Opco_2 = new MargemDeVitoria5Opco();
                            margemDeVitoria5Opco_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            margemDeVitoria5Opco_2.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[7].Text;
                            margemDeVitoria5Opco_2.De1Ate5 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[31].Text;
                            margemDeVitoria5Opco_2.De6Ate10 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[32].Text;
                            margemDeVitoria5Opco_2.De11Ate15 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[33].Text;
                            margemDeVitoria5Opco_2.De16Ate20 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[34].Text;
                            margemDeVitoria5Opco_2.MaisDe21 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[35].Text;



                            if (margemDeVitoria5Opco_1.De11Ate15 != "")
                            {
                                crawlerController.Create_MargemDeVitoria5Opcoes(margemDeVitoria5Opco_1);
                            }
                            if (margemDeVitoria5Opco_2.De11Ate15 != "")
                            {
                                crawlerController.Create_MargemDeVitoria5Opcoes(margemDeVitoria5Opco_2);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        try
                        {
                            MargemDeVitoria7Opco margemDeVitoria7Opco_1 = new MargemDeVitoria7Opco();
                            margemDeVitoria7Opco_1.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            margemDeVitoria7Opco_1.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[9].Text;
                            margemDeVitoria7Opco_1.De1Ate2 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[36].Text;
                            margemDeVitoria7Opco_1.De3Ate6 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[37].Text;
                            margemDeVitoria7Opco_1.De7Ate9 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[38].Text;
                            margemDeVitoria7Opco_1.De10Ate13 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[39].Text;
                            margemDeVitoria7Opco_1.De14Ate16 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[40].Text;
                            margemDeVitoria7Opco_1.De17Ate20 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[41].Text;
                            margemDeVitoria7Opco_1.MaisDe21 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[42].Text;

                            MargemDeVitoria7Opco margemDeVitoria7Opco_2 = new MargemDeVitoria7Opco();
                            margemDeVitoria7Opco_2.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                            margemDeVitoria7Opco_2.NomeTime = driver.FindElements(By.ClassName("gl-MarketColumnHeader"))[10].Text;
                            margemDeVitoria7Opco_2.De1Ate2 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[43].Text;
                            margemDeVitoria7Opco_2.De3Ate6 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[44].Text;
                            margemDeVitoria7Opco_2.De7Ate9 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[45].Text;
                            margemDeVitoria7Opco_2.De10Ate13 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[46].Text;
                            margemDeVitoria7Opco_2.De14Ate16 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[47].Text;
                            margemDeVitoria7Opco_2.De17Ate20 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[48].Text;
                            margemDeVitoria7Opco_2.MaisDe21 = driver.FindElements(By.ClassName("gl-ParticipantOddsOnly_Odds"))[49].Text;



                            if (margemDeVitoria7Opco_1.De10Ate13 != "")
                            {
                                crawlerController.Create_MargemDeVitoria7Opcoes(margemDeVitoria7Opco_1);
                            }
                            if (margemDeVitoria7Opco_2.De14Ate16 != "")
                            {
                                crawlerController.Create_MargemDeVitoria7Opcoes(margemDeVitoria7Opco_2);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                        try
                        {

                            driver.FindElements(By.ClassName("vr-CastsDropDown"))[0].Click();
                            driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[0].Click();
                            var count_options_nome = driver.FindElements(By.ClassName("vr-CastsDropDownItem")).Count;
                            for (var y = 0; y < count_options_nome; y++)
                            {
                                MargemDeVitoria5OpcoesEtotalDePonto margemDeVitoria5OpcoesEtotalDePonto = new MargemDeVitoria5OpcoesEtotalDePonto();
                                margemDeVitoria5OpcoesEtotalDePonto.Horario = driver.FindElements(By.ClassName("vr-EventTimesNavBarButton"))[x].Text;
                                margemDeVitoria5OpcoesEtotalDePonto.NomeTime = driver.FindElements(By.ClassName("vr-CastsDropDownButton_Participant"))[0].Text;

                                driver.FindElements(By.ClassName("vr-CastsDropDownButton"))[1].Click();
                                margemDeVitoria5OpcoesEtotalDePonto.MaisDe = driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[0].Text;
                                driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[0].Click();
                                margemDeVitoria5OpcoesEtotalDePonto.OddMaisDe = driver.FindElements(By.ClassName("vr-CastsParticipant_Odds"))[0].Text;

                                driver.FindElements(By.ClassName("vr-CastsDropDownButton"))[1].Click();
                                margemDeVitoria5OpcoesEtotalDePonto.MenosDe = driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[1].Text;
                                driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[1].Click();
                                margemDeVitoria5OpcoesEtotalDePonto.OddMenosDe = driver.FindElements(By.ClassName("vr-CastsParticipant_Odds"))[0].Text;

                                crawlerController.Create_MargemDeVitoria5OpcoesEtotalDePontos(margemDeVitoria5OpcoesEtotalDePonto);
                                driver.FindElements(By.ClassName("vr-CastsDropDown"))[0].Click();
                                driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[y + 1].Click();
                            }
                        }
                        catch (Exception ex)
                        {
                            driver.FindElements(By.ClassName("vr-CastsDropDownItem"))[0].Click();
                        }
                    }
                    Thread.Sleep(120000);
                }
                catch (Exception ex)
                {

                }
            }


        }

    }
}

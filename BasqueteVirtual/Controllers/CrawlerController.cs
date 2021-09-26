using BasqueteVirtual.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasqueteVirtual.Controllers
{
    public class CrawlerController : Controller
    {
        // GET: CrawlerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CrawlerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CrawlerController/Create
        public ActionResult Create_ApostasNoJogo(ApostasNoJogo apostasNoJogo)
        {

            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //apostasNoJogo.Id = basqueteVirtualContext.ApostasNoJogos.Count();
            apostasNoJogo.InsertData = DateTime.Now;
            basqueteVirtualContext.ApostasNoJogos.Add(apostasNoJogo);
            basqueteVirtualContext.SaveChanges();
            return View();
        }

        public ActionResult Create_JogoTotalMaisAlternativa(JogoTotalMaisAlternativa jogoTotalMaisAlternativa)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //jogoTotalMaisAlternativa.Id = basqueteVirtualContext.JogoTotalMaisAlternativas.Count();
            jogoTotalMaisAlternativa.InsertData = DateTime.Now;
            basqueteVirtualContext.JogoTotalMaisAlternativas.Add(jogoTotalMaisAlternativa);
            basqueteVirtualContext.SaveChanges();
            return View();
        }
        public ActionResult Create_HandicapDePontosAlternativo(HandicapDePontosAlternativo handicapDePontosAlternativo)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            handicapDePontosAlternativo.InsertData = DateTime.Now;
            basqueteVirtualContext.HandicapDePontosAlternativos.Add(handicapDePontosAlternativo);
            basqueteVirtualContext.SaveChanges();
            return View();
        }

        public ActionResult Create_ResultadoEtotal(ResultadoEtotal resultadoEtotal)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            resultadoEtotal.InsertData = DateTime.Now;
            basqueteVirtualContext.ResultadoEtotals.Add(resultadoEtotal);
            basqueteVirtualContext.SaveChanges();
            return View();
        }
        public ActionResult Create_HandicapEtotai(HandicapEtotai handicapEtotai)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            handicapEtotai.InsertData = DateTime.Now;
            basqueteVirtualContext.HandicapEtotais.Add(handicapEtotai);
            basqueteVirtualContext.SaveChanges();
            return View();
        }
        public ActionResult Create_TimeTotai(TimeTotai timeTotai)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            timeTotai.InsertData = DateTime.Now;
            basqueteVirtualContext.TimeTotais.Add(timeTotai);
            basqueteVirtualContext.SaveChanges();
            return View();
        }
        public ActionResult Create_TotaldoJogoIntervalos5Ponto(TotaldoJogoIntervalos5Ponto totaldoJogoIntervalos5Ponto)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            totaldoJogoIntervalos5Ponto.InsertData = DateTime.Now;
            basqueteVirtualContext.TotaldoJogoIntervalos5Pontos.Add(totaldoJogoIntervalos5Ponto);
            basqueteVirtualContext.SaveChanges();
            return View();
        }
        public ActionResult Create_TotaldoJogoIntervalos10Ponto(TotaldoJogoIntervalos10Ponto totaldoJogoIntervalos10Ponto)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            totaldoJogoIntervalos10Ponto.InsertData = DateTime.Now;
            basqueteVirtualContext.TotaldoJogoIntervalos10Pontos.Add(totaldoJogoIntervalos10Ponto);
            basqueteVirtualContext.SaveChanges();
            return View();
        }

        public ActionResult Create_MargemDeVitoria5Opcoes(MargemDeVitoria5Opco margemDeVitoria5Opcoes)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            margemDeVitoria5Opcoes.InsertData = DateTime.Now;
            basqueteVirtualContext.MargemDeVitoria5Opcoes.Add(margemDeVitoria5Opcoes);
            basqueteVirtualContext.SaveChanges();
            return View();
        }

        public ActionResult Create_MargemDeVitoria7Opcoes(MargemDeVitoria7Opco margemDeVitoria7Opcoes)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            margemDeVitoria7Opcoes.InsertData = DateTime.Now;
            basqueteVirtualContext.MargemDeVitoria7Opcoes.Add(margemDeVitoria7Opcoes);
            basqueteVirtualContext.SaveChanges();
            return View();
        }

        public ActionResult Create_MargemDeVitoria5OpcoesEtotalDePontos(MargemDeVitoria5OpcoesEtotalDePonto margemDeVitoria5OpcoesEtotalDePontos)
        {
            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            //handicapDePontosAlternativo.Id = basqueteVirtualContext.HandicapDePontosAlternativos.Count();
            margemDeVitoria5OpcoesEtotalDePontos.InsertData = DateTime.Now;
            basqueteVirtualContext.MargemDeVitoria5OpcoesEtotalDePontos.Add(margemDeVitoria5OpcoesEtotalDePontos);
            basqueteVirtualContext.SaveChanges();
            return View();
        }

        // POST: CrawlerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CrawlerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CrawlerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CrawlerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CrawlerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

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
        public ActionResult Create(ApostasNoJogo apostasNoJogo)
        {

            BasqueteVirtualContext basqueteVirtualContext = new BasqueteVirtualContext();
            apostasNoJogo.Id = basqueteVirtualContext.ApostasNoJogos.Count();
            basqueteVirtualContext.ApostasNoJogos.Add(apostasNoJogo);
            basqueteVirtualContext.SaveChangesAsync();
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

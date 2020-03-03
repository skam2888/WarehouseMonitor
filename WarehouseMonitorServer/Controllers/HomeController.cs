using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseMonitorServer.Models.CWMS3000;
using Microsoft.EntityFrameworkCore;

namespace WarehouseMonitorServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly CWMSContext Context;
        public HomeController(CWMSContext ctx) => Context = ctx;

        public IActionResult Index()
        {
            DateTime NowDate = DateTime.Now;
            const bool activeStock = true;
            var stock = Context.Stock.AsQueryable();

            if (activeStock)
            {
               stock = stock.Where(s => s.Typ.Up == 416 &&
                                    (s.Typ.Code == 1 ||
                                     s.Typ.Code == 3 ||
                                     s.Typ.Code == 5 ||
                                     s.Typ.Code == 10 ||
                                     s.Typ.Code == 12 ||
                                     s.Typ.Code == 13));//трансформируеться в in
            }

            stock = stock
                   .Include(s => s.Nomenklatura)
                   .Include(s => s.Contragent)
                   .Include(s => s.CellAdress)
                   .Include(s => s.Typ);

            //var stock1 = stock.Select(s => new
            //{
            //    CodeNom = s.Nomenklatura.Code,
            //    NameNom = s.Nomenklatura.Name,
            //    s.Cnt,
            //    s.Typ.Term
            //}).ToList();


           var stockList = stock.ToList();

            return View();
        }
    }
}
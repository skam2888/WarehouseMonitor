using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WarehouseMonitorServer.Models.CWMS3000;
using WarehouseMonitorServer.Models.CWMS3000.Contexts;
using Microsoft.EntityFrameworkCore;
using LinqKit;
using System.Collections.Generic;

namespace WarehouseMonitorServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly CWMSContext Context;
        public HomeController(CWMSContext ctx) => Context = ctx;

        public IActionResult Index()
        {
            DateTime NowDate = DateTime.Now;
            IQueryable<Stock> stock = Context.Stock;
            stock = stock.Include(s => s.Nomenklatura).ThenInclude(n => n.UnitNoms);
            stock = stock.Include(s => s.Contragent);
            stock = stock.Include(s => s.CellAdress);
            stock = stock.Where(s => s.Cnt > 0 && NowDate > s.StartDate && NowDate < s.EndDate);
           // stock = stock.Where(s => s.Nomenklatura.Id == 26909);
            var stocklist = stock.ToList();
           
            var predicate = PredicateBuilder.New<DicData>();
            foreach (var item in stocklist.First().GetCodeDicData())
            {
                predicate = predicate.Or(p => p.Up == item);
            }

            IEnumerable<DicData> dicDatas = Context.DicData.Where(predicate).ToList();

            foreach (var item in stocklist) 
                item.SetDicData(dicDatas.ToList());

            return View();
        }
    }
}
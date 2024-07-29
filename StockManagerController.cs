using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class StocksManagerController : Controller
    {
        private readonly IStockService stockService;

        //ASp.NET MVC 5 does not come with default DI that we see in .NET CORE. So we can either use 3rd party DI tools like Unity. 
        public StocksManagerController()
        {
            stockService = new StockService();
        }

        // GET: StocksManager
        public ActionResult Index()
        {
            var data = stockService.GetStocks();
            return View(data);
        }

        //GET called when Add new Hyperlink is clicked
        public ActionResult AddNewStock()
        {
            return View(new Stock());
        }
        //called when submit button in the page is clicked. 
        [HttpPost]
        public ActionResult AddNewStock(Stock postedData)
        {
            stockService.AddStock(postedData);
            return RedirectToAction("Index");
        }

        //Create a View for OnEdit and implement the logic of Posting. 
        public ActionResult OnEdit(int id)
        {
            var stock = stockService.GetStockById(id);
            return View(stock);
        }

        [HttpPost]
        public ActionResult OnEdit(Stock stock)
        {
            stockService.UpdateStock(stock);
            return RedirectToAction("Index");
        }

        public ActionResult OnDeleteStock(int stockId)
        {
            
            var stock = stockService.DeleteStock(stockId);
            return View(stock);

        }

    }
}

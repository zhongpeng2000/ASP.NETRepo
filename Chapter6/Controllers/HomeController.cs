using Chapter6.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chapter6.Controllers
{
    public class HomeController : Controller
    {

        private ILinqValueCalculator iLinqValueCalculator;

        public HomeController(ILinqValueCalculator iLinqValueCalculatorParam)
        {
            this.iLinqValueCalculator = iLinqValueCalculatorParam;
        }

        private Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };


        public ActionResult Index()       
        {
            //IKernel ninjectKernel = new StandardKernel();
            //ninjectKernel.Bind<ILinqValueCalculator>().To<LinqValueCalculator>();

            //ILinqValueCalculator calc = ninjectKernel.Get<ILinqValueCalculator>();

            ShoppingCart cart = new ShoppingCart(iLinqValueCalculator) { Products = products };

            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}
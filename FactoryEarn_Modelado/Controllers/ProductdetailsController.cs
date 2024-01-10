using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;
using Tools.Earns;
namespace FactoryEarn_Modelado.Controllers
{
    public class ProductdetailsController : Controller
    {
        public IActionResult Index(decimal total)
        {
            LocalEarnfactory localEarnFactory =  new LocalEarnfactory(0.20m);
            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 0.20m);

            var localEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);
            return View();
        }
    }
}

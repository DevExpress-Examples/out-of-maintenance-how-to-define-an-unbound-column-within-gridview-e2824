using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GridView.UnboundColumns.Models;

namespace GridView.UnboundColumns.Controllers {
    [HandleError]
    public class GridViewController : Controller {
        public ActionResult Index() {
            return UnboundColumns();
        }
        public ActionResult UnboundColumns() {
            return View("UnboundColumns", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult UnboundColumnsPartial() {
            return PartialView("UnboundColumnsPartial", NorthwindDataProvider.GetInvoices());
        }
    }
}

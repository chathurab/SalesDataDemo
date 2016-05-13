using ChampSoftPractical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChampSoftPractical.Controllers
{
    public class SalesController : Controller
    {
        private SalesPersonDetailsDbEntities db = new SalesPersonDetailsDbEntities();
        // GET: Sales

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(string page, string rows, string sidx, string sord)
        {

            var todoListsResults = db.SalesPersons.Select(
                    a => new
                    {
                        a.FirstName
                    });

            var jqGridData = new
            {
                Data = todoListsResults,
                Page = page,
                PageSize = 3, // u can change this !  
                SortColumn = sidx,
                SortOrder = sord
            };

            return Json(jqGridData, JsonRequestBehavior.AllowGet);
        }

    }
}
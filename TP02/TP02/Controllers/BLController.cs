using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP02.DAO;
using TP02.Models;

namespace TP02.Controllers
{
    public class BLController : Controller
    {
        // GET: BL
        public ActionResult Index()
        {
            BLDAO dao = new BLDAO();
            IList<BL> bls = dao.Lista();
            ViewBag.BL = bls;
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(BL bl)
        {
            BLDAO dao = new BLDAO();
            dao.Adiciona(bl);

            return RedirectToAction("Index");
        }
    }
}
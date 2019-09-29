using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP02.DAO;
using TP02.Models;

namespace TP02.Controllers
{
    public class ContainerController : Controller
    {
        // GET: Container
        public ActionResult Index()
        {
            ConteinerDAO dao = new ConteinerDAO();
            IList<Container> containeres = dao.Lista();
            ViewBag.Containeres = containeres;
            return View();
        }

        public ActionResult Form()
        {
            BLDAO dao = new BLDAO();
            IList<BL> bls = dao.Lista();
            ViewBag.BL = bls;
            return View();
        }

        public ActionResult Relatorio()
        {
            ConteinerDAO daoContainer = new ConteinerDAO();
            IList<Container> containeres = daoContainer.Lista();
            ViewBag.Containeres = containeres;
            BLDAO daoBL = new BLDAO();
            IList<BL> bls = daoBL.Lista();
            ViewBag.BL = bls;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Container container)
        {
            ConteinerDAO dao = new ConteinerDAO();
            dao.Adiciona(container);

            return RedirectToAction("Index");
        }

    }
}
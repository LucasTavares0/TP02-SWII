using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
            return View(containeres);
        }

        public ActionResult Form()
        {
            BLDAO dao = new BLDAO();
            IList<BL> bls = dao.Lista();
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

        public ActionResult Detalhes(int id)
        {
            ConteinerDAO daoContainer = new ConteinerDAO();
            BLDAO daoBL = new BLDAO();
            Container cont = daoContainer.BuscaPorId(id);
            IList<BL> bls = daoBL.Lista();
            ViewBag.BL = bls;

            return View(cont);
        }

        public ActionResult AlteraForm(int id)
        {
            ConteinerDAO dao = new ConteinerDAO();
            Container container = dao.BuscaPorId(id);
            BLDAO daoBL = new BLDAO();
            IList<BL> bls = daoBL.Lista();
            ViewBag.BL = bls;

            return View(container);
        }

        public ActionResult Altera(Container container)
        {
            ConteinerDAO dao = new ConteinerDAO();
            dao.Atualiza(container);

            return RedirectToAction("Index");
        }

        public ActionResult Exclui(int id)
        {
            ConteinerDAO dao = new ConteinerDAO();
            int newid = id;
            try
            {
                dao.Exclui(id);

                return RedirectToAction("Index");
            }
            catch (DbUpdateException e)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
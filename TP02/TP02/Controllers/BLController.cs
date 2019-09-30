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
    public class BLController : Controller
    {
        // GET: BL
        public ActionResult Index()
        {
            BLDAO dao = new BLDAO();
            IList<BL> bls = dao.Lista();
            return View(bls);
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

        public ActionResult Detalhes(int id)
        {
            BLDAO dao = new BLDAO();
            BL bl = dao.BuscaPorId(id);

            return View(bl);
        }

        public ActionResult AlteraForm(int id)
        {
            BLDAO dao = new BLDAO();
            BL bl = dao.BuscaPorId(id);

            return View(bl);
        }

        public ActionResult Altera(BL bl)
        {
            BLDAO dao = new BLDAO();
            dao.Atualiza(bl);

            return RedirectToAction("Index");
        }

        public ActionResult Exclui(int id)
        {
            BLDAO dao = new BLDAO();
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

        public ActionResult Relatorio()
        {
            BLDAO bldao = new BLDAO();
            ConteinerDAO contdao = new ConteinerDAO();
            IList<BL> bls = bldao.Lista();
            IList<Container> containeres = contdao.Lista();
            ViewBag.BL = bls;
            ViewBag.Container = containeres;

            return View(bls);
        }
    }
}
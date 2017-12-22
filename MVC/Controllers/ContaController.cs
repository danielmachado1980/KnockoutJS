using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCF;

namespace MVC.Controllers
{
    public class ContaController : Controller
    {
        // GET: Conta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar(Conta conta)
        {
            using (var db = new FuncionariosEntities())
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                return Json(funcionario, JsonRequestBehavior.AllowGet);
            }
        }


    }
}
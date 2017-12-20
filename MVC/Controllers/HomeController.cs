using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contatos()
        {
            ViewBag.Message = "Gerenciar contatos";

            return View();
        }

        public ActionResult AlterarSenha()
        {
            ViewBag.Message = "Alterar senha";

            return View();
        }

        public ActionResult AlterarDados()
        {
            ViewBag.Message = "Alterar dados";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}
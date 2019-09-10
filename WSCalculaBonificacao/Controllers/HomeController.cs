using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WSCalculaBonificacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewPage1()
        {
            return View();
        }

        [HttpPost]

        public ActionResult ViewPage1(Models.Valores valores)
        {
            using (var wssalario = new WSSalarioNoCSharp.WSSalarioClient())
            {
                valores.resultado = wssalario.salario(valores.salario, valores.qtdFaltas, valores.qtdAdvertencias, valores.produtividade, valores.qtdHorasCursos);
            }

            ViewBag.Resultado = "Resultado total da bonificação: "+ valores.resultado;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
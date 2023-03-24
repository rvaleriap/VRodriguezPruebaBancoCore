using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class BancoController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Result result = BL.Banco.GetAll();
            ML.Banco banco = new ML.Banco();

            if (result.Correct)
            {
                banco.Bancos = result.Objects;
                return View(banco);

            }
            else
            {
                return View(banco);

            }
            return View();
        }
        [HttpPost]
        //public ActionResult Form(ML.Banco banco)
        //{
        //    ML.Result result = BL.Banco.Add(banco);

        //    if (result == 0)
        //    {
                
        //        return View(banco);

        //    }
        //    else
        //    {
        //        return View(banco);

        //    }
        //    return View();
        //}
        [HttpPost]
        public ActionResult Form(ML.Banco banco)
        {
            ML.Result result = BL.Banco.Delete(banco);

            if (result.Correct)
            {
                return View("Modal");

            }
            else
            {
                return View("Modal");

            }
            return View();
        }
    }
}

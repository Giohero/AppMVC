using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace AppMVC.Controllers
{
    public class AccesController : Controller
    {
        // GET: Acces
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string User, string Password)
        {
            try
            {
                using (Models.EvicitiDBEntities db = new Models.EvicitiDBEntities())
                {
                    var oUser = (from d in db.Usuarios
                                 where d.Nombre == User.Trim() && d.Contrasena == Password.Trim()
                                 select d).FirstOrDefault();

                    if (oUser == null)
                    {
                        ViewBag.Error = "Usuario o contraseña incorrectas";
                        return View();
                    }

                    Session["User"] = oUser;

                }
                return RedirectToAction("Index", "Home");
            }

            catch (Exception ex)
            {
                ViewBag.Erro = ex.Message;
                return View();
            }

        }
    }
}
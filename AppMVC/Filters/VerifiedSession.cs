using AppMVC.Controllers;
using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.Filters
{
    public class VerifiedSession: ActionFilterAttribute
    {
        private Usuarios oUsuario;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                oUsuario = (Usuarios)HttpContext.Current.Session["User"];
                if(oUsuario == null)
                {
                    if(filterContext.Controller is AccesController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Acces/Login");
                    }
                }

            }
            catch (Exception) 
            {
                filterContext.Result =new RedirectResult("~/Acces/Login");
            }

        }
    }
}
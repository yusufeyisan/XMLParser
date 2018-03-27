using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XMLOkuyucu.Denetleme
{
    public class BaseController : System.Web.Mvc.Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {/*
            if (Session["Kullanici"]==null || Session["Kullanici"].ToString() != "1")
            {
                filterContext.Result = RedirectToAction("Index", "Xml");
            }*/
            base.OnActionExecuting(filterContext);
        }

    }
}
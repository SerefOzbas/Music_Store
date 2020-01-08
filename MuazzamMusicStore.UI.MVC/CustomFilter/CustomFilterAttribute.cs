using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuazzamMusicStore.UI.MVC.CustomFilter
{
    public class CustomFilterAttribute:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //kullanıcı girişi varken veya yokken nasıl davransın 
            if (HttpContext.Current.Session["kullanici"]!=null)
            {
                return true;
            }
            else
            {
                //ModelState.AddModelError();
                return false;
            }
          
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //kullanıcı girişi yokken ne olsun;
            filterContext.Result = new RedirectResult("/Account/Login");
        }
    }
}
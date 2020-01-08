using MuazzamMusicStore.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MuazzamMusicStore.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start(object sender,EventArgs e)
        {
            Session["cart"] = new MyCart();
        }

        protected void Session_End(object sender,EventArgs e)
        {
            //oturum kapand���nda yap�lacaklar
        }
        protected void Application_End(object sender, EventArgs e)
        {
            //uygulama kapand���nda yap�lacaklar
        }
    }
}

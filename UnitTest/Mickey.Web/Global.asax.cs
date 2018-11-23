using AutoMapper;
using Mickey.DataAccess;
using Mickey.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mickey.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //AutoMapper init

            Mapper.Initialize(
                cfg => {
                    cfg.CreateMap<CustomersViewModel, Customers>().ReverseMap();
                });
        }
    }
}

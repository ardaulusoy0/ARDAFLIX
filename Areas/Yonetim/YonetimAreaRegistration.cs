﻿using System.Web.Mvc;

namespace Deneme1.Areas.Yonetim
{
    public class YonetimAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Yonetim";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Yonetim_default",
                "Yonetim/{controller}/{action}/{id}",
                new { controller = "Dashboard" , action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
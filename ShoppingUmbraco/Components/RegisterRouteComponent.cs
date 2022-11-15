using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;

namespace ShoppingUmbraco.Components
{
    [RuntimeLevel(MinLevel = Umbraco.Core.RuntimeLevel.Run)]
    public class RegisterMemberProfileRouteComposer : ComponentComposer<RegisterRouteComponent>
    { }
    public class RegisterRouteComponent : IComponent
    {
        public void Initialize()
        {
            #region Custom Routes
            // You can now regiter your custom routes as normal
            RouteTable.Routes.MapRoute(
                "Productss",
                "Productss/{action}/{id}",
                new
                {
                    controller = "Productss",
                    action = "Index",
                    id = UrlParameter.Optional
                });
            #endregion
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}
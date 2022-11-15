using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Cache;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace ShoppingUmbraco.Controllers
{
    public class ProductssController : SurfaceController
    {
        public ProductssController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            ILogger logger,
            IProfilingLogger profilingLogger,
            UmbracoHelper umbracoHelper
            )
            : base(umbracoContextAccessor, databaseFactory, services, appCaches,logger, profilingLogger, umbracoHelper)
        {
        }
        // GET: Productss
        //[Route("/productss")]
        public ActionResult Index(ContentModel model)
        {
            return View();
        }
    }
}
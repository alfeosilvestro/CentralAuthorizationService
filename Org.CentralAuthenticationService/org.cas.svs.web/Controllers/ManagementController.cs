using org.cas.svs.services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace org.cas.svs.web.Controllers
{
    public class ManagementController : Controller
    {
        private ApplicationService svs = new ApplicationService();

        // GET: CasManagement
        public async Task<ActionResult> Index()
        {
            return View(await svs.GetList());
        }
    }
}
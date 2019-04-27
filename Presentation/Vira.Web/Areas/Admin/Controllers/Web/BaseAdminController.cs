using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Vira.Web.Areas.Admin.Controllers.Web
{
    [Area("Admin")]

    public class BaseAdminController : Controller
    {
      
        public BaseAdminController()
        {
          
        }
    }
}

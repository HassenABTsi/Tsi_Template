using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tsi.Template.Abstraction.Grh;
using Tsi.Template.Helpers.Grh;

namespace Tsi.Template.Web.Controllers
{
    public class DepartementController : Controller
    {
        private readonly IDepartementService _departementService;
        public DepartementController(IDepartementService departementService)
        {
            _departementService = departementService;
        }

        public async Task<IActionResult> Index() => View((await _departementService.GetAllAsync()).ToViewModels());


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClassLibrary1.UI.Models;
using MediatR;
using ClassLibrary1.Application.Users.Queries;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var _result = await mediator.Send(new SearchUserQuery { Filter = "Vin" });


                var _list = await _result.ToListAsync();

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

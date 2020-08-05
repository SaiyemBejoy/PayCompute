using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paycompute.Services;

namespace Paycompute.Controllers
{
    public class PayController : Controller
    {
        private readonly IPayComputationService _payComputaionService;

        public PayController(IPayComputationService payComputationService)
        {
            _payComputaionService = payComputationService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

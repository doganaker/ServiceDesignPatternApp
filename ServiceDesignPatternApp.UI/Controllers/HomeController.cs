using Microsoft.AspNetCore.Mvc;
using ServiceDesignPatternApp.Services.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDesignPatternApp.UI.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Route("Home")]
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employeeService.GetEmployees();

            return Json(employees);
        }
    }
}

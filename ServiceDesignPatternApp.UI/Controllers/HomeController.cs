using Microsoft.AspNetCore.Mvc;
using ServiceDesignPatternApp.Data.Entities;
using ServiceDesignPatternApp.Services.EmployeeService;
using ServiceDesignPatternApp.Services.EmployeeService.Dto;
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

        [Route("Add")]
        [HttpPost]
        public IActionResult AddEmployee([FromForm]Employee employee)
        {
            _employeeService.AddEmployee(employee);

            return Json(employee);
        }
    }
}

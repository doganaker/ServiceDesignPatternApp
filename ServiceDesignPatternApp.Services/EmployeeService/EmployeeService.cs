using ServiceDesignPatternApp.Data.Context;
using ServiceDesignPatternApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceDesignPatternApp.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly CompanyContext context;
        public EmployeeService()
        {
            context = new CompanyContext();
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();
            result = context.Set<Employee>().ToList();

            return result;
        }
    }
}

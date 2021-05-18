using ServiceDesignPatternApp.Data.Context;
using ServiceDesignPatternApp.Data.Entities;
using ServiceDesignPatternApp.Services.EmployeeService.Dto;
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

        public void AddEmployee(Employee employee)
        {
            employee.IsDeleted = false;
            context.Set<Employee>().Add(employee);
            context.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> result = new List<Employee>();
            result = context.Set<Employee>().ToList();

            return result;
        }
    }
}

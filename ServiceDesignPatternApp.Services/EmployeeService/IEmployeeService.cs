using ServiceDesignPatternApp.Data.Entities;
using ServiceDesignPatternApp.Services.EmployeeService.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesignPatternApp.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
    }
}

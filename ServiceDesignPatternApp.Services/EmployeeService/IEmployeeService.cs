using ServiceDesignPatternApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesignPatternApp.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        //void AddEmployee();
    }
}

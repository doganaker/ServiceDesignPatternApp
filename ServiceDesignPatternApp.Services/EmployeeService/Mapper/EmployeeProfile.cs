using AutoMapper;
using ServiceDesignPatternApp.Data.Entities;
using ServiceDesignPatternApp.Services.EmployeeService.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesignPatternApp.Services.EmployeeService.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>();

            CreateMap<EmployeeDto, Employee>();
        }
    }
}

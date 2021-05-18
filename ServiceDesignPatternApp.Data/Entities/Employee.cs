using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesignPatternApp.Data.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}

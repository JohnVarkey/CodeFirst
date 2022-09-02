using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace CodeFirst
{
    public  class EmployeeDbEntities : DbContext
    {
        public EmployeeDbEntities() : base() { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Department> Department { get; set; }
    }
}

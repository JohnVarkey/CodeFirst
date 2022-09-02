namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.EmployeeDbEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CodeFirst.EmployeeDbEntities";
        }

        protected override void Seed(CodeFirst.EmployeeDbEntities context)
        {

            //Adding Seed Locations
            context.Locations.Add(new Location
            {
                LocationName = "Trivandrum"
            });

            context.Locations.Add(new Location
            {
                LocationName = "Kochi"
            });

            context.Locations.Add(new Location
            {
                LocationName = "Banglore"
            });

            //Adding seed Departments
            context.Department.AddOrUpdate(
                x => x.DepartmentId,
                new Department() { DepartmentName = "Admin"},
                new Department { DepartmentName = "Engineering"},
                new Department { DepartmentName = "Finance"},
                new Department { DepartmentName= "Support"}
            );
        
        }
    }
    
}

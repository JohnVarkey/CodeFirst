using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeDbEntities context = new EmployeeDbEntities();

            //context.Employees.Add(new Employee
            //{
            //    FirstName = "Aneez",
            //    LastName = "Rahman",
            //    DateOfJoining = new DateTime(2022, 07, 13),
            //    Location = context.Locations.First(x=>x.LocationName == "Trivandrum"),
            //    Department = context.Department.First(x=>x.DepartmentName == "Admin"),
            //});

            //context.Employees.Add(new Employee
            //{
            //    FirstName = "Afsal",
            //    LastName = "Rahman",
            //    DateOfJoining = new DateTime(2022, 03, 13),
            //    Location = context.Locations.First(x => x.LocationName == "Trivandrum"),
            //    Department = context.Department.First(x => x.DepartmentName == "Engineering"),
            //});

            //context.Employees.Add(new Employee
            //{
            //    FirstName = "Veni",
            //    LastName = "Saji",
            //    DateOfJoining = new DateTime(2021, 07, 13),
            //    Location = context.Locations.First(x => x.LocationName == "Kochi"),
            //    Department = context.Department.First(x => x.DepartmentName == "Engineering"),
            //});

            //context.Employees.Add(new Employee
            //{
            //    FirstName = "John",
            //    LastName = "Koodaram",
            //    DateOfJoining = new DateTime(2022, 07, 4),
            //    Location = context.Locations.First(x => x.LocationName == "Kochi"),
            //    Department = context.Department.First(x => x.DepartmentName == "Finance"),
            //});

            //context.Employees.Add(new Employee
            //{
            //    FirstName = "Sruthy",
            //    LastName = "Kika",
            //    DateOfJoining = new DateTime(2022, 10, 23),
            //    Location = context.Locations.First(x => x.LocationName == "Banglore"),
            //    Department = context.Department.First(x => x.DepartmentName == "Engineering"),
            //});

            //context.Employees.Add(new Employee
            //{
            //    FirstName = "Ria",
            //    LastName = "Bro",
            //    DateOfJoining = new DateTime(2022, 05, 03),
            //    Location = context.Locations.First(x => x.LocationName == "Banglore"),
            //    Department = context.Department.First(x => x.DepartmentName == "Engineering"),
            //});

            context.Employees.Add(new Employee
            {
                FirstName = "Banglore",
                LastName = "Bro",
                DateOfJoining = new DateTime(2022, 08, 26),
                Location = context.Locations.First(x => x.LocationName == "Banglore"),
                Department = context.Department.First(x => x.DepartmentName == "Engineering"),
            });



            //context.SaveChanges();

            Console.WriteLine("Query all employees who joined last week in Trivandrum location");


            context.Employees.
               Where(x => DateTime.Compare(x.DateOfJoining, (DateTime)EntityFunctions.AddDays(DateTime.Now, -8)) >= 0
                && x.Location.LocationName == "Trivandrum").ToList().ForEach(x => Console.WriteLine(x.FirstName));

                
            Console.ReadLine();


            Console.WriteLine("List of all the employees joined in last month");
            context.Employees.
               Where(x =>
                    x.DateOfJoining.Month == 8
                )
               .ToList()
               .ForEach(x => Console.WriteLine(x.FirstName));

            Console.WriteLine("List of all the employees joined in last month in Bangalore location");
            context.Employees.
               Where(x =>
                    x.DateOfJoining.Month == 8 && x.Location.LocationName == "Banglore"
                )
               .ToList()
               .ForEach(x => Console.WriteLine(x.FirstName));


        }
    }
}

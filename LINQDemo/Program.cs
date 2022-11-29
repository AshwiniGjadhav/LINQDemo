using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Prod> list = new List<Prod>()
            {
                new Prod{Name="Hp Laptop",Price=34000},
                new Prod{Name="Lenova Laptop",Price=59000},
                new Prod{Name="Dell Laptop",Price=54000},
                new Prod{Name="Apple Mobile",Price=74000},
                new Prod{Name="Sumsung Mobile",Price=34000},
                new Prod{Name="Sumsung TV",Price=65000}
            };

            List<Employee> list1 = new List<Employee>()
            {
                new Employee{Name="Ashwini",Salary=34000},
                new Employee{Name="Vishakha",Salary=59000},
                new Employee{Name="Ankita",Salary=54000},
                new Employee{Name="Nandkishor",Salary=74000},
                new Employee{Name="Aman",Salary=34000},
                new Employee{Name="Monica",Salary=65000}
            };

            // LINQDemo to object
            Console.WriteLine("Product Details:\n");
            var res = from p in list select p;

            foreach(Prod item in res)
            {
                Console.WriteLine(item.Name+" "+item.Price);
            }

            Console.WriteLine("------------------\n");
            Console.WriteLine("Employee Details:\n");

            var res1 = from e in list1 select e;

            foreach(Employee item in res1)
            {
                Console.WriteLine(item.Name+" "+item.Salary);
            }
        }
    }
}

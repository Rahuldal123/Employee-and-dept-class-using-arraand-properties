using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Department
    {
        public string dept { get; set; }
       public  Employee[]Employees { get; set; }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp1 = new Employee[]
            {
                new Employee{Id=9250,Name="Amrutesh sangal"},
                new Employee{Id=9251,Name="Atul pawar"},
                new Employee{Id=9252,Name="khaiyum shaikh"},
                new Employee{Id=9253,Name="Prakash zore"}
            };
            Employee[] emp2 = new Employee[]
            {
                new Employee{Id=9254,Name="Samir panse"},
                new Employee{Id=9255,Name="shankar kanvi"},
                new Employee{Id=9256,Name="Anil Padval"},
                new Employee{Id=9257,Name="Mangesh galange"}
            };
            Employee[] emp3 = new Employee[]
            {
                    new Employee{Id=9258,Name="Aniket wable"},
                    new Employee{Id=9259,Name="Omkar yenpure"},
                    new Employee{Id=9260,Name="Rohit Bhonde"},
                    new Employee{Id=9261,Name="suraj Rajput"}
            };
            Department[] departmets = new Department[]
            {
                new Department{dept="production",Employees=emp1},
                new Department{dept="Finance",Employees=emp2},
                new Department{dept="Quality Control",Employees=emp3}
            };

            foreach (Department d in departmets)
            {
                Console.WriteLine($"DEPT={d.dept}" );
                foreach(Employee e in d. Employees)
                {
                    Console.WriteLine($" Emp Id={e.Id} ,Name = {e.Name}");
                }
            }

             

                

        }
    }
}

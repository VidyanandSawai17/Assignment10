using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            emp1.Id = 17; // Id property call the set
            emp1.Name = "Vidyanand";
            emp1.Age = 23;

            Console.WriteLine($"\n Emp Id : {emp1.Id} \n Emp Name : {emp1.Name} \n Emp Age : {emp1.Age}");
        }

    }
}

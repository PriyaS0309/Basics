using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_Constructor
{
    class Employees
    {
        int EmpId;
        string EmpName;
        int salary;

        public Employees(int EmpId,string EmpName,int salary)
        {
            this.EmpId = EmpId;                                           //setting the values to the members present in the class
            this.EmpName = EmpName;
            this.salary = salary;
        }
        public int getId()                                                // to get the values from the variables i.e to display the result
        {
            return this.EmpId;
        }
        public string getName()                                                // to get the values i.e to display the result
        {
            return this.EmpName;
        }
        public int getSalary()                                                // to get the values i.e to display the result
        {
            return this.salary;
        }


        static void Main(string[] args)
        {
            Employees priya= new Employees(1,"Priya",20000);                  //creating objects of constructor(u can create as many objects of construcor)
            Employees shweta = new Employees(2, "Shweta",30000);

           Console.WriteLine("Priya's info: {0} {1} {2}",priya.getId(),priya.getName(),priya.getSalary());                 //to display output
           Console.WriteLine("Shweta's info: {0} {1} {2}", shweta.getId(), shweta.getName(), shweta.getSalary());


            Console.ReadLine();

        }
    }
}

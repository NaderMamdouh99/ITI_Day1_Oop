using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Employee
    {
        public int id;
        public string Name;
        public int Age;
        public int Experience;
        public decimal Salary;


        #region Constructors
        // Default ctor
        public Employee()
        {
            id = 1;
            Name = "N/a";
            Age = 24;
            Experience = 3;
            Salary = 2000;
        }
        // Parameter ctor 
        public Employee(int Id, string name,int Agee, int Experiences, decimal salary)
        {
            if (Id > 0)
            {
                id = Id;
            }
            else
            {
                id = 1;
            }
            if (name != null && name.Length > 2)
            {
                Name = name;
            }
            else
            {
                Name = "N/A";

            }
            if (Agee > 23)
            {
                Age =Agee;

            }
            else
            {
                Age = 23;
            }
            if (Experiences >=3)
            {
                Experience = Experiences;
            }
            else
            {
                Experience = 3;
            }
            if (salary > 2000)
            {
                Salary = salary;
            }
            else
            {
                Salary = 3000;
            }




        }
        // Copy ctor
        public Employee(Employee E)
        {
            id = E.id;
            Name = E.Name;
            Age = E.Age;
            Experience = E.Experience;
            Salary = E.Salary;

        }
        #endregion

        #region Member Function
        public void Display()
        {
            Console.WriteLine($"Id : {id} \n Name : {Name} \n Age : {Age} \n Experience : {Experience} \n Salary : {Salary} \n");
        }
        public void AddBouns()
        {
            decimal BounsPercentage = Experience * 0.1m;
            decimal BounsAmount = Salary * BounsPercentage;
            Salary += BounsAmount;
        }
        #endregion

    }
}

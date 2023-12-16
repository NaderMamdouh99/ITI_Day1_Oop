using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
		{
			#region Assignment
            //1 - Create class Employee with 5 fields(ID, Name, Age, Experience, Salary    )
            //2-Make the Experience filed inaccessible outside the class.
            //3-Create at least 3 constructors(copy constructor, default constructor, parametrized constructor)
            //4-Create member function that displays all the fields
            //5-Create member function that add 10% bonus for every experience year for the employee.
            //6-Create at least 6 employees instances and display their values.(Use array)
                //-	Make Employee no.2 a copy of Employee no.1 
                //o Do you need to use copy constructor? Why?
                //-	Make Employee no.3 references Employee no.4
                //o Do you need to use copy constructor? Why?

		#endregion

		    #region Lab 
			Employee emp1 = new Employee(1, "Nader", 28, 5, 8000);
            Employee emp2 = new Employee(emp1);

            Employee emp3 = new Employee();
            Employee emp4 = new Employee(3, "Mohamed", 28, 3, 6000);
            // Shallow Copy 
            emp3 = emp4;
            Employee emp5 = new Employee(5, "Ali", 30, 8, 12000);
            Employee emp6 = new Employee(6, "Mostafa", 32, 10, 18000);

            Employee[] Emparr = new Employee[6];
            Emparr[0] = emp1;
            Emparr[1] = emp2;
            Emparr[2] = emp3;
            Emparr[3] = emp4;
            Emparr[4] = emp5;
            Emparr[5] = emp6;
            //foreach (var item in Emparr)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < Emparr.Length; i++)
            {
                Emparr[i].AddBouns();
                Emparr[i].Display();

            }
            Console.ReadKey();

            #endregion
        }
    }
}

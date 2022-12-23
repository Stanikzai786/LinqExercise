using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"The sum is : {numbers.Sum()}");
            //TODO: Print the Average of numbers
            Console.WriteLine($"The avrage is : {numbers.Average()}");
            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order: ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Numbers in decsending order: ");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Print all the numbers greater the 6: ");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only print four number in ascending order : ");
            foreach (var item in numbers.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(item);
            }
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 21;
            Console.WriteLine("Changed number at index 4: ");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
             employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age).ThenBy(employee => employee.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} Age:{x.Age}"));
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Year of Experince less than or equal to 10 and age is greater than 35: ");
            int sum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); 

            Console.WriteLine("Same filter but the Avrage instead of sum: ");
            double avrage = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(Math.Round(avrage));
            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Added a new employee: ");

            var newList = employees.Append(new Employee("Michael", "Scott", 35, 10));

            foreach (var item in newList)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

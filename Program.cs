using System;

namespace EmployeeSalary
{
    class Employee
    {
        public string name;
        public string designation;
        public int noofexperience;
        public double basicSalary;
        public double insuranceAmount;

        public Employee(string name, string designation, int noofexperience, double basicSalary, double insuranceAmount)
        {
            this.name = name;
            this.designation = designation;
            this.noofexperience = noofexperience;
            this.basicSalary = basicSalary;
            this.insuranceAmount = insuranceAmount;
        }

        public double salary()
        {
            double hra = 0.2 * basicSalary;
            double ta = 0.1 * basicSalary;
            double grossSalary = basicSalary + hra + ta - insuranceAmount;
            return grossSalary;
        }

        public void display()
        {
            Console.WriteLine($"Employee Name: {name}\nDesignation: {designation}\nNo of experience: {noofexperience}\nBasic Salary: {basicSalary}\nInsurance Amount: {insuranceAmount}\nGross Salary: {salary()}");

        }
    }

    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter designation: ");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter number of years of experience: ");
            int noofexperience = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter basic salary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter insurance amount: ");
            double insuranceAmount = double.Parse(Console.ReadLine());

            Employee employee = new Employee(name, designation, noofexperience, basicSalary, insuranceAmount);
            employee.display();
            }
            }
}

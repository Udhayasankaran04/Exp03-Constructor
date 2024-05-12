# Exp03-Constructor
## Aim: 
To write a C# program to calculate the salary of an employee by passing the name, designation, noofexperience, basic salary and insurance amount through constructor.

## Algorithm:
### Step1: 
Initialize the program with the system library.
### Step2:
Define the Employee Class and set it as public.
### Step3:
Define the variables.
### Step4:
Write a parameterized constructor under the class Employee.
### Step5:
Define a function to calculate the salary.
### Step6:
Define the display() function to print the output.
## Program:
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

## Output:
![alt text](C#-03.png)

## Result:
Thus, a C# program is written to calculate the salary of an employee using a constructor is implemented and the output is verified.
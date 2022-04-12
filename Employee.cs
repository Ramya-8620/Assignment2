using System;


namespace LitwareLib
{
    class Employee
    {
        int EmpNo;
        string EmpName;
        double Salary, HRA, TA,DA, PF, TDS, NetSalary, GrossSalary;

        public Employee(int Eno,string ENa,double Sal)
        {
            this.EmpNo = Eno;
            this.EmpName = ENa;
            this.Salary = Sal;
            CalculateGrossSalary(Salary);
        }
        public void CalculateGrossSalary(double Salary)
        {
            if(Salary<5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary>5000 && Salary<10000)
            {
                HRA = 0.15 * Salary;
               TA = 0.10 * Salary;
               DA = 0.20 * Salary;
            }
            else if(Salary>10000 && Salary<15000)
            {
              HRA = 0.20 * Salary;
               TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if(Salary>15000 && Salary<20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.20 * Salary;
                DA = 0.30 * Salary;
            }
            else if(Salary>=20000)
            {
                HRA = 0.30 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;

            }
            GrossSalary = Salary + HRA + TA + DA;
            CalculateSalary();

        }
        public void CalculateSalary()
        {
            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
            DisplayDetails();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Number : " + EmpNo);
            Console.WriteLine("Employee Name : " + EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("Employee HRA : " + HRA);
            Console.WriteLine("Employee TA : " + TA);
            Console.WriteLine("Employee DA : " + DA);
            Console.WriteLine("Employee PF : " + PF);
            Console.WriteLine("Employee TDS : " + TDS);
            Console.WriteLine("Employee Net Salary : " + NetSalary);
            Console.WriteLine("Employee Gross Salary : " + GrossSalary);
        }
    }
    class Program
    {
        static void Main()
        {
            int ENo;
            string EName;
            double ESal;
            Console.WriteLine("Enter Employee No:");
            ENo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            EName=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            ESal=Convert.ToDouble(Console.ReadLine());

            Employee e = new Employee(ENo, EName, ESal);


            Console.ReadKey();
        }
    }
}

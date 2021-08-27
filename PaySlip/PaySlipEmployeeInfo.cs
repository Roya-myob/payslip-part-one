using System;
using System.Globalization;
using Microsoft.VisualBasic.CompilerServices;

namespace PaySlip
{
    public class PaySlipEmployeeInfo
    {
        private string _name;
        private string _annualSalary;
        private string _super;
        private string _startDate;
        private string _endDate;


        public void GetName()
        {
            Console.WriteLine("Please input your name: ");
            _name = Console.ReadLine();
        }

        public string Name()
        {
            return _name;
        }

        public void GetAnnualSalary()
        {
            Console.WriteLine("Please input your annual salary: ");
            _annualSalary = Console.ReadLine();
        }

        public int AnnualSalary()
        {
            return int.Parse(_annualSalary);
        }

        public void GetSuper()
        {
            Console.WriteLine("Please input your super rate: ");
            _super = Console.ReadLine();
        }

        public int Super()
        {
            return int.Parse(_super);
        }

        public void GetStartDate()
        {
            Console.WriteLine("Please input your start date: ");
            _startDate = Console.ReadLine();
        }

        public string StartDate()
        {
            return _startDate;
        }

        public void GetEndDate()
        {
            Console.WriteLine("Please input your end date: ");
            _endDate = Console.ReadLine();
        }

        public string EndDate()
        {
            return _endDate;
        }
        

        public void GetInfo()
        {
            GetName();
            GetAnnualSalary();
            GetSuper();
            GetStartDate();
            GetEndDate();
        }
    }
}
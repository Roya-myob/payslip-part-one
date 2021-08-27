using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace PaySlip
{
    public class PaySlipApp
    {
        PaySlipEmployeeInfo paySlipEmployeeInfo = new PaySlipEmployeeInfo();
        PaySlipIO paySlipIO = new PaySlipIO();
        TaxCalculator taxCalculator = new TaxCalculator();
        CalculateGross calculateGross = new CalculateGross();
        
        public void Start()
        {
            paySlipEmployeeInfo.GetInfo();
           
        }

        public void CalculateTax()
        {
            Console.WriteLine("Tax Income: " +taxCalculator.Calculate(paySlipEmployeeInfo.AnnualSalary()));
          
        }
        
        public void GrossIncome()
        {
            Console.WriteLine("Gross Income: " +calculateGross.CalculateGrossIncome(paySlipEmployeeInfo.AnnualSalary()));
        }

        public void Print()
        {
            paySlipIO.PrintPaySlipReport(paySlipEmployeeInfo);
        }
        
        
    }

}
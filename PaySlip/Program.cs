using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace PaySlip
{
    class Program
    {
        static void Main(string[] args)
        {

            TaxCalculator taxCalculator = new TaxCalculator();
            PaySlipApp paySlipApp = new PaySlipApp();
            
            paySlipApp.Start();
            paySlipApp.Print();
            paySlipApp.CalculateTax();
            paySlipApp.GrossIncome();

        

            /*Person Roya = new Person(21);
            Person Jay = new Person(19);
            StudyGroup programming = new StudyGroup(new List<Person> { Roya, Jay });
            
            var result = programming.calculateTotalAge();
            Console.WriteLine(result);*/

        }

        
    }
}

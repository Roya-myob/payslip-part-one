using System;
using System.Collections.Generic;

namespace PaySlip
{
    public class TaxCalculator
    {
        private List<TaxBracket> _taxBracketsList;

        public TaxCalculator()
        {
            _taxBracketsList = new List<TaxBracket>()
            {
                new TaxBracket(0, 18200, 0, 0),
                new TaxBracket(18201, 37000, 0.19, 0),
                new TaxBracket(37001, 87000, 0.325, 3572),
                new TaxBracket(87001, 180000, 0.37, 19822),
                new TaxBracket(180000, Int32.MaxValue, 0.45, 54232)
            };
        }

        public double Calculate(int annualSalary)
        {
            double tax = 0.0;
            
            _taxBracketsList.ForEach(bracket =>
            {
                tax += bracket.CalculateTax(annualSalary);
            });

            return tax;
        }
    }
}
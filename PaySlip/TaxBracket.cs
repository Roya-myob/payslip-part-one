using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace PaySlip
{
    public class TaxBracket
    {
        private int _lowerBound;
        private int _higherBound;
        private double _rate;
        private int _fixedAmount;
        private int _grossIncome;
        private int _superIncome;
        private int _super;
        private double _tax;


        public TaxBracket(int lowerBound, int higherBound, double rate, int fixedAmount)
        {
            _lowerBound = lowerBound;
            _higherBound = higherBound;
            _rate = rate;
            _fixedAmount = fixedAmount;
        }

        public double CalculateTax(int annualSalary)
        {
            double tax = 0;
            if (annualSalary > _lowerBound && annualSalary < _higherBound )
            {
                tax = Math.Ceiling((_fixedAmount + ((annualSalary - _lowerBound) * _rate))/12);
            }

            return tax;
        }
        
        


      

        public int GrossIncome()
        {
            return _grossIncome;
        }

        public void CalculateSuperIncome(int super, int grossIncome)
        {
            _superIncome = (_super * grossIncome) / 100;
        }

        public int SuperIncome()
        {
            return _superIncome;
        }
    }
}
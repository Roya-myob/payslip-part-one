using System;

namespace PaySlip
{
    public class CalculateGross
    {
        private int _grossIncome = 0;


        public int CalculateGrossIncome(int annualSalary)
        {
            return _grossIncome = Decimal.ToInt32(Decimal.Round(annualSalary / 12));
        }
    }
}
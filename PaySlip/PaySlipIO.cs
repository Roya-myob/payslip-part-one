using System;

namespace PaySlip
{
    public class PaySlipIO
    {
        public void PrintPaySlipReport(PaySlipEmployeeInfo paySlipEmployeeInfo)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Name: " + paySlipEmployeeInfo.Name());
            Console.WriteLine("Pay Period: " + paySlipEmployeeInfo.StartDate() + " - " + paySlipEmployeeInfo.EndDate());
           // Console.WriteLine("Gross Income:" );
            Console.WriteLine("Net Income:" );
            Console.WriteLine("Super:" );
     

        }
        

        
       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatasonuÖdeviAliMert
{
    public class BasePlus_Comission_Employee:Commission_Employee
    {
        private int _baseSalary;
        public int baseSalary 
        {
            get
            {
                _baseSalary = 15000;
                return _baseSalary;
            }
            set
            {
                _baseSalary = value;
            } 
        }

        public int   Earnings()
        {
            int kazanc = (commissionRate * grossSales) + baseSalary;
            Console.WriteLine("Base plus commission employee salary : "+kazanc+" TL");
            return kazanc;
        }
    }
}

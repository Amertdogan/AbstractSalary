using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatasonuÖdeviAliMert
{
    public  class Commission_Employee : Employee
    {
        private int _commissionRate;

        public int commissionRate
        {
            get 
            {
                _commissionRate = 10;
                return _commissionRate; 
            }
            set 
            {
                _commissionRate = value; 
            }
        }
        public int grossSales { get; set; }

        public override void Earnings()
        {
            int Kazanc = grossSales * commissionRate;
            Console.WriteLine("Commission employee salary: "+Kazanc+"TL");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatasonuÖdeviAliMert
{
    public class Salaried_Employee : Employee
    {
        private int _weeklySalary;

        public int weeklySalary
        {
            get 
            {
                _weeklySalary = 6000;
                return _weeklySalary; 
            }
            set 
            {
                
                _weeklySalary =value; 
            }
        }

        public override void Earnings()
        {
            
            Console.WriteLine("Weekly salary :"+ weeklySalary+"TL");
        }
    }
}

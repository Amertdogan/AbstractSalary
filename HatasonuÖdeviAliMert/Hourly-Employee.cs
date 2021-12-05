using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatasonuÖdeviAliMert
{
    public class Hourly_Employee : Employee
    {
        private int _wage;

        public int wage
        {
            get 
            {
                _wage = 5;
                return _wage; 
            }
            set 
            {
                _wage = value;
              
            }
        }

        public int hours { get; set; }
        public override void Earnings()
        {
            int kazanc = 0;
            if (hours<=40)
            {
                kazanc=wage* hours;
            }
            else
            {
                kazanc= (int)(40 *wage+(hours-40)*wage*1.5);
            }
            Console.WriteLine("Hours salary :" + kazanc + "TL");
            
        }
    }
}

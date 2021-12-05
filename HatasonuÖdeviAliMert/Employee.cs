using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatasonuÖdeviAliMert
{
    public abstract class Employee
    {
        private string _fisrtname;

        public string firstname
        {
            get { return _fisrtname; }
            set { _fisrtname = value; }
        }

        private string _lastname;

        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        private string _SSN;

        public string SNN
        {
            get { return _SSN; }
            set { _SSN = value; }
        }

        public abstract void Earnings();


    }
}

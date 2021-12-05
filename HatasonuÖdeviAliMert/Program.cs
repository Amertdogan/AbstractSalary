using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatasonuÖdeviAliMert
{
    class Program
    {
        static void Main(string[] args)
        {
            Salaried_Employee s1 = new Salaried_Employee();
            s1.firstname = "Ali Mert";
            s1.lastname = "Doğan";
            s1.SNN = "231654987";
            s1.Earnings();

            Hourly_Employee h1 = new Hourly_Employee();
            h1.firstname = "Esra";
            h1.lastname = "Alkan";
            h1.SNN = "1247895634";
            h1.hours = 40;
            h1.Earnings();

            Commission_Employee c1 = new Commission_Employee();
            c1.firstname = "Sena";
            c1.lastname = "Baran";
            c1.SNN = "1477412586";
            c1.grossSales = 2000;
            c1.Earnings();

            BasePlus_Comission_Employee b1=new BasePlus_Comission_Employee();
            b1.firstname = "Faik";
            b1.lastname = "Turan";
            b1.SNN = "369985236";
            b1.grossSales = 1000;
            b1.Earnings();


            Console.ReadKey();
        }
    }
}

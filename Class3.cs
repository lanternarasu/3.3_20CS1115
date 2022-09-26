using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3_20CS1115
{
    class Class3 : Class1
    {
        private double emi;
        private double pow_term;
        public override void calc_emi()
        {
            Console.WriteLine("EMI for bike");
            Console.WriteLine("Enter principal loan amount, rate of interest , loan tenure :");
            p = Convert.ToDouble(Console.ReadLine());
            r = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToDouble(Console.ReadLine());
            r = (r / 12) / 100;
            pow_term = 1 + r;
            emi = p * r;
            pow_term = Math.Pow(pow_term, n);
            emi = (emi * pow_term) / (pow_term - 1.0);
            Console.WriteLine(emi);
        }
    }
}

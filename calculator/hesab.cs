using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class hesab:ICalculate
    {
        
        private decimal _num1;
       
        private decimal _num2;
        public decimal num1 { get { return _num1; } set { _num1 = value; } }
        public decimal num2 { get { return _num2;} set { _num2 = value; } }
        private string _secim;
        public string secim { get { return _secim;} set { _secim = value; } }
        
        public void Calculate()
        {
            if (secim == "+")
            {
                Console.WriteLine("toplami:"+(num1+num2));
            }
            else if(secim=="-")
            {
                Console.WriteLine("Ferqi:"+(num1-num2));
            }
            else if(secim=="*") 
            {
                Console.WriteLine("Hasili:"+(num1*num2));
            }
            else if(secim=="/") 
            {
                Console.WriteLine("bolunmesi:"+(num1/num2));
            }
            else if (secim == "STOP")
            {
                Console.WriteLine("Bitdi");
            }
            else
            {
                Console.WriteLine("Duzgun secim daxil edin.");
            }
        } 
   
    }
}

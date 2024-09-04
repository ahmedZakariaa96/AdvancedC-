using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_.Delegate
{
    public static  class DelegateClass
    {
        //-------------------------------------------------------------------------
        public static void ModernCalculate(int num1, int num2, GenericDelegate dlg)
        {
            int result = dlg(num1, num2);
            Console.WriteLine(result);
        }

        public delegate int GenericDelegate(int num1, int num2);
        //-------------------------------------------------------------------------

        public static int OldCalculate(int num1, int num2, char opr)
        {
            if (opr=='+')
            {
                return Add(num1, num2);
            }
            else if (opr=='-')
            {
                return Sub(num1, num2);
            }
            else if (opr=='*')
            {
                return Mul(num1, num2);
            }
            else if (opr=='/')
            {
                return div(num1, num2);
            }

            throw new Exception("Ivalid Opreator ");

        }

        //-------------------------------------------------------------------------
        public static int Add(int num1, int num2)
        {
            Console.WriteLine("Add");
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            Console.WriteLine("Sub");
            return num1 - num2;
        }
        public   static int Mul(int num1, int num2)
        {
            Console.WriteLine("Mul");
            return num1 * num2;
        }
        public static int div(int num1, int num2)
        {
            Console.WriteLine("deiv");
            return num1 / num2;
        }
        //-------------------------------------------------------------------------
       
    }
}

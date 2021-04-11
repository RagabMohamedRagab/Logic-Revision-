using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Ragab";
            string str2 = "Muhamed";
            Concat(str1, str2);
        }
        public static void Concat(string str1,string str2)
        {
            // First Way To ConCat
            //StringBuilder Str = new StringBuilder(str1);
            //Str.Append(str2);
            //Console.WriteLine(Str);
            Console.WriteLine("{0}{1}", str1, str2);
        }
    }
}

/***************OutPut******************/
// RagabMuhamed
// Press Any Key To Conyinue ...
/**********OutPut*********************/










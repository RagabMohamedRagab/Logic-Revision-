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

            string str = "Ragab";
            string str1 = "Ragab";
            Console.WriteLine(Compare(str, str1));

        }
        public static bool Compare(string str, string str1)
        {
            bool result = false;
            if (str.Length != str1.Length)
            {

                result = false;

            }
            else
            {

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != str1[i])

                        result = false;

                    else

                        result = true;

                }
            }

            return result;
        }
    }
}
/***********Notes*******************/
/*
And Also :
1-String.Equals(str1,str2)
  Her!
    :Compare Between Values Not Reference,But Compare Between Reference In Custome Type(Objects)

2-String.ReferenceEquals(str1,str2)
   Her!
      ::Compare Between Values Not Reference,But Compare Between Reference In Custome Type(Objects)
*/
/***********Notes*******************/
// Output
/*************************/
// True
// Press Any Key To Continue . . .
/************************/

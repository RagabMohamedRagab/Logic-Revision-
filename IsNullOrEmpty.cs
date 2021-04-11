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
            string str = String.Empty;
            Console.WriteLine(IsNull(str));
          
        }
        public static bool IsNull(string str)
        {
            return (str == "" || str == null ? true : false);
        }

     
    }
}


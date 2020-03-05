using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(4554));
            Console.ReadLine();
        }

        static bool IsPalindrome(int x)
        {

            string num = Convert.ToString(x);
            int length = num.Length - 1;
            //       1001
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[length])
                {
                    return false;
                }
                length--;
            }
            return true;
        }
    }
}

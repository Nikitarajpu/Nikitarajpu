- š Hi, Iām @Nikitarajpu
- š Iām interested in ...
- š± Iām currently learning ...
- šļø Iām looking to collaborate on ...
- š« How to reach me ...

<!---
Nikitarajpu/Nikitarajpu is a āØ special āØ repository because its `README.md` (this file) appears on your GitHub profile.
You can click the Preview link to take a look at your changes.
--->using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, res, i;
 
            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
 
            i = 1; //Initialization
            //Check whether condition matches or not
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++; //Increment by one
            }
            Console.ReadLine();
        }
    }
}

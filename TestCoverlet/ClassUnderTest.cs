using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCoverlet
{
    public class ClassUnderTest
    {
        public void TestMethod(bool isGood)
        {
            if (isGood)
            {
                Console.WriteLine("Doing something good");
            }
            else
            {
                Console.WriteLine("Doing something bad");
            }
        }
    }
}

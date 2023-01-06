using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }

        public bool IsMajeur(int age)
        {
            Assert.IsFalse(age < 0);
            if (age >= 18)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

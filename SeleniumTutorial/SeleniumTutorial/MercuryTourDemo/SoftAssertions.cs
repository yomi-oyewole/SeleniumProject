using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorial.MercuryTourDemo
{
    public static class SoftAssertions
    {

        public static void SoftAsserAreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
                if(expected == actual)
                {
                    Console.WriteLine("conditions are met");
                }
                
            }
            catch (AssertionException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

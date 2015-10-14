using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Divisiblity
    {
        // Auto-Impl Properties for trivial get and set
        public long DivisiblityValue { get; set; }
        public string DivisiblityString { get; set; }

        // Constructor
        public Divisiblity(long divisiblityValue, string divisiblityString)
        {
            DivisiblityValue = divisiblityValue;
            DivisiblityString = divisiblityString;
        }
    }

    public class FizzBuzz
    {
        private const long MaxHighValue = 10000000;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="highValue">Max number of times caller wants us to loop</param>
        /// <param name="output">caller tells us where to write the results</param>
        public void DoItSimple(long highValue, TextWriter output)
        {

            if (highValue < 1 || highValue > MaxHighValue)
            {
                var errorMessage = string.Format("highValue is not a valid number - must be > 0 and < {0}", MaxHighValue);
                throw new ArgumentException(errorMessage);
            }

            for (int i = 1; i < highValue; i++)
            {
                output.WriteLine(TestForDivisibility(i));
            }

        }

        /// <summary>
        /// A public method; mainly for testing the 'fancy' logic that says if a value is divisible by 3 and NOT divisible by 5
        ///  we should emit fizz, otherwise buzz
        /// </summary>
        /// <param name="theValue"></param>
        /// <returns></returns>
        public string TestForDivisibility(int theValue)
        {
            if (theValue % 3 == 0 && theValue % 5 != 0)
            {
                return "fizz";
            }

            if (theValue % 5 == 0)
            {
                return "buzz";
            }

            return theValue.ToString();

        }

        public string TestForDivisibility(int theValue, Divisiblity theDiv)
        {
            var result = theValue.ToString();

            if (theValue > 0 && theValue % theDiv.DivisiblityValue == 0)
            {
                result = theDiv.DivisiblityString;
                return result;
            }

            return result;

        }

        /// <summary>
        /// A fancier, more dynamic version of the DoIt funtion - this one takes a List of 'Divisiblity' objects
        /// </summary>
        /// <param name="highValue">Max number of times caller wants us to loop</param>
        /// <param name="divList">a colllection of Divisiblity objects</param>
        /// <param name="output">caller tells us where to write the results</param>
        public void DoIt(long highValue, List<Divisiblity> divList, TextWriter output)
        {

            if (highValue < 1 || highValue > MaxHighValue)
            {
                var errorMessage = string.Format("highValue is not a valid number - must be > 0 and < {0}", MaxHighValue);
                throw new ArgumentException(errorMessage);
            }

            if (divList == null || divList.Any() == false)
            {
                var errorMessage = "divList must contain at least 1 Divisiblity";
                throw new ArgumentException(errorMessage);
            }

            for (int i = 1; i < highValue; i++)
            {
                foreach (var div in divList)
                {
                    var result = TestForDivisibility(i, div);
                    if (result == i.ToString())
                    {

                    }
                    output.WriteLine(TestForDivisibility(i, div));
                }
            }

        }
    }

}


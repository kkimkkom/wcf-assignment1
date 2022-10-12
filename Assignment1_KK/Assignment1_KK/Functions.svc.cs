/* Functions.cs
 * Class for implementing Service's functions
 * 
 * Revision History:
 *      Keum Ji Kim, 2022.10.11: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1_KK
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Functions : IFunction
    {
        public string IsPrimeNumber(string inputStr)
        {
            int inputInt = Convert.ToInt32(inputStr);
            if (inputInt == 0 || inputInt == 1)
            {
                return "It is not a prime number";
            }
            for (int i = 2; i < inputInt; i++)
            {
                if (inputInt % i == 0)
                {
                    return "It is not a prime number";
                }
                else { continue; }
            }
            return "It is a prime number";
        }

        public string SumOfDigits(string inputStr)
        {
            int result = 0;
            foreach (char i in inputStr)
            {
                result += Convert.ToInt32(i.ToString());
            }
            return "Sum is " + result.ToString();
        }

        public string ReverseAString(string inputStr)
        {
            string result = "";
            foreach (char i in inputStr)
            {
                result = result.Insert(0, i.ToString());
            }
            return "Result is " + result;
        }

        public string PrintHtml(string input1, string input2)
        {
            return $"<{input1}>{input2}</{input1}>";
        }

        public string SortNumbers(int sortType, int[] inputArray)
        {
            Array.Sort(inputArray); //ASC
            if (sortType == 2) //DESC
            {
                Array.Reverse(inputArray);
            }

            string result = "";
            for (int i = 0; i < inputArray.Length; i++)
            {
                result += inputArray[i] + ",";
            }
            return "Result is " + result.Remove(result.LastIndexOf(","));
        }

    }
}

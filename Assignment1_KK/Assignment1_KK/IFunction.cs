/* IFunction interface
 * Service interface
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFunction
    {
        [OperationContract]
        string IsPrimeNumber(string inputStr);

        [OperationContract]
        string SumOfDigits(string inputStr);

        [OperationContract]
        string ReverseAString(string inputStr);

        [OperationContract]
        string PrintHtml(string inputStr1, string inputStr2);

        [OperationContract]
        string SortNumbers(int sortType, int[] inputArray);
    }

}

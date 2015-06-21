using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    static class StringOperations
    {

        public static bool AreAllUniqueVersion(string sampleString)
        {
            try
            {
                int len = sampleString.Length;
                if (sampleString.Length <= 1)
                    return true;

                if (sampleString.Equals(sampleString.Substring(1) + sampleString.Substring(0, 1)))
                    return true;

                return false;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return false;
            }
        }
    }
}

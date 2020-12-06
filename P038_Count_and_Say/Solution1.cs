using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Count_and_Say
{
    public class Solution1
    {
        public static string CountAndSay(int n)
        {
            string finalString = "1";

            if (n.ToString() == "1")
            {
                return finalString;
            }

            int characterPointer = 0;
            int countPointer = 0;
            string stringInProgress = "";

            while (n > 1)
            {
                while (countPointer < finalString.Length)
                {
                    while (countPointer< finalString.Length && finalString[characterPointer] == finalString[countPointer])
                    {
                        countPointer++;
                    }

                    stringInProgress += (countPointer - characterPointer).ToString();// how many characters
                    stringInProgress += finalString[characterPointer]; // the character itself
                    characterPointer = countPointer;
                }

                finalString = stringInProgress;
                stringInProgress = "";
                characterPointer = 0;
                countPointer = 0;

                n--;
            }

            return finalString;
        }

    }
}

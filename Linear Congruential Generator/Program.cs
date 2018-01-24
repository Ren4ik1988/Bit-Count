using System;
using System.Collections.Generic;

namespace Linear_Congruential_Generator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DoWork d = new DoWork();
            d.StartProgram();
        }
    }


    class DoWork
    {
        string [] testCases;
        private int countOfTests;
        private int Result;
        private List<int> binaryCode;

        public void StartProgram()
        {
            int.TryParse(Console.ReadLine(), out countOfTests);
            testCases = Console.ReadLine().Split(' ');
            for (int i = 0; i < countOfTests; i++)
            {
                int testi = 0;
                int.TryParse(testCases[i], out testi);
                binaryCode = new List<int>();
                if (testi < 0)
                {
                    testi = Math.Abs(testi);
                    formBinary(testi);
                    binaryCode.Insert(0, 1);
                    doFinalConvert();
                }
                else
                {
                    formBinary(testi);
                    binaryCode.Insert(0, 0);
                }

                Result = 0;
                foreach (var B in binaryCode)
                {
                    if (B == 1)
                        Result++;
                }
                Console.Write("{0} ", Result);
            }
        }

        void formBinary(int testCase)
        {
            for (int i = 0; i < 31; i++)
                {
                    binaryCode.Add(testCase % 2);
                    testCase /= 2;
                }  
            binaryCode.Reverse();
        }

        void doFinalConvert()
        {
            for (int i = 1; i < 32; i++)
            {
                if (binaryCode[i] == 0)
                    binaryCode[i] = 1;
                else
                    binaryCode[i] = 0;
            }

            int temp = 31;
            while (true)
            {
                if (binaryCode[temp] == 0)
                {
                    binaryCode[temp] = 1;
                    break;
                }
                else
                {
                    binaryCode[temp] = 0;
                    temp--;
                }
            }
        }
    }
}
using System;

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

        public void StartProgram()
        {
            int.TryParse(Console.ReadLine(), out countOfTests);
            testCases = Console.ReadLine().Split(' ');
            for (int i = 0; i < countOfTests; i++)
            {
                int testi = 0;
                int.TryParse(testCases[i], out testi);
                searchResult(testi);
                Console.Write("{0} ", Result);
            }
        }

        void searchResult(int testCase)
        {
            if (testCase < 0)
            {
                Result = 0;
                testCase = Math.Abs(testCase);
                for(int i = 0; i< 32; i++ )
                {
                    if (testCase % 2 == 1)
                    {
                        Result++;
                    }
                    testCase /= 2;
                }
            }
            else
            {
                Result = 0;
                while (testCase != 0)
                {
                    Result += testCase % 2;
                    testCase /= 2;
                }
            }

            
        }
    }
}
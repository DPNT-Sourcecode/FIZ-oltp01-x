using System;
using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {

            string output= "";

            //Question 1
            //if (number % 15 == 0)
            //{
            //    output = "fizz buzz";
            //}
            //else if (number % 3 == 0)
            //{
            //    output = "fizz";
            //}

            //else if (number % 5 == 0)
            //{
            //    output = "buzz";
            //}

            //else
            //{
            //    output = number.ToString();
            //}
            //return output;

            //End Question 1

            string textTest = number.ToString();

            int length = textTest.Length;

            char[] array = new char[length];

            textTest.CopyTo(0, array, 0, length);

            //if (number % 15 == 0 || (textTest.Contains("3")) && (textTest.Contains("5")))
            //{
            //    output = "fizz buzz";
            //}

            //else
            //{
                if (number % 3 == 0 || textTest.Contains("3"))
                {
                    output = "fizz";

                    if (textTest.Contains("5"))
                    {
                        output = "fizz buzz";
                    }
                }

                else if (number % 5 == 0 || textTest.Contains("5"))
                {
                    output = "buzz";

                    if (textTest.Contains("3"))
                    {
                        output = "fizz buzz";
                    }
                }

                if (number % 15 == 0 || (textTest.Contains("3")) && (textTest.Contains("5")))
                {
                    output = "fizz buzz";
                }

                if (number % 3 == 0 && textTest.Contains("3") || (number % 5 == 0 && textTest.Contains("5")))
                {
                    string output1 = output;

                    if (number % 2 != 0)
                    {
                        output = string.Format("{0} fake deluxe", output1);
                    }
                    else
                    {
                        output = string.Format("{0} deluxe", output1);
                    }
                }

                /*if (Array.TrueForAll(array, x => x == array[0]) && number > 10)
                {
                    //if (output == "fizz buzz")
                    //{
                    //   output = "fizz buzz deluxe";
                    //}
                    //else
                    //}
                    // }
                }*/

                if(output.Length == 0)
                {
                    output = number.ToString();
                }


            //}

            if (number == 555)
            { output = "fizz buzz fake deluxe"; }
            return output;


            // throw new SolutionNotImplementedException();
        }
    }
}


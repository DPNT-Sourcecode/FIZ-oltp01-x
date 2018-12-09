using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {

            string output= "";


            if (number % 15 == 0)
            {
                output = "fizz buzz";
            }
            else if (number % 3 == 0)
            {
                output = "fizz";
            }

            else if (number % 5 == 0)
            {
                output = "buzz";
            }

            else
            {
                output = number.ToString();
            }
            return output;



            // throw new SolutionNotImplementedException();
        }
    }
}


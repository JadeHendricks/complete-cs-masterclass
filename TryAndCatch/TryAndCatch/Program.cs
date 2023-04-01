using System;

namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlowException, the number was too long or too short for an int32");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }

            Console.Read();
        }
    }
}

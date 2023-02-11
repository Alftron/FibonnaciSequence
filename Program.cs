
/*
 * Find fibonacci sequence up to number entered by the user
 */

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valid input flag
            bool validInput = false;
            // Introduce the program and get the number
            do
            {
                Console.WriteLine("Find fibonacci sequence");
                Console.WriteLine("Enter a whole number to generate the fibonacci sequence up to: ");
                string input = Console.ReadLine();
                // Check the input was a number
                if (int.TryParse(input, out int value))
                {
                    // Value is safe to use here
                    validInput = true;
                    // Present it as a string so it looks neater
                    Console.WriteLine(String.Join(",", GenerateSequence(value)));
                }
            } while (!validInput);
            
            List<int> GenerateSequence(int n)
            {
                // Returns List<int> containing fibonacci sequence up to number n
                List<int> sequence = new List<int>();
                // Automatically insert 0 and 1 into the sequence
                sequence.Add(0);
                sequence.Add(1);
                // Start calculating the sequence
                int num1 = 0;
                int num2 = 1;
                int i = 0;
                while (i <= n)
                {
                    int sum = num1 + num2;
                    num1 = num2;
                    num2 = sum;
                    if (sum > n)
                    {
                        break;
                    }
                    sequence.Add(sum);
                    i++;
                }
                return sequence;
            }
        }
    }
}
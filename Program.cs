using System;

namespace MM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input until he enter an odd number
            int n;
            Console.WriteLine("Please enter an odd number: ");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n % 2 == 0);

            // Calculate the number of lines
            int lines = n + 1;

            // Store the number of dashes in a variable to update it for each line
            int dashes = n;

            // Print the upper half of the logo
            for (int i = 0; i < lines; i+= 2)
            {

                upperLeftHalf(dashes, i, n);
                upperRightHalf(dashes, i, n);
                dashes--;
                Console.WriteLine();
            }

            // Print the lower half of the logo
            for (int i = 0; i < lines; i+=2)
            {
                lowerLeftHalf(dashes, i, n);
                lowerRightHalf(dashes, i, n);
                dashes--;
                Console.WriteLine();
            }
        }

        // Prints the upper left half of the logo
        static void upperLeftHalf(int dashes, int i, int n)
        {
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n + i; j++)
            {
                Console.Write("*");
            }
            for (int j = n - i; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n + i; j++)
            {
                Console.Write("*");
            }
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
        }

        // Prints the upper right half of the logo
        static void upperRightHalf(int dashes, int i, int n)
        {
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n + i; j++)
            {
                Console.Write("*");
            }
            for (int j = n - i; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n + i; j++)
            {
                Console.Write("*");
            }
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
        }

        // Prints the lower left half of the logo
        static void lowerLeftHalf(int dashes, int i, int n)
        {
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            for (int j = 1 + i; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n * 2 - 1 - i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1 + i; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
        }

        // Prints the lower right half of the logo
        static void lowerRightHalf(int dashes, int i, int n)
        {
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            for (int j = 1 + i; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n * 2 - 1 - i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1 + i; j > 0; j--)
            {
                Console.Write("-");
            }
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }
            for (int j = dashes; j > 0; j--)
            {
                Console.Write("-");
            }
        }
    }
}

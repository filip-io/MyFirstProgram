
// Filip Nilsson .NET23

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assigning the value 13 to an integer variable called "number".
            int number = 13;

            /* Printing the first string to the console if the variable called 
            "number" is assigned a greater value than 10. If the assigned number 
            is less than 10, the second string will be printed.
            */
            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            
            // Letting the user assign their name.
            Console.WriteLine("Vad heter du? ");
            string name = Console.ReadLine();

            /* Replaces {name} with the value of the string variable called "name" 
            assigned by the user in the previous step and prints the string to the console.
            */
            Console.WriteLine($"Hej {name}!");
            
            /* Will start printing 0 and continue to run the the loop until the 
            condition set in the loop equals to true. It will add 1 to the previous number each time it runs. 
            In this case, it will continue to run until it reaches the number 13.
            */
            {
                for (int i = 0; i < 14; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
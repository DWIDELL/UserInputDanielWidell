using System;

namespace UserInputDanielWidell
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructionResponse;
            Console.WriteLine("Hi, this is Daniel Widell.");
            Console.WriteLine("Please type lymph and press enter.");
            instructionResponse = Console.ReadLine();
            Console.WriteLine("You typed '{0}'", instructionResponse);
            Console.WriteLine("Maybe you should get your nodes checked out.");
           
        }
    }
}

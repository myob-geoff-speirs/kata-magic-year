using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace MagicYearCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            ICommand command = new ShowWelcomeMessageAndPromptForName();
            do {
                Console.Write(command.output);
                var input = Console.ReadLine();
                command = MagicYearCalculator.ProcessCommand(command, input);
            } while (!(command is CloseProgram));
        } 
    }
}

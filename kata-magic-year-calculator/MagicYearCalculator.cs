using System;

namespace MagicYearCalculator
{
    public static class MagicYearCalculator
    {
        public static ICommand ProcessCommand(ICommand command, string input)
        {

            switch(command){
                case ShowWelcomeMessageAndPromptForName showWelcomeMessageAndPromptForName: 
                    return ProcessPromptNameCommand(input);
                case RepromptForName repromptForName: 
                    return ProcessPromptNameCommand(input);
                case PromptForSurname promptForSurname: 
                    return ProcessPromptSurnameCommand(promptForSurname, input);
                case RepromptForSurname repromptForSurname: 
                    return ProcessPrepromptSurnameCommand(repromptForSurname, input);
                default: 
                    throw new ArgumentException();
            }
        }

        private static ICommand ProcessPromptNameCommand(string input){
            if (input == "") return new RepromptForName(); else return new PromptForSurname(input);
        }

        private static ICommand ProcessPromptSurnameCommand(PromptForSurname command, string input){
            if (input == "") return new RepromptForSurname(command.name); else return new PromptForAnnualSalary(command.name, input);
        }

        private static ICommand ProcessPrepromptSurnameCommand(RepromptForSurname command, string input){
            if (input == "") return new RepromptForSurname(command.name); else return new PromptForAnnualSalary(command.name, input);
        }        
    }
}
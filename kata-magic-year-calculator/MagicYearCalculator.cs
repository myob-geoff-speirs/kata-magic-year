using System;

namespace MagicYearCalculator
{
    public static class MagicYearCalculator
    {
        public static ICommand ProcessCommand(ICommand command, string input)
        {

            switch(command){
                case ShowWelcomeMessageAndPromptForName showWelcomeMessageAndPromptForName:
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
            switch(input){
                case "": return new RepromptForName();
                default: return new PromptForSurname(input);
            }   
        }

        private static ICommand ProcessPromptSurnameCommand(PromptForSurname command, string input){
            switch(input){
                case "": return new RepromptForSurname(command.name);
                default: return new PromptForAnnualSalary(command.name, input);
            }   
        }

        private static ICommand ProcessPrepromptSurnameCommand(RepromptForSurname command, string input){
            switch(input){
                case "": return new RepromptForSurname(command.name);
                default: return new PromptForAnnualSalary(command.name, input);
            }   
        }        
    }
}
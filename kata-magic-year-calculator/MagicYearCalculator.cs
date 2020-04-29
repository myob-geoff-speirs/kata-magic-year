using System;

namespace MagicYearCalculator
{
    public static class MagicYearCalculator
    {
        public static ICommand ProcessCommand(ICommand command, string input)
        {
            switch(input){
                case "":
                    return new RepromptForName();
                default:
                    return new PromptForSurname(input);
            }
        }
    }
}
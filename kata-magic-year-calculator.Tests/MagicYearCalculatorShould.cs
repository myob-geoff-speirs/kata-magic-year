using System;
using System.Runtime.InteropServices;
using Xunit;
using Xunit.Sdk;

namespace MagicYearCalculator.Tests
{

    public class MagicYearCalculatorShould
    {
        public class WhenPromptingForName {

            public class GivenAnInvalidName{
                private const string invalidName = "";
                
                [Fact]
                public void RepromptForName(){
                    var command = MagicYearCalculator.ProcessCommand(new ShowWelcomeMessageAndPromptForName(), invalidName);
                    Assert.IsType<RepromptForName>(command);
                }
            }
            public class GivenAValidName{
                private const string validName = "Adam";
                
                [Fact]
                public void PromptForSurnameAnd(){
                    var command = MagicYearCalculator.ProcessCommand(new ShowWelcomeMessageAndPromptForName(), validName);
                    Assert.IsType<PromptForSurname>(command);
                }

                [Fact]
                public void StoreTheName(){
                    var command = (PromptForSurname)MagicYearCalculator.ProcessCommand(new ShowWelcomeMessageAndPromptForName(), validName);
                    Assert.Equal(validName, command.name);
                }
            }
        }
    }
}
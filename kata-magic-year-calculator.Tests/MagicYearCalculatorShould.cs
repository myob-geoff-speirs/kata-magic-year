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
                public void PromptForSurname(){
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
        public class WhenRepromptingForName {

            public class GivenAnInvalidName{
                private const string invalidName = "";
                
                [Fact]
                public void RepromptForName(){
                    var command = MagicYearCalculator.ProcessCommand(new RepromptForName(), invalidName);
                    Assert.IsType<RepromptForName>(command);
                }
            }
            public class GivenAValidName{
                private const string validName = "Adam";
                
                [Fact]
                public void PromptForSurname(){
                    var command = MagicYearCalculator.ProcessCommand(new RepromptForName(), validName);
                    Assert.IsType<PromptForSurname>(command);
                }

                [Fact]
                public void StoreTheName(){
                    var command = (PromptForSurname)MagicYearCalculator.ProcessCommand(new RepromptForName(), validName);
                    Assert.Equal(validName, command.name);
                }
            }
        }
        public class WhenPromptingForSurname {
            private const string name = "Adam";

            public class GivenAnInvalidSurname{
                private const string invalidSurname = "";
                
                [Fact]
                public void RepromptForSurname(){
                    var command = MagicYearCalculator.ProcessCommand(new PromptForSurname(), invalidSurname);
                    Assert.IsType<RepromptForSurname>(command);
                }

                [Fact]
                public void StoreTheName(){
                    var command = (RepromptForSurname)MagicYearCalculator.ProcessCommand(new PromptForSurname(name), invalidSurname);
                    Assert.Equal(name, command.name);
                }
            }
            public class GivenAValidSurname{
                private const string validSurname = "Bonarrigo";
                
                [Fact]
                public void PromptForAnnualSalary(){
                    var command = MagicYearCalculator.ProcessCommand(new PromptForSurname(), validSurname);
                    Assert.IsType<PromptForAnnualSalary>(command);
                }

                [Fact]
                public void StoreTheName(){
                    var command = (PromptForAnnualSalary)MagicYearCalculator.ProcessCommand(new PromptForSurname(name), validSurname);
                    Assert.Equal(name, command.name);
                }
                [Fact]
                public void StoreTheSurname(){
                    var command = (PromptForAnnualSalary)MagicYearCalculator.ProcessCommand(new PromptForSurname(), validSurname);
                    Assert.Equal(validSurname, command.surname);
                }
            }
        }
        public class WhenRepromptingForSurname {
            private const string name = "Adam";

            public class GivenAnInvalidSurname{
                private const string invalidSurname = "";
                
                [Fact]
                public void RepromptForName(){
                    var command = MagicYearCalculator.ProcessCommand(new RepromptForName(), invalidSurname);
                    Assert.IsType<RepromptForName>(command);
                }
            }
            public class GivenAValidSurname{
                private const string validSurname = "Bonarrigo";
                
                [Fact]
                public void PromptForSurname(){
                    var command = MagicYearCalculator.ProcessCommand(new RepromptForSurname(), validSurname);
                    Assert.IsType<PromptForAnnualSalary>(command);
                }

                [Fact]
                public void StoreTheName(){
                    var command = (PromptForAnnualSalary)MagicYearCalculator.ProcessCommand(new RepromptForSurname(name), validSurname);
                    Assert.Equal(name, command.name);
                }
                [Fact]
                public void StoreTheSurname(){
                    var command = (PromptForAnnualSalary)MagicYearCalculator.ProcessCommand(new PromptForSurname(), validSurname);
                    Assert.Equal(validSurname, command.surname);
                }
            }
        }
    }
}
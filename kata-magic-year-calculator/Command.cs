namespace MagicYearCalculator
{
  public interface ICommand{
    string output {get;}
  }

  public struct ShowWelcomeMessageAndPromptForName : ICommand{
    string ICommand.output => "Welcome to the magic year calculator!\n\nPlease input your name:";
  }
  public struct CloseProgram : ICommand{
    string ICommand.output => "";
  }

  public struct RepromptForName : ICommand{
    string ICommand.output => "Invalid name. Please input your name:";
  }

  public struct PromptForSurname : ICommand{
    string ICommand.output => "Please input your surname:";

    public string name {get;}

    public PromptForSurname(string name){
      this.name = name;
    }
  }

  public struct RepromptForSurname : ICommand{
    string ICommand.output => "Invalid surname. Please input your surname:";

    public string name {get;}

    public RepromptForSurname(string name){
      this.name = name;
    }
  }

  public struct PromptForAnnualSalary : ICommand{
    string ICommand.output => "Please enter your annual salary:";

    public string name {get;}
    public string surname {get;}

    public PromptForAnnualSalary(string name, string surname){
      this.name = name;
      this.surname = surname;
    }
  }
}
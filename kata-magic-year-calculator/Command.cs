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
    string ICommand.output => "Invlid name. Please input your name:";
  }

  public struct PromptForSurname : ICommand{
    string ICommand.output => "Please input your surname:";

    public string name {get;}

    public PromptForSurname(string name){
      this.name = name;
    }
  }
}
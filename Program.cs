public class SQLCommand
{
    private string commandText;

    public SQLCommand(string commandText)
    {
        CommandText = commandText;
    }

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }
}
namespace MyClassLibrary;

public class StringMy
{
    static public string ConsoleRead(string writeText = "")
    {
        if(writeText != "") Console.Write(writeText);
        return Convert.ToString(Console.Read());
    }

    static public void ConsoleWrite(string writeText = "", string spaceEnd = "")
    {
        Console.Write(writeText + spaceEnd);
    }
}

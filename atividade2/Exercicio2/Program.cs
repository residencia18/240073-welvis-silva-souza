using System;
public class Program
{
    public static void Main()
    {
        object o = null;
        try
        {
            o.toString();
        }
        catch (NullPointerException e)
        {
            String errorMessage = "Oops! Something went wrong. The object is null.";
            System.out.println(errorMessage);
        }
    }
}

public class NullPointerException : Exception
{
    public NullPointerException(string message) : base(message)
    {

    }
}

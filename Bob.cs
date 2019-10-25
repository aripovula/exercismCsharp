using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        string response = "";
        Boolean isQuestion = statement.EndsWith("?");
        Boolean isYell = statement.Equals(statement.ToUpper());
        if (statement.Contains(":)")) isYell = false;
        var regex = @"^\w{2}";
        Boolean isText = Regex.Match(statement, regex, RegexOptions.IgnoreCase).ToString().Length > 0;
        if (statement.Length == 0) isText = false;
        if (isQuestion && !isYell) response = "Sure.";
        else if (!isQuestion && isYell && isText) response = "Whoa, chill out!";
        else if (isQuestion && isYell && isText) response = "Calm down, I know what I'm doing!";
        else if (!isText) response = "Fine. Be that way!";
        else response = "Whatever.";
        Console.WriteLine(statement + " " + isQuestion + " " + isYell + " " + isText + " " + response);
        return response;
    }
}
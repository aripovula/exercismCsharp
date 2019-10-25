using System;
using System.Collections;
using System.Collections.Generic;
public class Robot
{
    public string name = NewName();
    public static ArrayList allNames = new ArrayList();
    public string Name
    {

        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }

    public void Reset()
    {
        this.name = NewName();
    }

    private static string NewName()
    {
        Boolean isFound = false;
        string newName = "";
        while (!isFound)
        {
            newName = $"{RandChars()}{RandNums()}";
            if (!allNames.Contains(newName))
            {
                allNames.Add(newName);
                isFound = true;
                Console.WriteLine("newName-" + newName);
                Console.WriteLine("allNames-" + allNames.Count);
            }
        }
        return newName;
    }

    private static string RandNums()
    {
        Random rnd = new Random();
        return $"{rnd.Next(9)}{rnd.Next(9)}{rnd.Next(9)}";
    }

    private static string RandChars()
    {
        Random rnd = new Random();
        string lettersStr = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        string[] lettersArr = lettersStr.Split(",");
        List<string> letters = new List<string>(lettersArr);

        return $"{letters[rnd.Next(24)]}{letters[rnd.Next(24)]}";
    }
}

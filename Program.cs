// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;



 string GetRecipient(string message, int position)
{
    string pattern = @"@([a-zA-Z0-9_\w-]+)";

    MatchCollection matches = Regex.Matches(message, pattern);

    if (position >= 1 && position <= matches.Count)
    {
        return matches[position - 1].Groups[1].Value;
    }

    else
    {
        return string.Empty;
    }
}

Console.WriteLine(GetRecipient("asdass @asdasd @dfgfdgfg @goror",5));

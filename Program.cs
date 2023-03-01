 string Repeat(string word, int count)
{
    if (count < 1)
    {
        return "";
    }
    else
    {
        string repeatedString = word;
        for (int i = 1; i < count; i++)
        {
            repeatedString += word;
        }
        return repeatedString;
    }
}
Console.WriteLine(Repeat("Ha!", 1));
Console.WriteLine(Repeat("Ha!", 3));
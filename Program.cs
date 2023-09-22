using System.Text;

string s = "asd-$lklkj(*!d_fd--dfas";

Console.WriteLine(GetReversedLetters(s));

string GetReversedLetters(string s)
{
    StringBuilder l = new StringBuilder();
    StringBuilder result = new StringBuilder();
    List<char> cl = new List<char>();
    int ca = 0;

    //Convert string to list
    foreach (char c in s)
        cl.Add(c);

    //Record inverted letters
    for (int i = cl.Count - 1; i >= 0; i--)
    {
        if (char.IsLetter(cl[i]))
            l.Append(cl[i]);
    }

    //Assemble the return
    for (int i = 0; i < cl.Count; i++)
    {
        if (!char.IsLetter(cl[i]))
            result.Append(cl[i]);
        else
        {
            result.Append(l[ca]);
            ca++;
        }
    }
    return result.ToString();
}

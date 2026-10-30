using System.Text.RegularExpressions;

string pattern = "^[A-Za-z]$";
Console.WriteLine("Введите строку:");
string text=Console.ReadLine()!;
for(int i = 0; i < text.Length; i++)
{
    if (Regex.IsMatch(text[i].ToString(), pattern))
    {
        text=text.Remove(i, 1);
        i--;
    }
}
Console.WriteLine(text);



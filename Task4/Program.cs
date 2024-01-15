Console.WriteLine("Введите число N");

string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (i == s.Length - 1)
    {
        Console.Write($"{s[i]}");
    }
    else if (i < s.Length - 1)
    {
        Console.Write($"{s[i]}, ");
    }
}
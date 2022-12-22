Console.WriteLine("введите текст через один пробел. без запятых)))");
string text = Console.ReadLine();
string [] littleWords = text.Split(' ');
Console.WriteLine("Ваши маленькие слова: ");

for (int i = 0; i < littleWords.Length; i++)
{
    if (littleWords[i].Length <= 3 )
    {
        Console.Write($"[{littleWords[i]}] ");
    }
}
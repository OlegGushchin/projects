Console.Write("Введите ваше имя: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "ника")
{
    Console.WriteLine("Ты самая самая!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
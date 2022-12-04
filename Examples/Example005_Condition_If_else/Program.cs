Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "pavel")
{
    Console.WriteLine("Ура, это же Pavel!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

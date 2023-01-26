Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine();
string userNameOrigin = userName; 
if (userName.ToLower() == "алена")
{
    Console.WriteLine("Ура! Это же " + userNameOrigin + "!");
}
else
{
    Console.WriteLine("Привет " + userName);
}


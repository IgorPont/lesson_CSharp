Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // переводит в нижний регистр все буквы
{
   Console.WriteLine("Ура, это МАША!");
}
else
{
   Console.WriteLine("Привет, ");
   Console.WriteLine(username);
}
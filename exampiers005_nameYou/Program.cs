Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "кирилл")
{
    Console.WriteLine("Приветствую вас господин!");
}
else
{
    Console.Write("Првет, ");
    Console.WriteLine(username);
}
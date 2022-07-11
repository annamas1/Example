Console.Write("Введите ваше имя");
string username = Console.ReadLine();
Console.Write("Привет, ");

NewMethod(username);

static void NewMethod(string username)
Console.Write(username);
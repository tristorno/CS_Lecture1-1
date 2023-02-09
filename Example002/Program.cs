Console.WriteLine ("Как тебя зовут?");
string username = Console.ReadLine ();
if (username.ToLower() == "надя")
{	
	Console.Write ("Нарушаешь мои границы, ");
	Console.Write (username);
	Console.WriteLine (". БЕРЕГИСЬ!");
}
else
{
	Console.Write ("Добро пожаловать, ");
	Console.WriteLine (username);
	Console.WriteLine ("Удачного дня тебе!");
}

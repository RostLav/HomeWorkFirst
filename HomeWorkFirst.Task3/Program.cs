Console.WriteLine("Введите переменную A");
string enteredStringA = Console.ReadLine();
Console.WriteLine("Введите переменную В");
string enteredStringB = Console.ReadLine();

string empty = enteredStringB;
enteredStringB = enteredStringA;
enteredStringA = empty;

Console.WriteLine($"Переменная А {enteredStringA}");
Console.WriteLine($"Переменная В {enteredStringB}");
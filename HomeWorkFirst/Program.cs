string enteredNumberAInString = Console.ReadLine();
string enteredNumberBInString = Console.ReadLine();
int numberA = Convert.ToInt32(enteredNumberAInString);
int numberB = Convert.ToInt32(enteredNumberBInString);
Console.WriteLine($"Результат деления А на В = {numberA / numberB}");
Console.WriteLine($"Остаток от деления А на В = {numberA % numberB}");
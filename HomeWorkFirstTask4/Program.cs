Console.WriteLine("Введите значение А: ");
string enteredNumberAInString = Console.ReadLine();
Console.WriteLine("введите значение В: ");
string enteredNumberBInString = Console.ReadLine();
Console.WriteLine("Введите значение С: ");
string enteredNumberCInString = Console.ReadLine();

int numberA = Convert.ToInt32(enteredNumberAInString);
int numberB = Convert.ToInt32(enteredNumberBInString);
int numberC = Convert.ToInt32(enteredNumberCInString);

Console.WriteLine($"Решение линейного уравнения: {(numberC - numberB) / numberA}");

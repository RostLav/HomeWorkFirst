Console.WriteLine("Enter a variable A: ");
string enteredNumberAInString = Console.ReadLine();
Console.WriteLine("Enter a variable B: ");
string enteredNumberBInString = Console.ReadLine();
int numberA = Convert.ToInt32(enteredNumberAInString);
int numberB = Convert.ToInt32(enteredNumberBInString);
double Decision = ((5 * Math.Pow(numberA + numberB, 2))/(numberB-numberA));
Console.WriteLine($"Answer: {Decision}");
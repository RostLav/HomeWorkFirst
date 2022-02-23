Console.WriteLine("Введите значение X1");
string enteredCoordinateX1InString = Console.ReadLine();
Console.WriteLine("Введите значение X2");
string enteredCoordinateX2InString = Console.ReadLine();
Console.WriteLine("Введите значение Y1");
string enteredCoordinateY1InString = Console.ReadLine();
Console.WriteLine("Введите значение Y2");
string enteredCoordinateY2InString = Console.ReadLine();

double coordinateX1 = Convert.ToInt32(enteredCoordinateX1InString);
double coordinateX2 = Convert.ToInt32(enteredCoordinateX2InString);
double coordinateY1 = Convert.ToInt32(enteredCoordinateY1InString);
double coordinateY2 = Convert.ToInt32(enteredCoordinateY2InString);


double coefficientA = (coordinateY1 - coordinateY2) / (coordinateX1 - coordinateX2);//вводим коэффициент А для дальнейшего решения уравнения
double coefficientB = coordinateY2 - coefficientA * coordinateX2;

Console.WriteLine($"Y={coefficientA}X+({coefficientB})");

System.Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("введіть Х для  -6*x^3+5*x^2-10*x+15");
double x = double.Parse(Console.ReadLine());

var result = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
Console.WriteLine(result);
Console.WriteLine();


Console.WriteLine(" напишить X для abs(x)*sin(x)");
double y;
y = double.Parse(Console.ReadLine());
var result2 = Math.Abs(y) * Math.Sin(y);
Console.WriteLine(result2);
Console.WriteLine();

Console.WriteLine("напишіть х для  2*пі*х");
double z;
z = double.Parse(Console.ReadLine());
var result3 = 2 * Math.PI * z;
Console.WriteLine(result3);
Console.WriteLine();

Console.WriteLine(" напишіть х для max(x, y)");
double t = double.Parse(Console.ReadLine());
double e = double.Parse(Console.ReadLine());

var result4 = Math.Max(t, e);
Console.WriteLine(result4);
Console.WriteLine();
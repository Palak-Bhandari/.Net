// User input 

Console.Write("Enter name: ");
String name1;
name1 = Console.ReadLine();
Console.WriteLine("Name (String): " + name1);
Console.Write("Enter no: ");
int no1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a(int): " + no1);
Console.Write("Enter boolean value: ");
bool bool_var1 = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Variable(boolean): " + bool_var1);
Console.Write("Enter a character: ");
char c1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Character(char): " + c1);
Console.Write("Enter a double no: ");
double d1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("d(double): " + d1);
Console.Write("Enter a float no: ");
float f1 = (float)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("f(float): " + f1);
Console.Write("Enter anything: ");
dynamic dy1 = Console.ReadLine();
Console.WriteLine("dy(dynamic): " + dy1);

using System;
namespace A1
{
 class MyClass1
 {
 static void MyMethod1()
 {
 int a = 5;
 int b = 8;
 int sum = a + b;
 Console.WriteLine("Method called!!");
 Console.WriteLine("This method has no parameters and return type!!");
 Console.WriteLine("The sum is: " + sum + "\n");
 }
 static void Main(string[] args)
 {
 MyMethod1();
 MyMethod1();
 MyMethod1();
 }
 }
}

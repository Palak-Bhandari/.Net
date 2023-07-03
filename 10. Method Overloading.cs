using System;
namespace A1
{
 class MyClass1
 {
 static double Calculate_area(double r)
 {
 return (22 / 7) * r * r;
 }
 static int Calculate_area(int r)
 {
 return (22 / 7) * r * r;
 }
 static void Main(string[] args)
 {
 int ans1 = Calculate_area(7);
 double ans2 = Calculate_area(6.24);
 Console.WriteLine("The area of circle of given radius - 7 is: " + ans1);
 Console.WriteLine("The area of circle of given radius - 6.24 is: " + ans2);
 }
 }
}

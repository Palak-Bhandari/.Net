using System;
namespace A1
{
 class MyClass1
 {
 static void Calculate_perimeter(double s, double r)
 {
 double sq_perimeter = 4 * s;
 double circle_perimeter = 2 * (22 / 7) * r;
 Console.WriteLine("The perimeter of square of given side length is: " + sq_perimeter);
 Console.WriteLine("The perimeter of circle of given radius is: " + circle_perimeter);
 }
 static void Calculate_area(double s, double r)
 {
 double area_sq = s * s;
 double area_circle = (22 / 7) * r * r;
 Console.WriteLine("The area of square of given side length is: " + area_sq);
 Console.WriteLine("The area of circle of given radius is: " + area_circle);
 }
 static void Main(string[] args)
 {
 Console.WriteLine("Enter value for circle radius: ");
 double r = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Enter value for lenght of square side: ");
 double s = Convert.ToDouble(Console.ReadLine());
 Calculate_perimeter(s, r);
 Calculate_area(s, r);
 }
 }
}

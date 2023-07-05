// Sorting a Collection

namespace A1
{
 class myclass1
 {
   static void Main(string[] args)
   {
     List<int> numbersList = new List<int> { 1, 8, 7, 5, 2, 13, 3};
     Console.WriteLine("Numbers Before Sorting");
     foreach (int i in numbersList)
     {
     Console.Write(i + " ");
     }
     numbersList.Sort();
     Console.WriteLine("\n\nNumbers After Sorting");
     foreach (int i in numbersList)
     {
     Console.Write(i + " ");
     }
     numbersList.Reverse();
     Console.WriteLine("\n\nNumbers in Descending order");
     foreach (int i in numbersList)
     {
     Console.Write(i + " ");
     }
     List<string> names = new List<string>() { "Pranit", "Palak", "Abhinav", "Meet", "Vikas", "Vidya", "Aditi" };
     Console.WriteLine("\n\nNames Before Sorting");
     foreach (string name in names)
     {
     Console.WriteLine(name);
     }
     names.Sort();
     Console.WriteLine("\nNames After Sorting");
     foreach (string name in names)
     {
     Console.WriteLine(name);
     }
     names.Reverse();
     Console.WriteLine("\nNames in Descending Order");
     foreach (string name in names)
     {
     Console.WriteLine(name);
     }
   }
 }
}

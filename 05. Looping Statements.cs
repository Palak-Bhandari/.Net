// 1. for loop – Find sum of nos till a given no
Console.Write("Enter a no: ");
int no = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= no; i++)
{
 sum = sum + no;
}
Console.WriteLine("The sum of nos till the no " + no + " is: " + sum);

// 2. foreach loop – Print all items in a list
string[] items = { "Watch", "Phone", "Laptop", "Desktop PC" };
foreach (string i2 in items)
{
 Console.WriteLine(i2);
}

// 3. while loop – Print numbers from a given input to 1
Console.WriteLine("Enter a no: ");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The numbers are: ");
while(s > 0) {
 Console.Write(s + " ");
 s--;
}
Console.WriteLine();

// 4. Do while loop – Print numbers from 1 to given input
Console.WriteLine("Enter a no: ");
int s1 = Convert.ToInt32(Console.ReadLine());
int i1 = 1;
Console.WriteLine("The numbers are: ");
do {
 Console.Write(i1 + " ");
 i1++;
}while(i1 <= s1);
Console.WriteLine();

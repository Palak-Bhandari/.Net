// 1.If – Determine if number is non - zero
Console.Write("Enter no: ");
int no1 = Convert.ToInt32(Console.ReadLine());
if (no1 != 0)
{
   Console.WriteLine("The no is non-zero!");
}

// 2.If else – A number is even or odd
Console.Write("Enter no: ");
int no2 = Convert.ToInt32(Console.ReadLine());
if (no2 % 2 == 0)
{
   Console.WriteLine("The no is even!");
}
else
{
   Console.WriteLine("The no is odd!");
}

// 3.If elseif else – Find Grade for given percentage
Console.Write("Enter your percentage: ");
int per = Convert.ToInt32(Console.ReadLine());
if (per >= 75)
{
   Console.WriteLine("Distinction!");
}
else if (per >= 60)
{
   Console.WriteLine("First Class!");
}
else if (per >= 50)
{
   Console.WriteLine("Second Class!");
}
else if (per >= 40)
{
   Console.WriteLine("Pass!");
}
else
{
   Console.WriteLine("Fail!");
}

// 4.Nested if else – Find the largest of 3 numbers
Console.WriteLine("Enter 3 nos: ");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
int third = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
   if (first > third)
   {
       Console.WriteLine("{0} is the largest", first);
   }
   else
   {
       Console.WriteLine("{0} is the largest", third);
   }
}
else
{
   if (second > third)
   {
       Console.WriteLine("{0} is the largest", second);
   }
   else
   {
       Console.WriteLine("{0} is the largest", third);
   }
}

// 5. Switch case – Find the day with day number
Console.Write("Enter your day no: ");
int d = Convert.ToInt32(Console.ReadLine());
switch (d) {
 case 1: Console.WriteLine("Sunday");
 break;
 case 2: Console.WriteLine("Monday");
 break;
 case 3: Console.WriteLine("Tuesday");
 break;
 case 4: Console.WriteLine("Wednessday");
 break;
 case 5: Console.WriteLine("Thursday");
 break; 
 case 6: Console.WriteLine("Friday");
 break;
 case 7: Console.WriteLine("Saturday");
 break;
 default: Console.WriteLine("Invalid day number!");
 break;
}

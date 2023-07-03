// 1. Break Statement – Given an array of distinct integers and a target value, return the index if the target is found.
Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array: ");
int[] nums = new int[n];
int i, flag = 0;
for (i = 0; i < n; i++)
{
 nums[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Enter target: ");
int target = Convert.ToInt32(Console.ReadLine());
for (i = 0; i < n; i++)
{
 if (nums[i] == target)
 {
 flag = 1;
 break;
 }
}
if(flag == 0){
 Console.WriteLine("Target not found!");
}else{
 Console.WriteLine("The target is at position: " + i);
}

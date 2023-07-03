// 2. Continue Statement - Given an integer array and an integer target, remove all occurrences of target from the array.
Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array: ");
int[] nums = new int[n];
int i;
for (i = 0; i < n; i++)
{
 nums[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Enter target: ");
int target = Convert.ToInt32(Console.ReadLine());
int j = 0;
for (i = 0; i < n; i++)
{
 if (nums[i] == target)
 {
 continue;
 }
 nums[j] = nums[i];
 j++;
}
Console.WriteLine("Output array: ");
for (i = 0; i < j; i++)
{
 Console.WriteLine(nums[i]);
}

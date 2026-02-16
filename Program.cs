using System;


class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        int[] nums = { 2, 7, 11, 15 };
        
        int target = 9;

        int[] result = solution.TwoSum(nums, target);
        
        Console.WriteLine(result);
    }
}



using System.Numerics;


/**

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]


**/
public class Solution {
    
  public int[] TwoSum(int[] nums, int target) {
    

    int sum = 0;
    List<int> sums = new List<int>();
    
    for (int i = 0; i <= nums.Length - 1 ; i++)
    {
        
        if (sum < target)
        {
            
            if (nums[i] < target)
            
            {
                
                
                //Console.WriteLine(sum + nums[i] <= target);
                
                if (sum + nums[i] <= target)
                {
                    sum += nums[i];
                    
                    sums.Add(i);
                    
                    //Console.WriteLine(sum);
                        
                }                 
                
            }
            
        }
        
        
        
    }
    
    
    
    
    return sums.ToArray();
    
  }
  
  
  
  
  
  public int[] TwoSumDoubleLoop(int[] nums, int target)
    {
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            
            int iNmb = nums[i];
            
            for (int j = i + 1; j < nums.Length; j++)
            {
                
                int jNmb = nums[j];
                
                if (iNmb + jNmb == target)
                {
                    
                    return new int[] {i, j};
                    
                }   
            }     
        }
        
        return [];    
    }
}

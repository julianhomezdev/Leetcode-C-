using System.ComponentModel;

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        
        // THIS IS BINARY SEARCH, FIX IT
        
        // [1, 3, 5, 6]
        
        // target => 7
        
        // return 2 if not return where should be
        
        
        for (int i = 0; i< nums.Length -1; i++)
        {
            
            int iNmb = nums[i];
            // 1
            if (iNmb == target)
                return i;            
            
            for (int j = i +1; j < nums.Length; j++)
            {
                int jNmb = nums[j];
                // 3
                if (jNmb == target)
                    return j;
                
                
                if (iNmb < target)
                {
                    
                    if (jNmb > target)
                    {
                        
                        return i+1;
                        
                    }
                    
                }
                
                
                
            }
            
        }
        
    
        

    }
}
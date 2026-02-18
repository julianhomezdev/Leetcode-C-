using System.ComponentModel;

public class Solution {

    public int SearchInsertBinary(int[] nums, int target)
    {
        
        // THIS IS BINARY SEARCH, FIX IT
        
        // [1, 3, 5, 6, 8, 9] -> 7

        

        // 0 + 7 = 7 / 2 -> 3

        // nums[3] = 6

        // 6 > 7 ?

        // NO

        // initial = middle +1 = 4

        // end = 5

        // middle = (4 + 5) // 2 = 4

        // nums[4] = 8

        // 8 > 7 = si

        // end = middle -1  = 4 - 1 = 3

        // initial = 4 

        // end =  3

        // middle = (4+3) / 2 = 3

        // initial <= end ?? NOT

        // RETURN INITIAL = 4

        
        // Is a sorted list (Check to be binary search)

        // O(log) n


        int initial = 0;
        int end = nums.Length -1;

        

        while (initial <= end)
        {
            
            int middle = (initial + end) / 2;

            if (nums[middle] > target)
            {
                
                end = middle -1;


            } else if(nums[middle] < target)
            {
                

                initial = middle +1;

            } else
            {
                
                return middle;

            }

        }

        return initial;


    }


    // BAD SOLUTION
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

        return 0;
        
    
        

    }
}
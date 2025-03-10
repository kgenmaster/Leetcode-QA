/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
You must implement a solution with a linear runtime complexity and use only constant extra space.
*/
        // Initialize the result to 0
        // Loop through each number in the array
        // XOR the current number with the result
        // This cancels out numbers that appear twice
        // and leaves the number that appears once
        // Return the result, which is the number that appears once

public class Solution {
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        
        foreach (int num in nums)
        {
            result ^= num;
        }
        return result;
    }

    public static void Main () {
        int [] nums = {4, 1, 2, 1, 2};
        Console.Write (SingleNumber ());
    }
}
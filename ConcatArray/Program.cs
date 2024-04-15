using System;

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int newLength = nums.Length * 2;
        int[] ans = new int[newLength];

        // Fill the new array by repeating the original array
        for (int i = 0; i < newLength; i += nums.Length) {
            Array.Copy(nums, 0, ans, i, nums.Length);
        }

        return ans;
    }
}

class Program {
    static void Main() {
        // Example array
        int[] nums = { 1, 2, 3 };

        // Creating an instance of Solution class
        Solution solution = new Solution();

        // Getting the concatenated array
        int[] result = solution.GetConcatenation(nums);

        // Output the results
        Console.WriteLine("Original Array:");
        foreach (int num in nums) {
            Console.Write(num + " ");
        }
        Console.WriteLine("\nConcatenated Array:");
        foreach (int num in result) {
            Console.Write(num + " ");
        }
    }
}

using System.Collections;
using System.Collections.Generic;

public class Solution
{
    public static int MajorityElement(int[] nums)
    {

        var z = nums.GroupBy(i => i)
            .OrderByDescending(group => group.Count())
            .Select(group => group.Key).First();
        return 0;
    }

    public static void Main(string[] args)
    {
        var array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

        int majorityElement = MajorityElement((int[])array);
    }
}
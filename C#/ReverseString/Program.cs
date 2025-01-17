using System;

public class Solution
{
    public void ReverseString(char[] s)
    {
        int start = 0;
        int end = s.Length - 1;

        while (start < end)
        {
            char temp = s[start];
            s[start] = s[end];
            s[end] = temp;

            start++;
            end--;
        }
    }
}

class Program
{
    static void Main()
    {
        char[] s = { 'h', 'e', 'l', 'l', 'o' };

        Solution solution = new Solution();
        solution.ReverseString(s);

        Console.WriteLine(new string(s));
    }
}
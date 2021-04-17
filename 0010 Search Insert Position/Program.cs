using System;

namespace _0010_Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 1};
            int target = 0;


            int SearchInsert(int[] nums, int target)
            {
                int k = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                        return i;

                    if (nums[i] > target)
                        return i;

                    k++;
                }
                return k;
            }

            Console.WriteLine(SearchInsert(nums,target));








        }
    }
}

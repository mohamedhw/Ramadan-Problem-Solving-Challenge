﻿namespace myProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int p = m + n - 1;
                int p1 = m - 1;
                int p2 = n - 1;

                while (p2>=0 && p1 >= 0)
                {
                    if (nums2[p2] > nums1[p1])
                    {
                        nums1[p] = nums2[p2];
                        p2--;
                        p--;
                    }
                    else
                    {
                        nums1[p] = nums1[p1];
                        p1--;
                        p--;
                    }
                }
                while (p2 >= 0)
                {
                    nums1[p] = nums2[p2];
                    p2--;
                    p--;
                }

            }

            Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        }
    }
}
        




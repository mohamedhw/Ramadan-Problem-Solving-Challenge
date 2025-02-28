// Time Complexity O(n)
class Solution
{
public:
    int findMaxConsecutiveOnes(vector<int> &nums)
    {
        int Ones = 0, res = 0;
        for (int num : nums)
        {
            if (num)
                Ones++;
            else
                Ones = 0;
            res = max(res, Ones);
        }
        return res;
    }
};
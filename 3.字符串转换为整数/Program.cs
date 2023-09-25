namespace _3.字符串转换为整数;

internal class Program
{
    static void Main(string[] args)
    {
        /**
         * 题目：将字符串转换成一个 32 位有符号整数
         * see：https://leetcode.cn/problems/ba-zi-fu-chuan-zhuan-huan-cheng-zheng-shu-lcof
         */

        string str = "-42";

        int res = StrToInt(str);
        Console.WriteLine(res);
    }

    /// <summary>
    /// 字符串转换为整数
    /// </summary>
    /// <param name="str">字符串</param>
    /// <returns></returns>
    public static int StrToInt(string str)
    {
        int ans = 0;
        bool isNeg = false;
        int n = str.Length;
        int idx = 0;
        while (idx < n && str[idx] == ' ') idx++;
        if (idx == n) return ans;

        if (str[idx] == '-')
        {
            isNeg = true;
            idx++;
        }
        else if (str[idx] == '+')
        {
            idx++;
        }

        while (idx < n && str[idx] >= '0' && str[idx] <= '9')
        {
            int cur = str[idx++] - '0';
            if (ans > (int.MaxValue - cur) / 10)
            {
                return isNeg ? int.MinValue : int.MaxValue;
            }
            ans = ans * 10 + cur;
        }
        return isNeg ? -ans : ans;
    }
}
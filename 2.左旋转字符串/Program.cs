namespace _2.左旋转字符串;

public class Program
{
    static void Main(string[] args)
    {
        /**
         * 题目：字符串的左旋转操作是把字符串前面的若干个字符转移到字符串的尾部。
         * See：https://leetcode.cn/problems/zuo-xuan-zhuan-zi-fu-chuan-lcof/description
         */

        string res = ReverseLeftWords("abcdefg", 2);
        Console.WriteLine(res);
    }

    /// <summary>
    /// 字符串左旋转操作
    /// </summary>
    /// <param name="s">原字符串</param>
    /// <param name="n">要旋转的索引</param>
    /// <returns>旋转后的字符串</returns>
    public static string ReverseLeftWords(string s, int n)
    {
        //1、使用字符串截取
        return s[n..] + s[..n];

        //2、与 1 的做法相同，1 是语法糖
        //return s.Substring(n, s.Length - n) + s.Substring(0, n);
    }
}
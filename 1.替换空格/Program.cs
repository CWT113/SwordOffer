using System.Text.RegularExpressions;

namespace _1.替换空格;

public class Program
{
    static void Main(string[] args)
    {
        /**
         * 题目：请实现一个函数，把字符串 oldStr 中的每个空格替换成 "%20"。
         * See：https://leetcode.cn/problems/ti-huan-kong-ge-lcof/?envType=study-plan-v2&envId=coding-interviews
         */

        string oldStr = "We are family.";

        string newStr = ReplaceSpace(oldStr);
        Console.WriteLine(newStr);
    }

    /// <summary>
    /// 替换字符串中的空格为 “%20”
    /// </summary>
    /// <param name="str">被替换字符串</param>
    /// <returns>替换后的字符串</returns>
    public static string ReplaceSpace(string str)
    {
        //1、使用 Replace() 方法
        return str.Replace(" ", "%20");

        //2、使用 string.Join() + str.Split() 方法
        //return string.Join("%20", str.Split(" "));

        //3、使用 string.Join() + Linq  表达式
        //return string.Join("", str.Select(d => d == ' ' ? "%20" : d + ""));

        //4、使用正则表达式，"\\s"表示正则匹配所有空白字符
        //string pattern = "\\s";
        //Regex regex = new(pattern);
        //str = regex.Replace(str, "%20");
        //return str;
    }
}
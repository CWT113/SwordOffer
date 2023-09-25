namespace _4.图书整理;

internal class Program
{
    static void Main(string[] args)
    {
        /**
         * 题目：倒叙排序书单列表
         * see：https://leetcode.cn/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof
         */

        //创建链表
        ListNode head1 = new ListNode(5);
        ListNode head2 = new ListNode(4);
        ListNode head3 = new ListNode(3);
        ListNode head4 = new ListNode(2);
        ListNode head5 = new ListNode(1);
        head1.next = head2;
        head2.next = head3;
        head3.next = head4;
        head4.next = head5;

        int[]? res = ReverseBookList(head1);
        foreach (int item in res)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// 倒序排序书单链表
    /// </summary>
    /// <param name="head">链表开始值</param>
    /// <returns></returns>
    public static int[] ReverseBookList(ListNode head)
    {
        if (head == null) return new int[0];

        List<int> temp = new List<int>();
        while (head != null)
        {
            temp.Add(head.val);
            head = head.next;
        }
        temp.Reverse();
        return temp.ToArray();
    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    ListNode _listNode;

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null && l2 == null)
        {
            return null;
        }

        if (l1 == null)
        {
            return l2;
        }

        if (l2 == null)
        {
            return l1;
        }

        //初始化链表头部
        if (l1.val <= l2.val)
        {
            if (_listNode == null)
            {
                _listNode = l1;

                if (l1.next != null)
                {
                    MergeLists(l1.next, l2, _listNode);
                }
                else
                {
                    _listNode.next = l2;
                }
            }
        }
        else
        {
            if (_listNode == null)
            {
                _listNode = l2;
                
                if (l2.next != null)
                {
                    MergeLists(l1, l2.next, _listNode);
                }
                else
                {
                    _listNode.next = l1;
                }
            }
        }

        return _listNode;
    }

    public void MergeLists(ListNode l1, ListNode l2, ListNode lNew)
    {
        if (l1.val <= l2.val)
        {
            lNew.next = l1;

            if (l1.next != null)
            {
                MergeLists(l1.next, l2, lNew.next);
            }
            else
            {
                ListNode listNode = lNew.next;
                listNode.next = l2;
            }
        }
        else
        {
            lNew.next = l2;

            if (l2.next != null)
            {
                MergeLists(l1, l2.next, lNew.next);
            }
            else
            {
                ListNode listNode = lNew.next;
                listNode.next = l1;
            }
        }
    }
}
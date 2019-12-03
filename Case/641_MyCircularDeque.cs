public class CircularDeque
{
    //上一个节点
    public CircularDeque Previous;
    //当前节点
    public int Val { get; set; }
    //下一个节点
    public CircularDeque Next;
}

public class MyCircularDeque
{
    //队列长度
    private int Length { get; set; }
    //当前队列长度
    private int CurrentLength { get; set; }
    //开始元素
    private CircularDeque StartCircularDeque { get; set; }

    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k)
    {
        Length = k;
    }

    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value)
    {
        if (CurrentLength >= Length)
        {
            return false;
        }
        else
        {
            if (StartCircularDeque == null)
            {
                StartCircularDeque = new CircularDeque();
                StartCircularDeque.Previous = null;
                StartCircularDeque.Val = value;
                StartCircularDeque.Next = null;
            }
            else
            {
                CircularDeque _CircularDeque = StartCircularDeque;

                while (_CircularDeque.Previous != null)
                {
                    _CircularDeque = _CircularDeque.Previous;
                }

                CircularDeque FontCircularDeque = new CircularDeque();
                FontCircularDeque.Val = value;
                FontCircularDeque.Previous = null;
                FontCircularDeque.Next = _CircularDeque;

                _CircularDeque.Previous = FontCircularDeque;

            }

            if (CurrentLength < Length)
            {
                CurrentLength++;
            }

            return true;
        }
    }

    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value)
    {
        if (CurrentLength >= Length)
        {
            return false;
        }
        else
        {
            if (StartCircularDeque == null)
            {
                StartCircularDeque = new CircularDeque();
                StartCircularDeque.Previous = null;
                StartCircularDeque.Val = value;
                StartCircularDeque.Next = null;
            }
            else
            {
                CircularDeque _CircularDeque = StartCircularDeque;

                while (_CircularDeque.Next != null)
                {
                    _CircularDeque = _CircularDeque.Next;
                }

                CircularDeque LastCircularDeque = new CircularDeque();
                LastCircularDeque.Val = value;
                LastCircularDeque.Previous = _CircularDeque;
                LastCircularDeque.Next = null;

                _CircularDeque.Next = LastCircularDeque;
            }


            if (CurrentLength < Length)
            {
                CurrentLength++;
            }

            return true;
        }
    }

    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront()
    {
        if (CurrentLength <= 0)
        {
            return false;
        }
        else
        {
            if (StartCircularDeque.Previous == null)
            {
                if (StartCircularDeque.Next == null)
                {
                    StartCircularDeque = null;
                }
                else
                {
                    CircularDeque PreviousCircularDeque = StartCircularDeque.Next;
                    StartCircularDeque.Val = PreviousCircularDeque.Val;
                    StartCircularDeque.Next = PreviousCircularDeque.Next;
                }

            }
            else
            {
                CircularDeque _CircularDeque = StartCircularDeque;

                while (_CircularDeque.Previous != null)
                {
                    _CircularDeque = _CircularDeque.Previous;
                }

                if (_CircularDeque.Next != null)//队列中元素超过2个
                {
                    CircularDeque PreviousCircularDeque = _CircularDeque.Next;
                    PreviousCircularDeque.Previous = null;
                }
                else//队列中元素不足2个
                {
                    StartCircularDeque = null;
                    CurrentLength = 0;
                }
            }

            if (CurrentLength >= 1)
            {
                CurrentLength--;
            }

            return true;
        }
    }

    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast()
    {
        if (CurrentLength <= 0)
        {
            return false;
        }
        else
        {
            if (StartCircularDeque.Next == null)
            {
                if (StartCircularDeque.Previous == null)
                {
                    StartCircularDeque = null;
                }
                else
                {
                    CircularDeque PreviousCircularDeque = StartCircularDeque.Previous;
                    StartCircularDeque.Val = PreviousCircularDeque.Val;
                    StartCircularDeque.Previous = PreviousCircularDeque.Previous;
                }

            }
            else
            {
                CircularDeque _CircularDeque = StartCircularDeque;

                while (_CircularDeque.Next != null)
                {
                    _CircularDeque = _CircularDeque.Next;
                }

                if (_CircularDeque.Previous != null)//队列中元素超过2个
                {
                    CircularDeque PreviousCircularDeque = _CircularDeque.Previous;
                    PreviousCircularDeque.Next = null;
                }
                else//队列中元素不足2个
                {
                    StartCircularDeque = null;
                    CurrentLength = 0;
                }
            }

            if (CurrentLength >= 1)
            {
                CurrentLength--;
            }

            return true;
        }
    }

    /** Get the front item from the deque. */
    public int GetFront()
    {
        if (CurrentLength <= 0)
        {
            return -1;
        }
        else
        {
            CircularDeque _CircularDeque = StartCircularDeque;

            while (_CircularDeque.Previous != null)
            {
                _CircularDeque = _CircularDeque.Previous;
            }

            return _CircularDeque.Val;
        }
    }

    /** Get the last item from the deque. */
    public int GetRear()
    {
        if (CurrentLength <= 0)
        {
            return -1;
        }
        else
        {
            CircularDeque _CircularDeque = StartCircularDeque;

            while (_CircularDeque.Next != null)
            {
                _CircularDeque = _CircularDeque.Next;
            }

            return _CircularDeque.Val;
        }
    }

    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty()
    {
        if (CurrentLength <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /** Checks whether the circular deque is full or not. */
    public bool IsFull()
    {
        if (CurrentLength.Equals(Length))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */

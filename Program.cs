using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // RemoveDupliactesSolution _RemoveDupliactesSolution=new RemoveDupliactesSolution();
            // int reuslt = _RemoveDupliactesSolution.RemoveDupliactes(new int[3] {1,1,2});

            // Solution88 _solution88 = new Solution88();
            // _solution88.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            // _solution88.Merge(new int[] { 2, 0 }, 1, new int[] { 1 }, 1);
            // _solution88.Merge(new int[] { 4,5,6,0,0,0 }, 3, new int[] { 1,2,3 }, 3);
            // MyCircularDeque myCircularDeque=new MyCircularDeque(3);
            // Console.WriteLine(myCircularDeque.InsertFront(8).ToString());
            // Console.WriteLine(myCircularDeque.InsertLast(8).ToString());
            // Console.WriteLine(myCircularDeque.InsertLast(2).ToString());
            // Console.WriteLine(myCircularDeque.GetFront().ToString());
            // Console.WriteLine(myCircularDeque.DeleteLast().ToString()); 
            // Console.WriteLine(myCircularDeque.GetRear().ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(9).ToString());
            // Console.WriteLine(myCircularDeque.DeleteFront().ToString());
            // Console.WriteLine(myCircularDeque.GetRear().ToString());
            // Console.WriteLine(myCircularDeque.InsertLast(2).ToString());
            // Console.WriteLine(myCircularDeque.IsFull().ToString());

            // MyCircularDeque myCircularDeque=new MyCircularDeque(77);
            // Console.WriteLine(myCircularDeque.InsertFront(89).ToString());
            // Console.WriteLine(myCircularDeque.GetRear().ToString());
            // Console.WriteLine(myCircularDeque.DeleteLast().ToString());
            // Console.WriteLine(myCircularDeque.GetRear().ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(19).ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(23).ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(23).ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(82).ToString());
            // Console.WriteLine(myCircularDeque.IsFull().ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(45).ToString());
            // Console.WriteLine(myCircularDeque.IsFull().ToString());
            // Console.WriteLine(myCircularDeque.GetRear().ToString());
            // Console.WriteLine(myCircularDeque.DeleteLast().ToString());
            // Console.WriteLine(myCircularDeque.GetFront().ToString());
            // Console.WriteLine(myCircularDeque.GetFront().ToString());
            // Console.WriteLine(myCircularDeque.InsertLast(74).ToString());
            // Console.WriteLine(myCircularDeque.DeleteFront().ToString());
            // Console.WriteLine(myCircularDeque.GetFront().ToString());

            // Console.WriteLine(myCircularDeque.InsertFront(80).ToString());
            // Console.WriteLine(myCircularDeque.GetFront().ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(27).ToString());
            // Console.WriteLine(myCircularDeque.DeleteLast().ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(60).ToString());
            // Console.WriteLine(myCircularDeque.InsertFront(81).ToString());
            // Console.WriteLine(myCircularDeque.GetFront().ToString());

            MyCircularDeque myCircularDeque = new MyCircularDeque(8);
            Console.WriteLine(myCircularDeque.InsertFront(5).ToString());
            Console.WriteLine(myCircularDeque.GetFront().ToString());
            Console.WriteLine(myCircularDeque.IsEmpty().ToString());
            Console.WriteLine(myCircularDeque.DeleteFront().ToString());
            Console.WriteLine(myCircularDeque.InsertLast(3).ToString());
            Console.WriteLine(myCircularDeque.GetRear().ToString());
            Console.WriteLine(myCircularDeque.InsertLast(7).ToString());
            Console.WriteLine(myCircularDeque.InsertLast(7).ToString());
            Console.WriteLine(myCircularDeque.DeleteLast().ToString());
            Console.WriteLine(myCircularDeque.InsertLast(4).ToString());
            Console.WriteLine(myCircularDeque.IsEmpty().ToString());
            Console.ReadLine();
        }
    }
}

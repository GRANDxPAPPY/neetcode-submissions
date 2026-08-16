public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
        foreach(int i in stones)
        {
            maxHeap.Enqueue(i,i);
        }
        while(maxHeap.Count > 1)
        {
            int first = maxHeap.Dequeue();
            int second = maxHeap.Dequeue();
            if(first > second)
            {
                maxHeap.Enqueue(Math.Abs(first - second), Math.Abs(first - second));
            }
        }

        maxHeap.Enqueue(0,0);
        return Math.Abs(maxHeap.Peek());
        
    }
}

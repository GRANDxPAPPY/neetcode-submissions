public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((x,y)=> y.CompareTo(x)));
        int returnInt = 0;
            foreach(int n in nums)
            {
                maxHeap.Enqueue(n,n);
            }
            for(int i = 0; i < k; i++)
            {
                returnInt = maxHeap.Dequeue();
            }
        return returnInt;
    }
}

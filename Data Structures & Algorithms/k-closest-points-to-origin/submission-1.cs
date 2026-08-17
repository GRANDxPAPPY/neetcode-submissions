public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> minHeap = new PriorityQueue<int[],int>();
        int[][] arrs = new int[k][];
        foreach(var arr in points)
        {
    
            int value = (arr[0] * arr[0]) + (arr[1] * arr[1]);
            minHeap.Enqueue(arr,value);
            
        }

        for(int i = 0; i < k; i ++)
        {
            arrs[i] = minHeap.Dequeue();
        }
        return arrs;


    }
}

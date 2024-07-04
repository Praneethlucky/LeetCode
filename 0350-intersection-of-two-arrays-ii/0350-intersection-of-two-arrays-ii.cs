public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        List<int> result = new List<int>();
        foreach(var n in nums1)
        {
            if(dic.ContainsKey(n))
                dic[n]+=1;
            else
                dic[n] =1;
        }
        foreach(var n in nums2)
        {
            if(dic.ContainsKey(n)){
                if(dic[n] >0)
                {
                    dic[n]-=1;
                    result.Add(n);
                }
            }
        }
        return result.ToArray();
}
}
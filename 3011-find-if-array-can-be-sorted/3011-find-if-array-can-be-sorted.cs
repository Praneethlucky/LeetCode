public class Solution {
    public bool CanSortArray(int[] nums) {
        Dictionary<int,int> co = new Dictionary<int,int>();
        foreach(var n in nums)
        {
            if(!co.ContainsKey(n))
                co[n] = Convert.ToString(n, 2).Count(c => c == '1');
        }
        //Prepare Sets
        List<List<int>> sets = new List<List<int>>();
        
        List<int> setss = new List<int>();
                        setss.Add(nums[0]);
        int len = nums.Length -1;
        for(int i=0; i<len; i++)
        {

            if(co[nums[i]]==co[nums[i+1]])
            {
                                        setss.Add(nums[i+1]);

            }
            else
            {
                sets.Add(setss);
                setss = new List<int>();
                setss.Add(nums[i+1]);
            }
        }
        sets.Add(setss);
        List<int> ou = new List<int>();
        foreach(var se in sets.ToArray())
        {
            var x = se.ToArray();
            Array.Sort(x);
            
            ou.AddRange(x.ToList());
        }
        foreach(var i in ou)
        {
            Console.WriteLine(i);
        }
        var arr = ou.ToArray();
    return arr.Zip(arr.Skip(1), (a, b) => a <= b).All(x => x);
    }
}
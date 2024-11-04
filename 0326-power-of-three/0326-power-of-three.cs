public class Solution {
    public bool IsPowerOfThree(int n) {
        if(n==1)
                return true;
        if(n<3)
            return false;
        while(n>=0)
        {
            if(n==1)
                return true;
            int v = n%3;
            if(v != 0)
                return false;
            n=n/3;
            Console.WriteLine(n);

        }
        return false;
    }
}
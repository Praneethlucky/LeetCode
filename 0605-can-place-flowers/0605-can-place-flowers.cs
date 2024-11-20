public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        if(n==0)
                return true;
        if(flowerbed.Length ==1)
        {
            if(flowerbed[0] == 1)
                return false;
            else
                return true;
        }
        
        for(int i=0;i<flowerbed.Length;i++)
        {
            if(n==0)
                return true;
            if(i==0 && flowerbed[i]!=0)
            {
                continue;
            }
            else if(i==0 && flowerbed[i]==0 && i<flowerbed.Length)
            {
                if(flowerbed[i+1]==0)
                {
                    flowerbed[i] = 1;
                    n--;
                    if(n==0)
                        return true;
                }
            }
            else if(i!=0 && flowerbed[i]!=0)
            {
                continue;
            }
            else if(i == flowerbed.Length-1)
            {
                if(flowerbed[i-1]==0)
                {
                    flowerbed[i]=1;
                    n--;
                    if(n==0)
                        return true;
                }
            }
            else
            {
                if(flowerbed[i-1]==0 && flowerbed[i+1]==0)
                {
                    Console.WriteLine("else: "+i+" "+flowerbed[i]);
                    flowerbed[i]=1;
                    n--;
                    if(n==0)
                        return true;
                }
            }
        }
        return false;
    }
}
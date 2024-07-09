public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        int currTime = customers[0][0];
        double avg = 0;
        for(int i=0;i<customers.Length;i++)
        {
            var x = customers[i][0];
            currTime = currTime>=x?currTime+customers[i][1]:customers[i][1]+x;
            avg += (currTime - customers[i][0]);
            Console.Write(currTime);
            Console.WriteLine(avg);

        }
        return avg/customers.Length;
    }
}
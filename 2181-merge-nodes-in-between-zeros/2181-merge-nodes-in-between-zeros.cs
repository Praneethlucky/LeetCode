/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeNodes(ListNode head) {
     
        ListNode res = new ListNode();
        ListNode temp = res;
        int sum =0;
        while(head != null)
        {
            if(head.val != 0)
            {
                sum += head.val;
            }
            else
            {
                if(sum!=0)
                {
                    temp.next = new ListNode(sum);
                    temp = temp.next;
                    sum =0;
                }
                
            }
            
            head = head.next;
        }
        
        
        return res.next;
    }
}
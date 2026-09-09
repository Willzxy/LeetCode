using System.Numerics;

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        BigInteger result = 0;
        BigInteger mult = 1;

        while (l1 != null || l2 != null) {
            if (l1 != null) {
                result += l1.val * mult;
                l1 = l1.next;
            }

            if (l2 != null) {
                result += l2.val * mult;
                l2 = l2.next;
            }

            mult *= 10;
        }

        if (result == 0) {
            return new ListNode(0);
        }

        ListNode dummy = new ListNode(0);
        ListNode atual = dummy;

        while (result > 0) {
            atual.next = new ListNode((int)(result % 10));
            atual = atual.next;
            result /= 10;
        }

        return dummy.next;
    }
}
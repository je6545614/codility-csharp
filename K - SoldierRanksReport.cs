using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    public int solution(int[] X) {
        /*
        X = new int[] { 3, 4, 3, 0, 2, 2, 3, 0, 0 };
        X = new int[] { 4, 4, 3, 3, 1, 0 };
        */
        int result = 0;
        foreach (int rank in X)
        {
            if (X.Contains(rank + 1))
            {
                result++;
            }
        }
        return result;
    }
}

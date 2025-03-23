using System;
using System.Linq;

public class Solution {
        public int[] solution(int[] arr, int[] delete_list) => arr.Where(x => !delete_list.Contains(x)).ToArray();
}
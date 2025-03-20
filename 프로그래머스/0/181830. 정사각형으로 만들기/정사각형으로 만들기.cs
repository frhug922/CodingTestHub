using System;

public class Solution {
    public int[,] solution(int[,] arr) {
            int[,] answer;

            if (arr.GetLength(0) >= arr.GetLength(1)) {
                answer = new int[arr.GetLength(0), arr.GetLength(0)];
            }
            else {
                answer = new int[arr.GetLength(1), arr.GetLength(1)];
            }

            for (int i = 0; i < arr.GetLength(0); ++i) {
                for (int j = 0; j < arr.GetLength(1); ++j) {
                    answer[i, j] = arr[i, j];
                }
            }

            return answer;
    }
}
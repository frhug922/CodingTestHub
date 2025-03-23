using System;

public class Solution {
    public int solution(string number) {
            int answer = 0;
            char[] chars = number.ToCharArray();
            for (int i = 0; i < chars.Length; ++i) {
                answer += int.Parse(chars[i].ToString());
            }

            return answer % 9;
    }
}
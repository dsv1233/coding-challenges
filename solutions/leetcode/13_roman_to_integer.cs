public class ConvertRomanToInteger {
    public int RomanToInt(string s) {
        if (s.Length == 0) return 0;
        Dictionary<char, int> romanToInt = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int sum = romanToInt[s[s.Length - 1]];
        for (int i = s.Length - 2; i >= 0; i--) {
            if (romanToInt[s[i]] < romanToInt[s[i + 1]]) {
                sum -= romanToInt[s[i]];
            } else {
                sum += romanToInt[s[i]];
            }
        }
        return sum;
    }
}
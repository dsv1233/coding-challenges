public class LongestCommonPrefix14 {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            while (strs[i].IndexOf(prefix) != 0) {
                //prefix = prefix.Substring(0, prefix.Length - 1);
                prefix = prefix[0..^1];
                if (prefix.Length == 0) return "";
            }
        }
        return prefix;
    }

    public string LongestCommonPrefix_Tommy(string[] strs) {
        int i = 0;
        while (true) {
            if(i >= strs[0].Length) {
                return strs[0][0..i];
            }
            char c = strs[0][i];
            for(int j = 0; j < strs.Length; j++) {
                if (i >= strs[j].Length || strs[j][i] != c) {
                    return strs[j][0..i];
                }
            }
            i += 1;
        }
    }
}
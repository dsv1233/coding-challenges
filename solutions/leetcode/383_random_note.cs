public class RandomNote383{
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in magazine){
            if(dict.ContainsKey(c)){
                dict[c]++;
            }else{
                dict[c] = 1;
            }
        }
        
        foreach(char c in ransomNote){
            if(dict.ContainsKey(c)){
                dict[c]--;
                if(dict[c] < 0){
                    return false;
                }
            }else{
                return false;
            }
        }
        
        return true;
    }

    public bool CanConstruct_v2(string ransomNote, string magazine) {
        return magazine.Length >= ransomNote.Length && !ransomNote.GroupBy(c => c).Any(g => g.Count() > magazine.Count(c => c == g.Key));
    }
}
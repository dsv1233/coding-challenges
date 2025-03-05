public class ReverseVowels345{
    public string ReverseVowels(string s){
        HashSet<char> vowels = new HashSet<char>{'a','e','i','o','u','A','E','I','O','U'};
        int start = 0;
        int end = s.Length - 1;
        char[] inputArray = s.ToCharArray();

        while(start < end){
            while(start < end && !vowels.Contains(inputArray[start])){
                start++;
            }
            while(start < end && !vowels.Contains(inputArray[end])){
                end--;
            }
            
            if(start < end ){
                char temp = inputArray[start];
                inputArray[start] = inputArray[end];
                inputArray[end] = temp;
                start++;
                end--; 
            }
        }
        return new string(inputArray);
    }
}
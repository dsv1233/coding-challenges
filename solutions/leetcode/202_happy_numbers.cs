public class HappyNumber202{
    public bool IsHappy(int n){
        HashSet<int> list = new HashSet<int>();
        while(n != 1 && !list.Contains(n)){
            list.Add(n);
            n = GetNextNum(n);
        }

        return n== 1;
    }
    public int GetNextNum(int n){
        int sum = 0;
        while(n >0){

            int q = n % 10;
            n /= 10;
            sum += q * q;
        }

        return sum;
    }
}
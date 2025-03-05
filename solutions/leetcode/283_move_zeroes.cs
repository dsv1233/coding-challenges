public class MoveZeroes283{
    public void MoveZeroes(int[] nums){
        int n = nums.Length;
        if (n == 0) return;
        if(n == 1 && nums[0] == 0) return;

        int zero_count = 0;
        for(int i=0; i<n;i++){
            if(nums[i] == 0){
                zero_count++;
            }
            else{
                nums[i-zero_count] = nums[i];
            }
        }

        for(int i=n-zero_count; i<n; i++){
            nums[i] = 0;
        }
    }
}
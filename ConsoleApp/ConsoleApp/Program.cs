// See https://aka.ms/new-console-template for more information

public static double calculateAVG(int[] nums){
<<<<<<< HEAD
    int sum = 0;
=======
    int sum = 0;
>>>>>>> feature-new
    if(nums.Length == 0){
        return 0;
    }else{
        foreach(int num in nums){
            sum += num;
        }
    }
    return (double)sum/nums.Length
}

public static int findMax(int[] nums){
    int max = nums[0]
    for(int i = 1; i <nums.Length; i++){
        if(nums[i] > max){
            max = nums[i];
        }
    }
    return max;
}
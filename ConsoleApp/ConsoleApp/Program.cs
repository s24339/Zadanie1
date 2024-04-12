// See https://aka.ms/new-console-template for more information

public static double calculateAVG(int[] nums){
    int sum = 0;
    if(nums.Length == 0){
        return 0;
    }else{
        foreach(int num in nums){
            sum += num;
        }
    }
    return (double)sum/nums.Length
}


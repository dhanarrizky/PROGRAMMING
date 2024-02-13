using System;

namespace SumArr
{
    class Program {
        public static void SumArr(int[] nums, int target){
            int index = 0;
            int[] result = {nums[index]};
            for(int i = 0; i < nums.Length; i++){
                Console.WriteLine("nums : "+nums[i]);

                if((i > 0 ) && i < (nums.Length-1)){
                    if((result[0] + nums[i]) == target){
                        result = result.Concat(new int[] {nums[i]}).ToArray();
                        break;
                    }
                }

                if(i == (nums.Length - 1)){
                    index++;
                }
            }

            for(int i = 0; i < result.Length; i++){
                Console.WriteLine("result : "+result[i]);
            }
        }
        
        static void Main(string[] args){
            // int[] arr = {2,7,11,15};
            int[] arr = {3,2,4};
            // int target = 9;
            int target = 6;
            SumArr(arr, target);
        }
    }
}

// nums = [2,7,11,15], target = 9
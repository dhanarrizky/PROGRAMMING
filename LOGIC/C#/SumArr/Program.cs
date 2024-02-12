using System;

namespace SumArr
{
    class Program {
        public static int[] SumArr(int[] nums, int target){
            int[] result = {0, 0};

            for(int i = 0; i < nums.Length; i ++){
                for(int j = 0; j < nums.Length; j++){
                    if(((nums[i] + nums[j]) == target) && (nums[i] != nums[j])){
                        Console.WriteLine("I : "+ nums[i]);
                        Console.WriteLine("J : "+ nums[j]); 
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }

            return null;

            // foreach(var x in result){
            //     Console.WriteLine(x);
            // }
        }
        
        static void Main(string[] args){
            int[] arr = {2,7,11,15};
            // int[] arr = {3,2,4};
            int target = 9;
            // int target = 6;
            int[] result = SumArr(arr, target);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

// nums = [2,7,11,15], target = 9

// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         int[] result = {0, 0};
//         if(nums.Length == 2){
//             return new int[] {0,1};
//         }

//         for(int i = 0; i < nums.Length; i ++){
//             for(int j = 0; j < nums.Length; j++){
//                 if(((nums[i] + nums[j]) == target) && (nums[i] != nums[j])){
//                     result[0] = i;
//                     result[1] = j;
//                     return result;
//                 }
//             }
//         }
//         return null;
//     }
// }
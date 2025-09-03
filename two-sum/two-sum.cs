public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] result = new int[2];

        for(int i = 0; i < nums.Count(); i++){

            for(int y = 0; y < nums.Count(); y++){

                if(i == y){
                    continue;
                }

                int resultadoSoma = nums[i] + nums[y];

                if(resultadoSoma == target){
                    result = new int[2] {i , y} ;
                    //int[] array = new int[] { 3, 4 };
                    //result = int[i, y];
                    Console.WriteLine("Achouu {0} {1}", i, y);
                    Console.WriteLine("Achouu 2 {0} {1}", result[0], result[1]);
                   

                    foreach(var item in result.ToArray()){
                        Console.WriteLine(item.ToString());
                    }

                    break;
                }
            }
        }

        if(result.Count() == 0){
            Console.WriteLine("Não carregou");
        }else{
            Console.WriteLine("Carregou");
        }

        return result;
    }
}

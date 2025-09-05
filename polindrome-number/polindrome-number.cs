public class Solution {
    public bool IsPalindrome(int x) {

        string number = x.ToString();
        string polinrome = "";

        for(int i = number.Count() ; i > 0; i--){
            polinrome += number[i - 1];     
        }

        if(polinrome == number){
            return true;
        }

        return false;
    }
}
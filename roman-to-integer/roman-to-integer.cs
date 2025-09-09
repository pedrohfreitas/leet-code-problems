public class Solution {
    public int RomanToInt(string s) {
        char[] numbers = s.ToCharArray();

        int result = 0;
        List<int> finalNumbers = new List<int>();

        Dictionary<string, int> romanNumbersDefault = new Dictionary<string, int>();
        romanNumbersDefault.Add("I", 1);
        romanNumbersDefault.Add("V", 5);
        romanNumbersDefault.Add("X", 10);
        romanNumbersDefault.Add("L", 50);
        romanNumbersDefault.Add("C", 100);
        romanNumbersDefault.Add("D", 500);
        romanNumbersDefault.Add("M", 1000);

        List<Data> romanNumbersFinal = new List<Data>();

        for(int i = 0; i < numbers.Length ; i++){
            
            int nextIndex = i + 1;
            if(nextIndex < numbers.Length){
            
                int nextValue = romanNumbersDefault[numbers[i + 1].ToString()];
                int currentValue = romanNumbersDefault[numbers[i].ToString()];
                
                if(currentValue < nextValue){
                    string finalNumber = string.Concat(numbers[i], numbers[i + 1]);
                    int finalValue = nextValue - currentValue;
                    romanNumbersFinal.Add(new Data(finalNumber, finalValue));
                    i++;
                }else{
                    
                    string finalNumber = numbers[i].ToString();
                    int finalValue = currentValue;
                    romanNumbersFinal.Add(new Data(finalNumber, finalValue));
                }

            }else{
                string finalNumber = numbers[i].ToString();
                int finalValue = romanNumbersDefault[numbers[i].ToString()];;
                romanNumbersFinal.Add(new Data(finalNumber, finalValue));
            }
        }

        foreach(Data data in romanNumbersFinal){
            Console.WriteLine("{0} - {1}", data.StringData, data.IntegerData);
            result += data.IntegerData;
        }

        return result;
    }
}

public class Data
{
    public Data(string strValue, int intValue)
    {
        IntegerData = intValue;
        StringData = strValue;
    }

    public int IntegerData { get; private set; }
    public string StringData { get; private set; }
}
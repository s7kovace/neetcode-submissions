public class Solution {
    public int CalPoints(string[] operations) {
        
        var ans = new Stack<int>();

        for (int i = 0; i < operations.Length; i++){

            switch(operations[i]){
                case "C":
                ans.Pop();
                break;
                case "D":
                ans.Push(ans.Peek()*2);
                break;
                case "+":
                var topValue = ans.Peek();
                ans.Pop();
                var secondValue = ans.Peek();
                ans.Push(topValue);
                ans.Push(topValue + secondValue);
                break;
                default:
                ans.Push(int.Parse(operations[i]));
                break;
            }
        }    
        int total = 0;

        foreach (var val in ans){
            total += val;
        }

        return total;
    }
}
namespace FizzBuzz {
    public class FizzBuzzer {
        public string FizzBuzz(int number){
            string output = "";
            
            if(number % 3 == 0 && number % 11 != 0){
                    output += "Fizz";
                }
            if(number % 5 == 0 && number % 11 != 0){
                    output += "Buzz";
                }
            if(number % 7 == 0 && number % 5 != 0 && number % 11 != 0) {
                output += "Bang";
            }
            if(number % 11 == 0){
                output += "Bong";
            }
            if(number % 13 == 0){
                output += "Fezz";
            }
            if(output == ""){
                return number.ToString();
            }
            return output;
        }
    }
}
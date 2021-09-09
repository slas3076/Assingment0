using System;

namespace Assign0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            startUserInterface();
            readUserInput();
        }

        public static bool isLeapYear(int year){
                if(year % 400 == 0) {
                    return true;
                }else if(year % 100 == 0){
                    return false;
                }else if(year % 4 == 0){
                    return true;
                }else{
                    return false;
                }
        }
    
        public static void startUserInterface(){
            Console.WriteLine("This is the leap-year test. Please write a year and press ENTER and it will tell you if it is a leap year:");
        }

        public static void readUserInput(){
            try{
                var userInput = Console.ReadLine();
                var inputtedYear = numberConverter(userInput);
                afterOneFiveEigthTwo(inputtedYear);
                giveResult(inputtedYear);
            }catch (System.FormatException){
                Console.WriteLine("Your input was not a number, please write a year and press ENTER.");
                readUserInput();
            }catch (yearToOldException){
                Console.WriteLine("Your inputted year was too old, must be after 1582. Please write a year afer 1582 and press ENTER");
                readUserInput();
            }
        }

        public static void giveResult(int year){
            string outputString = "";
            if(isLeapYear(year)){
                outputString = "yay";
            }else {
                outputString = "nay";
            }
            Console.WriteLine(outputString);
        }

        public static int numberConverter(string userInput){
            int typedYear = Convert.ToInt32(userInput);
            return typedYear;
        }

        public static bool afterOneFiveEigthTwo(int year){
            if(year > 1582){
                return true;
            }else {
                throw new yearToOldException("The year is before 1583, invalid input.");
            }
        }

        public class yearToOldException : Exception{
            public yearToOldException(){
            }

            public yearToOldException(string message): base(message){
            }
        }
    }
}

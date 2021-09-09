using System;

namespace Assign0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            startUserInterface();
            var inputyear = readUserInput();
            giveResult(inputyear);
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

        public static int readUserInput(){
            int typedYear = Convert.ToInt32(Console.ReadLine());
            return typedYear;
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
    }
}

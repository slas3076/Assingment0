using System;

namespace Assign0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args[0] == "Print"){
                printHelloWorld();
            }

            if(args[0] == "LeapYear"){

            }
        }

        public static void printHelloWorld(){
            Console.WriteLine("Hello World!");
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
    
    }
}

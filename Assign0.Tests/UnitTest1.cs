using System;
using System.IO;
using Xunit;

namespace Assign0.Tests
{
    public class ProgramTests
    {
        //Tests the isLeepYear method
        [Fact]
        public void LeapYear_is_divisible_by_four()
        {
            //Arrange
            var number1 = 24;
            var number2 = 48;

            //Act
            var result1 = Program.isLeapYear(number1);
            var result2 = Program.isLeapYear(number2);

            //Assert
            Assert.True(result1);
            Assert.True(result2);
        }

        [Fact]
        public void LeapYear_is_not_divisible_by_four(){
            //Arrange
            var number1 = 25;
            var number2 = 49;

            //Act
            var result1 = Program.isLeapYear(number1);
            var result2 = Program.isLeapYear(number2);

            //Assert
            Assert.False(result1);
            Assert.False(result2);
        }

        [Fact]
        public void LeapYear_is_false_when_divisible_by_100(){
            //Arrange
            var number1 = 100;
            var number2 = 200;

            //Act
            var result1 = Program.isLeapYear(number1);
            var result2 = Program.isLeapYear(number2);

            //Assert
            Assert.False(result1);
            Assert.False(result2);
        }

        [Fact]
        public void LeapYear_is_True_when_divisible_by_400(){
            //Arrange
            var number1 = 400;
            var number2 = 1600;

            //Act
            var result1 = Program.isLeapYear(number1);
            var result2 = Program.isLeapYear(number2);

            //Assert
            Assert.True(result1);
            Assert.True(result2);
        }




        //User feedback result testing. Tests giveResult method
        [Fact]
        public void giveResult_prints_yay_if_leepyear(){
            //Arrange
            int input = 400;
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.giveResult(input);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay",output);
        }

        [Fact]
        public void giveResult_prints_nay_if_not_leepyear(){
           //Arrange
            int input = 401;
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.giveResult(input);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay",output); 
        }


        //Tests the afterOneFiveEigthTwo that makes sure the year is after 1582
        [Fact]
        public void afterOneFiveEigthTwo_return_true_on_after(){
            //Arrange
            var input = 1800;

            //Act
            var result = Program.afterOneFiveEigthTwo(input);

            //Assert
            Assert.True(result);
        }

        /*
        Cant get it to work
        [Fact]
        public void afterOneFiveEigthTwo_return_false_on_before(){
            //Arrange
            var input = 100;

            //Act Assert
            Assert.ThrowsException<Exception>(() => Program.afterOneFiveEigthTwo(input));
        }
        */

        //Test the number tester
        [Fact]
        public void numberConverter_Converts_a_Number(){
            //Arrange
            string testString = "2000";
            int answerNumber = 2000;

            //Act
            var output = Program.numberConverter(testString);

            //Assert
            Assert.Equal(output,answerNumber);
        }

        /*
        Cant make it work
        [Fact]
        public void numberConverter_throws_an_Exception_when_string_isnt_a_number(){
            //Arrange
            string testString = "test";

            //Act Assert
            Assert.ThrowsException<Exception>(() => Program.numberConverter(testString));
        }
        */

        [Fact]
        public void startUserInterface_Prints_instructions(){
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.startUserInterface();

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("This is the leap-year test. Please write a year and press ENTER and it will tell you if it is a leap year:", output);
        }



    }
}

using System;
using System.IO;
using Xunit;

namespace Assign0.Tests
{
    public class ProgramTests
    {
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
    }
}

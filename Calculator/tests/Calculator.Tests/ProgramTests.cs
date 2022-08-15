using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace Calculator.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ShouldDoRunWithMockConsole()
        {
            MockConsole mockConsole = new MockConsole();
            Program program = new Program();
            program.MyConsole = mockConsole;
            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            mockConsole.Outputs.Enqueue("5");
            mockConsole.Outputs.Enqueue("44");
            mockConsole.Outputs.Enqueue("a");
            mockConsole.Outputs.Enqueue("n");
            program.RunCalculator();
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "Type another number, and then press Enter: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "Your result: 49" +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
            Assert.Equal(expectedResult, Regex.Replace(mockConsole.Inputs.ToString(), @"[\r\t\n]+", string.Empty));
        }
        [Fact]
        public void ShouldDoRunWith()
        {
            StringWriter _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.AppendLine("a");
            _stringBuilder.AppendLine("2");
            _stringBuilder.AppendLine("s");
            _stringBuilder.AppendLine("0");
            _stringBuilder.AppendLine("d");
            _stringBuilder.AppendLine("n");
            StringReader _stringReader = new StringReader(_stringBuilder.ToString());
            Console.SetIn(_stringReader);
            Program.Main(new string[0]);
            var expectedResult = "Console Calculator in C#" +
                                 "------------------------" +
                                 "Type a number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Type another number, and then press Enter: " +
                                 "This is not valid input. Please enter an integer value: " +
                                 "Choose an operator from the following list:" +
                                 "a - Add" +
                                 "s - Subtract" +
                                 "m - Multiply" +
                                 "d - Divide" +
                                 "Your option? " +
                                 "This operation will result in a mathematical error." +
                                 "------------------------" +
                                 "Press 'n' and Enter to close the app, or press any other key and Enter to continue: ";
            Assert.Equal(expectedResult, Regex.Replace(_stringWriter.ToString(), @"[\r\t\n]+", string.Empty));

        }
    }
}

using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Calculator.Tests
{
    internal class MockConsole : IConsole
    {
        public StringBuilder Inputs { get; set; } = new StringBuilder();
        public Queue<string> Outputs { get; set; } = new Queue<string>();
        public string ReadLine()
        {
            return Outputs.Dequeue();        }

        public void Write(string input)
        {
            Inputs.Append(input);        
        }

        public void WriteLine(string input)
        {
            Inputs.AppendLine(input);
        }

        public void WriteLine(string input, params object[] args)
        {
            Inputs.AppendLine(string.Format(input,args));
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    interface IWriter
    {
        void Write(string text);

    }

    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class FileWriter : IWriter {
        public void Write(string text)
        {
            File.WriteAllText("test.txt", text);

        }


    }


}

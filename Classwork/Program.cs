using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var male = Gender.Male;
            var malenumber = (int)Gender.Male;
            Console.WriteLine($"Male enum text value: {male}");
            Console.WriteLine(  $"Male number value: {malenumber}");


            var person = new Person
            {

                Name = "Artis",
                Gender = Gender.Male

            };


            Console.WriteLine(  $"Hello ma name is {person.Name} and I am  {person.Gender}");


            IWriter consolewriter = new ConsoleWriter();
            IWriter Filewriter = new FileWriter();
            //1 
            SayHello(consolewriter);

            //2
            SayHello(Filewriter);


            var writerList = new List<IWriter>();

            writerList.Add(consolewriter);
            writerList.Add(consolewriter);
            writerList.Add(Filewriter);

            foreach (IWriter writer in writerList) {
                SayHello(writer);
            }
            


            Console.ReadLine();
        }


        private static void SayHello(IWriter writer) {

            writer.Write("Hello from Artis");
        
        }



    }
}

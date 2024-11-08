using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event newevent = new Event(1, "Calgary");
            string PATH = Environment.CurrentDirectory+ "/event.txt";
            
            using(StreamWriter writer = new StreamWriter(PATH))
            {
                writer.WriteLine(newevent.event_number);
                writer.WriteLine(newevent.location);
            }
            using (StreamReader reader = new StreamReader(PATH))
            {
                Console.WriteLine(reader.ReadToEnd());
                //so idk where Tech Competition comes from in this lab so yeah
            }

            ReadFromFile(PATH);

            Console.ReadLine();
        }

        static void ReadFromFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.WriteLine("hackathon");
            }
            using (StreamReader reader = new StreamReader(path))
            {
                for(int i = 0; i < 2; i++)
                {
                    reader.ReadLine();
                }
                string line = reader.ReadLine();
                Console.WriteLine("Word in: "+line);
                Console.WriteLine("The First Character is: " + line[0] );
                Console.WriteLine("The Middle Character is: " + line[line.Length/2]);
                Console.WriteLine("The Last Character is: " + line[line.Length-1]);

            }
        }
    }
}

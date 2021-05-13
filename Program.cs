using System;

namespace FileEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWriter fileWriter = new FileWriter();
            //fileWriter.handler += () => Console.WriteLine("test");
            fileWriter.writeToFile("\nHowdy, World!");
            
            

        }
    }
}

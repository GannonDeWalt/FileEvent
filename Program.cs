using System;

namespace FileEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWriter fileWriter = new FileWriter();
            fileWriter.writeToFile("\nHowdy, World!");

        }
    }
}

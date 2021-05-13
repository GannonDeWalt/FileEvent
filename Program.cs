using System;


//encode = writetofile
//onvideoencoded = OnWriteComplete
//videoencoded = handler

namespace FileEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "\n Howdy, World!";
            FileWriter fileWriter = new FileWriter(); // publisher
            var displayService = new DisplayService(); //subscriber

            fileWriter.handler += displayService.Display;
            //fileWriter.writeToFile("\nHowdy, World!");
            
            
            fileWriter.writeToFile(message);

        }
    }
}

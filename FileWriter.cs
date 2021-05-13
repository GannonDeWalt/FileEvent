using System;
using System.IO;
namespace FileEvent
{
    public class FileWriter{
        public void writeToFile(string message){
            //write to text.txt
            File.AppendAllText("text.txt", message);
        }
    }
}
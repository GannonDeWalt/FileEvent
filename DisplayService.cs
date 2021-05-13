using System;

namespace FileEvent
{
    public class DisplayService{
        public void Display(object s, EventArgs args){
            Console.WriteLine("File Write Completed");

        }
    }

}
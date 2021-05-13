using System;

namespace FileEvent
{
    public class DisplayService{
        public void Display(object s, WriteCompleteEventArgs args){
            Console.WriteLine("File Write Completed" + args.message1);
        }
    }

}
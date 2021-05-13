using System;
using System.IO;
using System.Net;

namespace FileEvent
{
    public class FileWriter{
        
        public event EventHandler<WriteCompleteEventArgs> handler;
        WriteCompleteEventArgs writeArgs = new WriteCompleteEventArgs("fdf");

        public void writeToFile(string message){
            //write to text.txt
            File.AppendAllText("text.txt", message);
            OnWriteComplete(writeArgs);
        }
        
        // public delegate OnWriteComplete(WriteCompleteEventArgs e);
        protected virtual void OnWriteComplete(WriteCompleteEventArgs e)
        {
            if(handler != null)  handler(this, e);
        }

        
    }
        
    }

    public class WriteCompleteEventArgs : EventArgs
    {
        private string message;

        public WriteCompleteEventArgs(string message)
        {
            this.message = message;
        }

}
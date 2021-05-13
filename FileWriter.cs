using System;
using System.IO;
using System.Net;

namespace FileEvent
{

    public class WriteCompleteEventArgs : EventArgs
    {
        public string message1 { get; set; }

    }

    public class FileWriter
    {

        public event EventHandler<WriteCompleteEventArgs> handler;
        //WriteCompleteEventArgs writeArgs = new WriteCompleteEventArgs("fdf");

        public void writeToFile(string message)
        {
            //write to text.txt
            File.AppendAllText("text.txt", message);
            OnWriteComplete(message);
        }

        // public delegate OnWriteComplete(WriteCompleteEventArgs e);
        protected virtual void OnWriteComplete(string message)
        {
            if (handler != null)
                handler(this, new WriteCompleteEventArgs() { message1 = message });
        }


    }


}



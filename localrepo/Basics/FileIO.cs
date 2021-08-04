using System;
using System.IO;
namespace fIO
{
    class Filei
    {
         string path = "aayush.txt";
        public void fileio()
        {
            //Using @ ahead of the string value inside "" to let compiler know that \ slashes are not escape sequence
            var x = File.ReadAllText(@"C:\Users\AaYuSh.DESKTOP-S65N1DS\Documents\examdotnet\Csharpdotnet\localrepo\aayush.txt");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(x);
            var path = "aayush.txt";
            var content = "This is the written line, Hope you got here.";
            File.WriteAllText(path, content);
        }
        public void fileinfo()
        {
            FileInfo fileInfo = new FileInfo(path);
            var size =fileInfo.Length;
            var creationdate = fileInfo.CreationTime;
            Console.WriteLine($"File size::{size} \a File creeation date::{creationdate}" );
        }
    }
}
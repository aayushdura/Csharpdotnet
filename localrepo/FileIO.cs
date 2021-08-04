using System;
using System.IO;
namespace fIO{
class Filei{
    public void fileio(){
        //Using @ ahead of the string value inside "" to let compiler know that \ slashes are not escape sequence
       var x= File.ReadAllText(@"C:\Users\AaYuSh.DESKTOP-S65N1DS\Documents\examdotnet\Csharpdotnet\localrepo\aayush.txt");
        Console.ForegroundColor=ConsoleColor.Yellow;
        Console.WriteLine(x);
    }
}
}
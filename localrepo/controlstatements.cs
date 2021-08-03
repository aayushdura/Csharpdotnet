using System;
class control
{
    static void Main2(string[] args)
    {
        control ctrl = new control();
        ctrl.ifelse();
        Console.ReadKey();

    }
    
    void ifelse()
    {
        int x =0;
        Console.Write("\nEnter any number::");
        x = Console.Read();
        if(x%2==0)
        {
            Console.Write("\n The number is even");
            
        }
        else{
            Console.Write("\n The number is odd");
        }
    }
}
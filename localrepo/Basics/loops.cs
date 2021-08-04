using System;
class loops
{
    static void Main123(string[] args)
    {
        loops lp = new loops();
        //lp.learnloop();
        lp.whilelearn();
    }
    //using for each loop 
    void learnloop()

    {
        int[] ages = { 12, 65, 74, 25, 114 };
        foreach (int x in ages)
        {
            if (x % 2 == 0)
            {
                Console.Write("\nThis is an even age::" + x);
            }
            else
            {
                Console.Write("\nThis is an odd age::" + x);
            }
        }
    }
    //using while loop
    void whilelearn()
    {
        char value = 'Y';
        while (value == 'Y')
        {
            Console.WriteLine("Hey Aayush, Good Going");
            Console.WriteLine("Do you want to print it once again \n Then Please Enter 'Y'");
            value = Console.ReadKey().KeyChar;
        }
    }

}
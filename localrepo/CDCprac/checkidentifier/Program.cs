using System;

namespace CDCprac
{
    public class identifier
    {
        public bool validid(String str)
        {
            int i = 0;
            if (((str[0] >= 'a' && str[0] <= 'z')
                || (str[0] >= 'A' && str[0] <= 'Z')
                || str[0] == '_'))
                return true;
           for (i = 1; i < str.Length; i++)
    {
        if (!((str[i] >= 'a' && str[i] <= 'z')
            || (str[i] >= 'A' && str[i] <= 'Z')
            || (str[i] >= '0' && str[i] <= '9')
            || str[i] == '_'))
            return false;
    }

            return false;


        }
        public static void Main(string[] args)
        {
            identifier cd = new identifier();
            String str;
            Console.Write("Enter any identifier: \a");
            str = Console.ReadLine();
            var result = cd.validid(str);
            if (result == false)
            {
                Console.Write("the identifier is invalid \n");
            }
            else
            {
                Console.WriteLine("The identifier is valid");
            }

        Console.ReadKey();

        }
    }
}

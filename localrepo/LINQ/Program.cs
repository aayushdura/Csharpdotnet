using System;
using System.Linq;
using System.Collections.Generic;
using con;
    class drive
    {   
        static void Main(string[] args)
        {
            country c1 = new country("Nepal","asia");
           country c2= new country("America","north americal");
           List<country> countries= new List<country>{c1,c2};
           var results= from country in countries
                        where country.Continent =="asia"
                        select country;
            Console.WriteLine(results);
        }
    }


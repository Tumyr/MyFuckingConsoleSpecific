using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleSpecific
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SawingCenter sc = new SawingCenter();
            sc.CreateDetail();
            foreach (Detail d in sc)
            {
                Console.WriteLine(d);
            }

            
            Console.ReadLine();
        }
    }
}


        

  

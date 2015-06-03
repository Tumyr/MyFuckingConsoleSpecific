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
            Detail dt = new Detail();
            dt.Lenght = dt.ShowDistance();
            Console.WriteLine("Длина = {0}", dt.Lenght);

            FileProcessor fp = new FileProcessor();
            fp.SelectFile();
            Console.ReadLine();
        }
    }
}


        

  

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
         static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your external IP Address is :");
             Console.WriteLine("\n \n");
            ip();
            
         

            
            

        }

        static void ip()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            string url = "http://checkip.dyndns.org";  
            WebRequest req = WebRequest.Create(url);
            WebResponse resp = req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);                  
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            Console.WriteLine(a4);
            Console.WriteLine("\n \n \n \n \n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press F5 to refresh");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press Q to exit");
            ConsoleKeyInfo ck;
            ck = Console.ReadKey();
            while (ck.Key == ConsoleKey.F5)
            {
                Console.Clear();
                Main();
            }
            while (ck.Key == ConsoleKey.Q)
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
                Console.WriteLine("enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("enter your family");
                string family = Console.ReadLine();
                Console.WriteLine("enter your age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your national id");
                int nationalid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your address");
                string address = Console.ReadLine();
                Console.WriteLine(@"name: {0} family: {1} age: {2} national id: {3} address: {4}", name, family, age.ToString(), nationalid.ToString(), address);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("we dont know what happened but this is eror message:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine() ;
            }
        }
    }
}

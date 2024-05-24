using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace training13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chose operation :");
            string choice = Console.ReadLine();
            string result = "";
            Console.WriteLine("enter two numbers seperated by Enter ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case "+": {
                        add op = new add();
                        result = op.Add(a, b).ToString();
                        break;
                }
                case "-":
                    {
                        subtract op = new subtract();
                        result = op.Subtracr(a, b).ToString();
                        break;
                    }
                case "*":
                    {
                        multiple op = new multiple();
                        result = op.Multiple(a, b).ToString();
                        break;
                    }
                case "/":
                    {
                        divide op = new divide();
                        result = op.Divide(a, b).ToString();
                        break;
                    }
            }
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}

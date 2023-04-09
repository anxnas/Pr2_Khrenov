using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int i = 0;
            int j = 0;

            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов");
            j = Convert.ToInt32(Console.ReadLine());


            var SOL = new Class1(i, j);


        }
    }
}

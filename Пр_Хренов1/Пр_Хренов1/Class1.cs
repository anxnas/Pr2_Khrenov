using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class Class1
    {
        public Class1(int i, int j)
        {
            I = i;
            J = j;

            int n = i;
            int m = j;

            int s = 0;
            int[,] b = new int[n, m];

            for (int ii = 0; ii < n; ii++)
            {
                for (int jj = 0; jj < m; jj++)
                {
                    b[ii, jj] = Convert.ToInt32(Math.Sin((ii + jj) / 2));
                    if (b[ii, jj] > 0) s += 1;
                }
            }

            Class1_teg(s);


            Console.WriteLine("Ответ: число положительных элементов = {0}", s);

        }

        public int Class1_teg(int s)
        {
            return s;

        }


        public int I { get; set; }
        public int J { get; set; }



    }
}

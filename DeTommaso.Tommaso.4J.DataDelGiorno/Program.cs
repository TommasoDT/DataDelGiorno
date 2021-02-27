using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeTommaso.Tommaso._4J.DataDelGiorno.Models;

namespace DeTommaso.Tommaso._4J.DataDelGiorno
{
    class Program
    {
        static void Main(string[] args)
        {
            Data oggi = new Data(21, 11, 2020);
            Data compleanno = new Data(23, 04, 2003);

            Console.WriteLine("Data oggi: " + oggi.ToString());
            Console.WriteLine("Data compleanno: " + compleanno.ToString());

            if (compleanno > oggi)
                Console.WriteLine("Data compleanno è maggiore di Data oggi");
            else
                Console.WriteLine("Data compleanno è minore di Data oggi");

            Console.ReadLine();
        }
    }
}

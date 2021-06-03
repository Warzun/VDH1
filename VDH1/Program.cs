using System;
using VDH1.Students.DanielDaniel;
using VDH1.Teachers.Niels;

namespace VDH1
{
    class Program
    {
        // Code momments.
        static void Main(string[] args)
        {
            Console.WriteLine((new Niels()).FullName);
            Console.WriteLine((new Daniel().FullName));
        }
    }
}

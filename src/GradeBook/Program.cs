using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Erin's book");
            book.AddGrade(93.41);
            book.AddGrade(93.31);
            book.AddGrade(93.21);
            book.AddGrade(93.61);
            book.Showstatistics();
            
        }
    }
}

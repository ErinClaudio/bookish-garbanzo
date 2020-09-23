using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades= new List<double>();
            this.name = name;
        }
        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public List<double> grades;
        private string name;

    public void Showstatistics()
    {
      var g = 0.0;
            var t = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;

            foreach(var thing in grades)
            {
                highGrade = Math.Max(thing, highGrade);
                lowGrade = Math.Min(thing, lowGrade);
                g += thing;
            }
                t = g / grades.Count;
            
            System.Console.WriteLine($"the average is {t:n1}");
            System.Console.WriteLine($"the high grade is {highGrade}");
            System.Console.WriteLine($"the low grade is {lowGrade}");
    }
  }
}
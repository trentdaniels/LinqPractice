using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    public class Grades
    {
        public Grades()
        {
        }
        public double GetClassAverage(List<string> listOfClassGrades)
        {
            var classAverage = listOfClassGrades.Select(listOfIndividualGrades => listOfIndividualGrades.Split(',').Select(grade => double.Parse(grade)).Where(grade => grade > listOfIndividualGrades.Split(',').Select(newGrade => double.Parse(newGrade)).Min()).Average()).Average();
            return classAverage;
        }
    }
}

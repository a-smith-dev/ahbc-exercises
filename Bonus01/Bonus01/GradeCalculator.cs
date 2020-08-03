using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus01
{
    public class GradeCalculator
    {
        public string GetGrade(int grade)
        {
            if (grade < 0 || grade > 100)
            {
                return null;
            }

            if (grade <= 60)
            {
                return "F";
            }

            if (grade < 67)
            {
                return "D";
            }

            if (grade < 80)
            {
                return "C";
            }

            if (grade < 88)
            {
                return "B";
            }

            return "A";
        }
    }
}

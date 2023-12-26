using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
    public enum EducationStage
    {
        Elementary,
        Secondary,
        Higher
    }

    public class Student
    {
        private static char currentName = 'A';
        public string FIO { get; set; }
        public int Grade { get; set; }
        public double Performance { get; set; }
        public EducationStage Stage { get; set; }

        public Student()
        {
            FIO = currentName.ToString();
            Grade = 1;
            Performance = 5.0;
            Stage = EducationStage.Elementary;
            currentName++;
        }

        public Student(string fio, int grade, double performance)
        {
            if (grade < 1 || grade > 11)
                throw new ArgumentException("Invalid grade");

            if (performance < 0 || performance > 5)
                throw new ArgumentException("Invalid performance");

            FIO = fio;
            Grade = grade;
            Performance = performance;

            if (grade <= 4)
                Stage = EducationStage.Elementary;
            else if (grade <= 8)
                Stage = EducationStage.Secondary;
            else
                Stage = EducationStage.Higher;
        }

        public void Pass()
        {
            if (Grade < 11)
            {
                Grade++;
                if (Grade == 5 || Grade == 9)
                    Stage++;
            }
        }

        public override string ToString()
        {
            return $"{FIO}, {Stage} school, {Grade} class, {Performance} points";
        }
    }
}


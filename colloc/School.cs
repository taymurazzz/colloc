using colloc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colloc
{
    public class School
    {
        public delegate void SortMethod();
        public string Name { get; set; }
        public List<Student> students { get; set; }

        public School(string name)
        {
            Name = name;
            students = new List<Student>();
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public override string ToString()
        {
            var result = "";
            for (int i = 0; i < students.Count; i++)
            {
                result += $"{i + 1}. {students[i]}\n";
            }
            return result;
        }
        public void Sort()
        {
            SortMethod method1 = BubbleSort;
            SSort(method1);

            SortMethod method2 = CustomSort;
            SSort(method2);
        }
        public void SSort(SortMethod ssort)
        {
            ssort();
            Console.WriteLine(ToString());
        }
        public void BubbleSort()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(students[j].FIO, students[j + 1].FIO) > 0)
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }
        public void CustomSort()
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    int gradeComparison = students[j].Grade.CompareTo(students[j + 1].Grade);

                    if (gradeComparison > 0 || (gradeComparison == 0 && string.Compare(students[j].FIO, students[j + 1].FIO) > 0))
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

    }
}


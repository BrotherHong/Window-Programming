using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{
    internal enum GPAType
    {
        NEW, OLD,
    }

    internal class GradeCalculator
    {
        private List<Subject> subjects;

        public GradeCalculator()
        {
            subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            if (subjects.Contains(subject))
            {
                throw new Exception("科目已存在");
            }
            subjects.Add(subject);
        }

        public void RemoveSubject(string subjectCode)
        {
            if (!subjects.Exists(s => s.SubjectCode == subjectCode))
            {
                throw new Exception("科目不存在");
            }
            int index = subjects.FindIndex(s => s.SubjectCode == subjectCode);
            subjects.RemoveAt(index);
        }

        public void UpdateSubject(Subject subject)
        {
            if (!subjects.Contains(subject))
            {
                throw new Exception("科目不存在");
            }
            Subject target = subjects.Find((s) => s.Equals(subject))!;
            target.Grade = subject.Grade;
            target.Credit = subject.Credit;
        }

        public List<Subject> GetSubjects()
        {
            return subjects;
        }

        public string SortAndPrintGradeAsString()
        {
            SortSubjects();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("我的成績單：");
            sb.AppendLine(string.Format("{0}    {1}    {2}    {3}    {4}", "編號", "科目代碼", "分數", "等第", "學分數"));
            int count = 1;
            foreach (Subject subject in subjects)
            {
                string gpaString = GPAToRankString(GPAType.NEW, subject.GetGPA(GPAType.NEW));
                sb.AppendLine(string.Format("{0,-8}{1,-12}{2,-8}{3,-8}{4,-9}", count, subject.SubjectCode, subject.Grade, gpaString, subject.Credit));
                count++;
            }
            sb.AppendLine(string.Format("總平均：{0:0.00}", GradeAverage()));
            sb.AppendLine(string.Format("GPA: {0:0.0}/4.0 (舊制), {1:0.0}/4.3 (新制)", GPAAverage(GPAType.OLD), GPAAverage(GPAType.NEW)));
            sb.AppendLine(string.Format("實拿學分數/總學分數: {0}/{1}", RealGetCredit(), TotalCredit()));

            return sb.ToString();
        }

        private double GradeAverage()
        {
            return TotalWeightedGrade() / TotalCredit();
        }

        private double TotalWeightedGrade()
        {
            return subjects.Sum(s => s.Grade * s.Credit);
        }

        private double GPAAverage(GPAType type)
        {
            return TotalWeightedGPA(type) / TotalCredit();
        }

        private double TotalWeightedGPA(GPAType type)
        {
            return subjects.Sum(s => s.GetGPA(type) * s.Credit);
        }

        private int TotalCredit()
        {
            return subjects.Sum(s => s.Credit);
        }

        private int RealGetCredit()
        {
            return subjects.FindAll(s => s.Grade >= 60).Sum(s => s.Credit);
        }

        private static string GPAToRankString(GPAType type, double gpa)
        {
            if (type == GPAType.NEW)
            {
                switch (gpa)
                {
                    case 4.3: return "A+";
                    case 4.0: return "A";
                    case 3.7: return "A-";
                    case 3.3: return "B+";
                    case 3.0: return "B";
                    case 2.7: return "B-";
                    case 2.3: return "C+";
                    case 2.0: return "C";
                    case 1.7: return "C-";
                    case 0: return "F";
                }
            } else  if (type == GPAType.OLD)
            {
                switch (gpa)
                {
                    case 4: return "A";
                    case 3: return "B";
                    case 2: return "C";
                    case 1: return "D";
                    case 0: return "E";
                }
            }
            return "ERROR";
        }

        private void SortSubjects()
        {
            subjects.Sort();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{

    internal class Subject : IComparable<Subject>, IEquatable<Subject>
    {
        public string SubjectCode;
        public int Grade;
        public int Credit;

        public Subject(string subjectCode, int grade, int credit)
        {
            SubjectCode = subjectCode;
            Grade = grade;
            Credit = credit;
        }

        public double GetGPA(GPAType type)
        {
            if (type == GPAType.NEW)
            {
                if (Grade >= 90) return 4.3;
                else if (Grade >= 85) return 4.0;
                else if (Grade >= 80) return 3.7;
                else if (Grade >= 77) return 3.3;
                else if (Grade >= 73) return 3.0;
                else if (Grade >= 70) return 2.7;
                else if (Grade >= 67) return 2.3;
                else if (Grade >= 63) return 2.0;
                else if (Grade >= 60) return 1.7;
                else return 0;
            } else if (type == GPAType.OLD)
            {
                if (Grade >= 80) return 4;
                else if (Grade >= 70) return 3;
                else if (Grade >= 60) return 2;
                else if (Grade >= 50) return 1;
                else return 0;
            }
            return 0;
        }

        int IComparable<Subject>.CompareTo(Subject? other)
        {
            if (other == null) return 1;
            return other.Grade - Grade;
        }

        bool IEquatable<Subject>.Equals(Subject? other)
        {
            if (other == null) return false;
            return SubjectCode == other.SubjectCode;
        }

        public override bool Equals(object? other)
        {
            if (other is not Subject) return false;
            return SubjectCode == (other as Subject)!.SubjectCode;
        }
    }
}

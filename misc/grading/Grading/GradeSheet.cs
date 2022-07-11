using System;
using System.Collections.Generic;
using System.Text;

namespace Grading
{
    public class GradeSheet
    {
        private Dictionary<string, List<double>> grades;
        public static GradeSheet of(string csv)
        {
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            var lines = csv.Split('\n');
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var subject = parts[0].Trim();
                var grade = Double.Parse(parts[1].Trim());
                if (!grades.ContainsKey(subject))
                {
                    grades[subject] = new List<double>();
                }
                grades[subject].Add(grade);
            }
            return new GradeSheet(grades);
        }

        private GradeSheet(Dictionary<string, List<double>> grades)
        {
            this.grades = grades;
        }

        public int GradeCount()
        {
            var gradeCount = 0;
            foreach (var subject in this.grades.Keys)
            {
                foreach (var grade in this.grades[subject])
                {
                    gradeCount++;
                }
            }
            return gradeCount;
        }

        public string ExportCSV()
        {
            var csv = new StringBuilder("");
            foreach (var subject in this.grades.Keys)
            {
                foreach (var grade in this.grades[subject])
                {
                    csv.AppendFormat("{0},{1}", subject, grade);
                }
            }
            return csv.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ch7_proj2_gradeconverterapp
{
    internal class Grade
    {
        public string LetterGrade { get; set; }
        public int NumberGrade {  get; set; }

        public Grade()
        {

        }

        public Grade(int NumberGrade)
        {
            this.NumberGrade = NumberGrade;
            if (NumberGrade >= 90)
            {
                this.LetterGrade = "A";
            }
            else if (NumberGrade >= 80)
            { 
                this.LetterGrade = "B";
            }
            else if (NumberGrade >= 70)
            {
                this.LetterGrade = "C";
            }
            else if (NumberGrade >= 60)
            {
                this.LetterGrade = "D";
            }
            else
            {
                this.LetterGrade = "F";
            }
        }
        public string ToString()
        {
            return $"Letter grade: {LetterGrade}";
        }
    }
}

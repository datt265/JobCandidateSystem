using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Job_Candidate_System
{
    class Programmer : Candidate //This class extends Candidate
    {
        public string skills;


        public Programmer(string iSurname, string iId, double iSalary, List<string> iSkills)
            : base(iSurname, iId, iSalary) // Call base-class constructor first
        {
            // Then initialize fields in this class
            skills = string.Join(" ", iSkills.ToArray());

        }

        public bool CompareSalary(double SalaryOffered, double Salary)
        {
            if (SalaryOffered == Salary) // the values are the same
                return true;

            else if (SalaryOffered >= Salary) // the first value is greater or equal to,the second value
                return true;

            else // the second string is greater than the first string
                return false;
        }//end CompareSalary


        public override string ToString()
        {
            return base.ToString() + " " + this.skills;
        }
    }
}

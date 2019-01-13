using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Job_Candidate_System
{
    class Candidate
    {
        public string surname;
        public string id;
        public double salary;

        public Candidate(string iSurname, string iId, double iSalary)
        {
            this.surname = iSurname;
            this.id = iId;
            this.salary = iSalary;
        }

        public override string ToString()
        {
            return this.surname + " " + this.id + " " + this.salary;
        }

        public string SearchById(string Sid)
        {//compares value of id to that stored
            if (Sid == this.id)
                return id;
            else
                return null;
        }//end SearchById
    }
}

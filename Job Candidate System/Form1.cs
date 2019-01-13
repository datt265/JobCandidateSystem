using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Job_Candidate_System
{
    public partial class Form1 : Form
    {
        List<string> skills = new List<string>(); //A generic list of strings is created
        Candidate c;


        //A generic list of strings is created
        // used as a temporary list
        List<string> arrSkillRequired = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rdbAdmin.Checked = true;
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rdbAdmin)
            {
                grpBoxProgSkills.Enabled = false;
            }

            if (sender == rdbProgrammer)
            {
                grpBoxProgSkills.Enabled = true;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                c = new Candidate(txtSurname.Text, txtID.Text, Convert.ToDouble(txtSalary.Text));
            }
            else
                if (rdbProgrammer.Checked)
                {
                    if (chkC.Checked)
                    {
                        skills.Add("C#");
                    }
                    if (chkJava.Checked)
                    {
                        skills.Add("Java");
                    }
                    if (chkDelphi.Checked)
                    {
                        skills.Add("Delphi");
                    }
                    if (chkLinux.Checked)
                    {
                        skills.Add("Linux");
                    }
                    if (chkPHP.Checked)
                    {
                        skills.Add("PHP");
                    }
                    c = new Programmer(txtSurname.Text, txtID.Text, Convert.ToDouble(txtSalary.Text), skills);
                }
            CandidateListBox.Items.Add(c);
            skills.Clear();
        }


        private void cmdListProgrammers_Click(object sender, EventArgs e)
        {
            bool foundProgrammer = false;
            // iterates through the base class, 
            // and checks what type 
            foreach (Candidate c in CandidateListBox.Items)
            {
                Programmer p = c as Programmer;
                if (p != null)
                {
                    foundProgrammer = true;
                    QueryListBox.Items.Add(c.surname + " " + c.id + " " + c.salary + " " + Convert.ToString(p.skills));
                }//end if
            }//end for each
            if (foundProgrammer == false)
            {
                MessageBox.Show("No Programmers are stored in the list", "No Match");
            }
        }//end cmdListProgrammers_Click


        private void cmdSearchById_Click(object sender, EventArgs e)
        {
            bool matchId = false;
            foreach (Candidate c in CandidateListBox.Items)
            {
                if (txtSearchId.Text == c.SearchById(txtSearchId.Text))
                {
                    Programmer p = c as Programmer;
                    if ((p != null))
                    {
                        matchId = true;
                        QueryListBox.Items.Add(c.surname + " " + c.id + " " + c.salary + " " + Convert.ToString(p.skills));
                    }//end if

                    else if ((p == null))
                    {
                        matchId = true;
                        QueryListBox.Items.Add(c.surname + " " + c.id + " " + c.salary);
                    }//end else if
                }//end if      
            }//end foreach
            if (matchId == false)
            {
                MessageBox.Show("No Matching Candidate Found", "Not Found");
            }//end if
        }//end cmdSearchById_Click


        private void cmdListAllCandidates_Click(object sender, EventArgs e)
        {
            bool foundCandidate = false;
            // iterates through the base class, 
            // and checks what type             
            foreach (Candidate c in CandidateListBox.Items)
            {
                Programmer p = c as Programmer;
                if (p != null)
                {
                    foundCandidate = true;
                    QueryListBox.Items.Add(c.surname + " " + c.id + " " + c.salary + " " + Convert.ToString(p.skills));
                }//end if
                else
                {
                    foundCandidate = true;
                    QueryListBox.Items.Add(c.surname + " " + c.id + " " + c.salary);
                }//end else
            }//end foreach
            if (foundCandidate == false)
            {
                MessageBox.Show("List is Empty", "Empty");
            }//end if
        }//end cmdListAllCandidates_Click        


        private void cmdListSuitableProgrammers_Click(object sender, EventArgs e)
        {
            //calls method, which adds the items checked
            //from the Programmer Query section to a list 'arrSkillRequired'
            populateArrSkillsRequired();
            bool foundProgrammer = false;
            // iterates through the base class, 
            // and checks what type
            foreach (Candidate c in CandidateListBox.Items)
            {
                Programmer p = c as Programmer;
                if (p != null)
                {
                    string searchIn = p.skills.ToString();
                    string searchFor = string.Join(" ", arrSkillRequired.ToArray());
                    /* The "searchFor" string is split into separate strings,
                     * each delimited by a space. So, with the "searchFor" 
                     * string being "C# PHP", the Split would create two new
                     * strings, "C#" and "PHP". These are collected together into
                     * an array of strings, and assigned to the "findThese" variable.
                     */
                    string[] findThese = searchFor.Split(' ');

                    bool hasAll = true;
                    foreach (string s in findThese)
                    {
                        if (!searchIn.Contains(s))
                        {
                            hasAll = false;
                            break;
                        }//end if
                    }//end foreach

                    if ((p.CompareSalary(Convert.ToDouble(txtSalaryOffered.Text), c.salary)) == true && (hasAll))
                    {
                        foundProgrammer = true;
                        QueryListBox.Items.Add(c.surname + " " + c.id + " " + c.salary + " " + Convert.ToString(p.skills));
                    }//end if                
                }//end if                
            }//end foreach
            if (foundProgrammer == false)
            {
                MessageBox.Show("No valid Programmer has been found", "No Match");
            }//end if
            arrSkillRequired.Clear(); //temporary list 'arrSkillRequired'is cleared
        }//end cmdListSuitableProgrammers_Click       


        private void populateArrSkillsRequired()
        {
            if (checkC.Checked)
            {
                arrSkillRequired.Add("C#");
            }
            if (checkJava.Checked)
            {
                arrSkillRequired.Add("Java");
            }
            if (checkDelphi.Checked)
            {
                arrSkillRequired.Add("Delphi");
            }
            if (checkLinux.Checked)
            {
                arrSkillRequired.Add("Linux");
            }
            if (checkPHP.Checked)
            {
                arrSkillRequired.Add("PHP");
            }
        }//end populateArrSkillsRequired       


        private void cmdClearQueryBox_Click(object sender, EventArgs e)
        {
            this.QueryListBox.Items.Clear();
        }//end cmdClearQueryBox_Click


        private void cmdSave_Click(object sender, EventArgs e)
        {
            MyFile mf = new MyFile();
            
            foreach (object o in CandidateListBox.Items)
                mf.ToTxt(o);
            
        }
    }
}

namespace Job_Candidate_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbCndtEntry = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxProgSkills = new System.Windows.Forms.GroupBox();
            this.chkPHP = new System.Windows.Forms.CheckBox();
            this.chkLinux = new System.Windows.Forms.CheckBox();
            this.chkDelphi = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.rdbProgrammer = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.CandidateListBox = new System.Windows.Forms.ListBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.cmdSearchById = new System.Windows.Forms.Button();
            this.cmdListProgrammers = new System.Windows.Forms.Button();
            this.QueryListBox = new System.Windows.Forms.ListBox();
            this.grpbShowQuered = new System.Windows.Forms.GroupBox();
            this.grpbCndtQuery = new System.Windows.Forms.GroupBox();
            this.lblInputID = new System.Windows.Forms.Label();
            this.cmdListAllCandidates = new System.Windows.Forms.Button();
            this.grpbProgQuery = new System.Windows.Forms.GroupBox();
            this.lblSalaryOffer = new System.Windows.Forms.Label();
            this.lblInputSalary = new System.Windows.Forms.Label();
            this.grpBoxReqProgSkills = new System.Windows.Forms.GroupBox();
            this.checkPHP = new System.Windows.Forms.CheckBox();
            this.checkLinux = new System.Windows.Forms.CheckBox();
            this.checkDelphi = new System.Windows.Forms.CheckBox();
            this.checkJava = new System.Windows.Forms.CheckBox();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.cmdListSuitableProgrammers = new System.Windows.Forms.Button();
            this.txtSalaryOffered = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClearQueryBox = new System.Windows.Forms.Button();
            this.grpbCndtEntry.SuspendLayout();
            this.grpBoxProgSkills.SuspendLayout();
            this.grpbShowQuered.SuspendLayout();
            this.grpbCndtQuery.SuspendLayout();
            this.grpbProgQuery.SuspendLayout();
            this.grpBoxReqProgSkills.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCndtEntry
            // 
            this.grpbCndtEntry.Controls.Add(this.label1);
            this.grpbCndtEntry.Controls.Add(this.grpBoxProgSkills);
            this.grpbCndtEntry.Controls.Add(this.lblSalary);
            this.grpbCndtEntry.Controls.Add(this.txtSalary);
            this.grpbCndtEntry.Controls.Add(this.btnAdd);
            this.grpbCndtEntry.Controls.Add(this.txtID);
            this.grpbCndtEntry.Controls.Add(this.txtSurname);
            this.grpbCndtEntry.Controls.Add(this.lblId);
            this.grpbCndtEntry.Controls.Add(this.lblSurname);
            this.grpbCndtEntry.Controls.Add(this.rdbProgrammer);
            this.grpbCndtEntry.Controls.Add(this.rdbAdmin);
            this.grpbCndtEntry.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCndtEntry.Location = new System.Drawing.Point(12, 3);
            this.grpbCndtEntry.Name = "grpbCndtEntry";
            this.grpbCndtEntry.Size = new System.Drawing.Size(345, 212);
            this.grpbCndtEntry.TabIndex = 0;
            this.grpbCndtEntry.TabStop = false;
            this.grpbCndtEntry.Text = "Candidate Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = " Input Salary Requested  ";
            // 
            // grpBoxProgSkills
            // 
            this.grpBoxProgSkills.Controls.Add(this.chkPHP);
            this.grpBoxProgSkills.Controls.Add(this.chkLinux);
            this.grpBoxProgSkills.Controls.Add(this.chkDelphi);
            this.grpBoxProgSkills.Controls.Add(this.chkJava);
            this.grpBoxProgSkills.Controls.Add(this.chkC);
            this.grpBoxProgSkills.Enabled = false;
            this.grpBoxProgSkills.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxProgSkills.Location = new System.Drawing.Point(22, 116);
            this.grpBoxProgSkills.Name = "grpBoxProgSkills";
            this.grpBoxProgSkills.Size = new System.Drawing.Size(289, 51);
            this.grpBoxProgSkills.TabIndex = 18;
            this.grpBoxProgSkills.TabStop = false;
            this.grpBoxProgSkills.Text = "Programming Skills";
            // 
            // chkPHP
            // 
            this.chkPHP.AutoSize = true;
            this.chkPHP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPHP.Location = new System.Drawing.Point(233, 19);
            this.chkPHP.Name = "chkPHP";
            this.chkPHP.Size = new System.Drawing.Size(48, 19);
            this.chkPHP.TabIndex = 9;
            this.chkPHP.Text = "PHP";
            this.chkPHP.UseVisualStyleBackColor = true;
            // 
            // chkLinux
            // 
            this.chkLinux.AutoSize = true;
            this.chkLinux.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLinux.Location = new System.Drawing.Point(172, 19);
            this.chkLinux.Name = "chkLinux";
            this.chkLinux.Size = new System.Drawing.Size(55, 19);
            this.chkLinux.TabIndex = 8;
            this.chkLinux.Text = "Linux";
            this.chkLinux.UseVisualStyleBackColor = true;
            // 
            // chkDelphi
            // 
            this.chkDelphi.AutoSize = true;
            this.chkDelphi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelphi.Location = new System.Drawing.Point(104, 19);
            this.chkDelphi.Name = "chkDelphi";
            this.chkDelphi.Size = new System.Drawing.Size(62, 19);
            this.chkDelphi.TabIndex = 7;
            this.chkDelphi.Text = "Delphi";
            this.chkDelphi.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJava.Location = new System.Drawing.Point(48, 19);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(50, 19);
            this.chkJava.TabIndex = 6;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkC.Location = new System.Drawing.Point(6, 19);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(39, 19);
            this.chkC.TabIndex = 5;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(134, 78);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(48, 19);
            this.lblSalary.TabIndex = 10;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(211, 78);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(123, 26);
            this.txtSalary.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(112, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Candidate";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(211, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 26);
            this.txtID.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(211, 16);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 26);
            this.txtSurname.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(134, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID/Ref";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(134, 15);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 19);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // rdbProgrammer
            // 
            this.rdbProgrammer.AutoSize = true;
            this.rdbProgrammer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProgrammer.Location = new System.Drawing.Point(22, 43);
            this.rdbProgrammer.Name = "rdbProgrammer";
            this.rdbProgrammer.Size = new System.Drawing.Size(106, 23);
            this.rdbProgrammer.TabIndex = 1;
            this.rdbProgrammer.TabStop = true;
            this.rdbProgrammer.Text = "Programmer";
            this.rdbProgrammer.UseVisualStyleBackColor = true;
            this.rdbProgrammer.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAdmin.Location = new System.Drawing.Point(22, 19);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(68, 23);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            this.rdbAdmin.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // CandidateListBox
            // 
            this.CandidateListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CandidateListBox.FormattingEnabled = true;
            this.CandidateListBox.ItemHeight = 18;
            this.CandidateListBox.Location = new System.Drawing.Point(17, 19);
            this.CandidateListBox.Name = "CandidateListBox";
            this.CandidateListBox.Size = new System.Drawing.Size(371, 58);
            this.CandidateListBox.TabIndex = 2;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.Location = new System.Drawing.Point(46, 19);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(123, 26);
            this.txtSearchId.TabIndex = 11;
            // 
            // cmdSearchById
            // 
            this.cmdSearchById.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearchById.Location = new System.Drawing.Point(185, 19);
            this.cmdSearchById.Name = "cmdSearchById";
            this.cmdSearchById.Size = new System.Drawing.Size(122, 33);
            this.cmdSearchById.TabIndex = 12;
            this.cmdSearchById.Text = "Search by ID/Ref";
            this.cmdSearchById.UseVisualStyleBackColor = true;
            this.cmdSearchById.Click += new System.EventHandler(this.cmdSearchById_Click);
            // 
            // cmdListProgrammers
            // 
            this.cmdListProgrammers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListProgrammers.Location = new System.Drawing.Point(46, 70);
            this.cmdListProgrammers.Name = "cmdListProgrammers";
            this.cmdListProgrammers.Size = new System.Drawing.Size(122, 45);
            this.cmdListProgrammers.TabIndex = 13;
            this.cmdListProgrammers.Text = "List Only Programmers";
            this.cmdListProgrammers.UseVisualStyleBackColor = true;
            this.cmdListProgrammers.Click += new System.EventHandler(this.cmdListProgrammers_Click);
            // 
            // QueryListBox
            // 
            this.QueryListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryListBox.FormattingEnabled = true;
            this.QueryListBox.ItemHeight = 18;
            this.QueryListBox.Location = new System.Drawing.Point(15, 15);
            this.QueryListBox.Name = "QueryListBox";
            this.QueryListBox.Size = new System.Drawing.Size(371, 364);
            this.QueryListBox.TabIndex = 10;
            // 
            // grpbShowQuered
            // 
            this.grpbShowQuered.Controls.Add(this.QueryListBox);
            this.grpbShowQuered.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbShowQuered.Location = new System.Drawing.Point(368, 93);
            this.grpbShowQuered.Name = "grpbShowQuered";
            this.grpbShowQuered.Size = new System.Drawing.Size(397, 386);
            this.grpbShowQuered.TabIndex = 11;
            this.grpbShowQuered.TabStop = false;
            this.grpbShowQuered.Text = "Query List";
            // 
            // grpbCndtQuery
            // 
            this.grpbCndtQuery.Controls.Add(this.lblInputID);
            this.grpbCndtQuery.Controls.Add(this.cmdListAllCandidates);
            this.grpbCndtQuery.Controls.Add(this.cmdSearchById);
            this.grpbCndtQuery.Controls.Add(this.txtSearchId);
            this.grpbCndtQuery.Controls.Add(this.cmdListProgrammers);
            this.grpbCndtQuery.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCndtQuery.Location = new System.Drawing.Point(12, 221);
            this.grpbCndtQuery.Name = "grpbCndtQuery";
            this.grpbCndtQuery.Size = new System.Drawing.Size(345, 123);
            this.grpbCndtQuery.TabIndex = 12;
            this.grpbCndtQuery.TabStop = false;
            this.grpbCndtQuery.Text = "Candidate Query";
            // 
            // lblInputID
            // 
            this.lblInputID.AutoSize = true;
            this.lblInputID.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputID.Location = new System.Drawing.Point(67, 48);
            this.lblInputID.Name = "lblInputID";
            this.lblInputID.Size = new System.Drawing.Size(63, 13);
            this.lblInputID.TabIndex = 15;
            this.lblInputID.Text = "Input ID/Ref";
            // 
            // cmdListAllCandidates
            // 
            this.cmdListAllCandidates.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListAllCandidates.Location = new System.Drawing.Point(185, 70);
            this.cmdListAllCandidates.Name = "cmdListAllCandidates";
            this.cmdListAllCandidates.Size = new System.Drawing.Size(123, 45);
            this.cmdListAllCandidates.TabIndex = 14;
            this.cmdListAllCandidates.Text = "List All Candidates";
            this.cmdListAllCandidates.UseVisualStyleBackColor = true;
            this.cmdListAllCandidates.Click += new System.EventHandler(this.cmdListAllCandidates_Click);
            // 
            // grpbProgQuery
            // 
            this.grpbProgQuery.Controls.Add(this.lblSalaryOffer);
            this.grpbProgQuery.Controls.Add(this.lblInputSalary);
            this.grpbProgQuery.Controls.Add(this.grpBoxReqProgSkills);
            this.grpbProgQuery.Controls.Add(this.cmdListSuitableProgrammers);
            this.grpbProgQuery.Controls.Add(this.txtSalaryOffered);
            this.grpbProgQuery.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbProgQuery.Location = new System.Drawing.Point(12, 350);
            this.grpbProgQuery.Name = "grpbProgQuery";
            this.grpbProgQuery.Size = new System.Drawing.Size(345, 171);
            this.grpbProgQuery.TabIndex = 13;
            this.grpbProgQuery.TabStop = false;
            this.grpbProgQuery.Text = "Programmer Query";
            // 
            // lblSalaryOffer
            // 
            this.lblSalaryOffer.AutoSize = true;
            this.lblSalaryOffer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryOffer.Location = new System.Drawing.Point(182, 24);
            this.lblSalaryOffer.Name = "lblSalaryOffer";
            this.lblSalaryOffer.Size = new System.Drawing.Size(154, 15);
            this.lblSalaryOffer.TabIndex = 21;
            this.lblSalaryOffer.Text = "Salary offered by Company";
            // 
            // lblInputSalary
            // 
            this.lblInputSalary.AutoSize = true;
            this.lblInputSalary.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputSalary.Location = new System.Drawing.Point(57, 48);
            this.lblInputSalary.Name = "lblInputSalary";
            this.lblInputSalary.Size = new System.Drawing.Size(100, 13);
            this.lblInputSalary.TabIndex = 20;
            this.lblInputSalary.Text = "Input Salary Offered";
            // 
            // grpBoxReqProgSkills
            // 
            this.grpBoxReqProgSkills.Controls.Add(this.checkPHP);
            this.grpBoxReqProgSkills.Controls.Add(this.checkLinux);
            this.grpBoxReqProgSkills.Controls.Add(this.checkDelphi);
            this.grpBoxReqProgSkills.Controls.Add(this.checkJava);
            this.grpBoxReqProgSkills.Controls.Add(this.checkC);
            this.grpBoxReqProgSkills.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxReqProgSkills.Location = new System.Drawing.Point(22, 66);
            this.grpBoxReqProgSkills.Name = "grpBoxReqProgSkills";
            this.grpBoxReqProgSkills.Size = new System.Drawing.Size(289, 51);
            this.grpBoxReqProgSkills.TabIndex = 19;
            this.grpBoxReqProgSkills.TabStop = false;
            this.grpBoxReqProgSkills.Text = "Required Programming Skills";
            // 
            // checkPHP
            // 
            this.checkPHP.AutoSize = true;
            this.checkPHP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPHP.Location = new System.Drawing.Point(233, 19);
            this.checkPHP.Name = "checkPHP";
            this.checkPHP.Size = new System.Drawing.Size(48, 19);
            this.checkPHP.TabIndex = 9;
            this.checkPHP.Text = "PHP";
            this.checkPHP.UseVisualStyleBackColor = true;
            // 
            // checkLinux
            // 
            this.checkLinux.AutoSize = true;
            this.checkLinux.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLinux.Location = new System.Drawing.Point(172, 19);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(55, 19);
            this.checkLinux.TabIndex = 8;
            this.checkLinux.Text = "Linux";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkDelphi
            // 
            this.checkDelphi.AutoSize = true;
            this.checkDelphi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDelphi.Location = new System.Drawing.Point(104, 19);
            this.checkDelphi.Name = "checkDelphi";
            this.checkDelphi.Size = new System.Drawing.Size(62, 19);
            this.checkDelphi.TabIndex = 7;
            this.checkDelphi.Text = "Delphi";
            this.checkDelphi.UseVisualStyleBackColor = true;
            // 
            // checkJava
            // 
            this.checkJava.AutoSize = true;
            this.checkJava.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkJava.Location = new System.Drawing.Point(48, 19);
            this.checkJava.Name = "checkJava";
            this.checkJava.Size = new System.Drawing.Size(50, 19);
            this.checkJava.TabIndex = 6;
            this.checkJava.Text = "Java";
            this.checkJava.UseVisualStyleBackColor = true;
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkC.Location = new System.Drawing.Point(6, 19);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(39, 19);
            this.checkC.TabIndex = 5;
            this.checkC.Text = "C#";
            this.checkC.UseVisualStyleBackColor = true;
            // 
            // cmdListSuitableProgrammers
            // 
            this.cmdListSuitableProgrammers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListSuitableProgrammers.Location = new System.Drawing.Point(112, 123);
            this.cmdListSuitableProgrammers.Name = "cmdListSuitableProgrammers";
            this.cmdListSuitableProgrammers.Size = new System.Drawing.Size(122, 45);
            this.cmdListSuitableProgrammers.TabIndex = 14;
            this.cmdListSuitableProgrammers.Text = "List Suitable Programmers";
            this.cmdListSuitableProgrammers.UseVisualStyleBackColor = true;
            this.cmdListSuitableProgrammers.Click += new System.EventHandler(this.cmdListSuitableProgrammers_Click);
            // 
            // txtSalaryOffered
            // 
            this.txtSalaryOffered.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryOffered.Location = new System.Drawing.Point(46, 19);
            this.txtSalaryOffered.Name = "txtSalaryOffered";
            this.txtSalaryOffered.Size = new System.Drawing.Size(123, 26);
            this.txtSalaryOffered.TabIndex = 11;
            this.txtSalaryOffered.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CandidateListBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(368, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidate List";
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(383, 485);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(122, 33);
            this.cmdSave.TabIndex = 15;
            this.cmdSave.Text = "Save To File";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClearQueryBox
            // 
            this.cmdClearQueryBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearQueryBox.Location = new System.Drawing.Point(527, 485);
            this.cmdClearQueryBox.Name = "cmdClearQueryBox";
            this.cmdClearQueryBox.Size = new System.Drawing.Size(122, 33);
            this.cmdClearQueryBox.TabIndex = 16;
            this.cmdClearQueryBox.Text = "Clear Query List";
            this.cmdClearQueryBox.UseVisualStyleBackColor = true;
            this.cmdClearQueryBox.Click += new System.EventHandler(this.cmdClearQueryBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 533);
            this.Controls.Add(this.cmdClearQueryBox);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbProgQuery);
            this.Controls.Add(this.grpbCndtQuery);
            this.Controls.Add(this.grpbShowQuered);
            this.Controls.Add(this.grpbCndtEntry);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Candidate System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbCndtEntry.ResumeLayout(false);
            this.grpbCndtEntry.PerformLayout();
            this.grpBoxProgSkills.ResumeLayout(false);
            this.grpBoxProgSkills.PerformLayout();
            this.grpbShowQuered.ResumeLayout(false);
            this.grpbCndtQuery.ResumeLayout(false);
            this.grpbCndtQuery.PerformLayout();
            this.grpbProgQuery.ResumeLayout(false);
            this.grpbProgQuery.PerformLayout();
            this.grpBoxReqProgSkills.ResumeLayout(false);
            this.grpBoxReqProgSkills.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCndtEntry;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.RadioButton rdbProgrammer;
        private System.Windows.Forms.RadioButton rdbAdmin;
        public System.Windows.Forms.ListBox CandidateListBox;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Button cmdSearchById;
        private System.Windows.Forms.GroupBox grpBoxProgSkills;
        public System.Windows.Forms.CheckBox chkPHP;
        public System.Windows.Forms.CheckBox chkLinux;
        public System.Windows.Forms.CheckBox chkDelphi;
        public System.Windows.Forms.CheckBox chkJava;
        public System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.Button cmdListProgrammers;
        public System.Windows.Forms.ListBox QueryListBox;
        private System.Windows.Forms.GroupBox grpbShowQuered;
        private System.Windows.Forms.GroupBox grpbCndtQuery;
        private System.Windows.Forms.Button cmdListAllCandidates;
        private System.Windows.Forms.GroupBox grpbProgQuery;
        private System.Windows.Forms.Button cmdListSuitableProgrammers;
        private System.Windows.Forms.TextBox txtSalaryOffered;
        private System.Windows.Forms.Label lblInputID;
        private System.Windows.Forms.GroupBox grpBoxReqProgSkills;
        public System.Windows.Forms.CheckBox checkPHP;
        public System.Windows.Forms.CheckBox checkLinux;
        public System.Windows.Forms.CheckBox checkDelphi;
        public System.Windows.Forms.CheckBox checkJava;
        public System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.Label lblSalaryOffer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputSalary;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdClearQueryBox;
    }
}



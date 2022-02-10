using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_1_Fully_Functional
{
    public class Student
    {
        public String studentFName { get; set; }
        public String studentLName { get; set; }
        public String studentEmail { get; set; }
        public String studentPhone { get; set; }
        public String studentExpGradYear { get; set; }
        public String studentMajor { get; set; }
        public String studentUniYear { get; set; }
        public String studentInternship { get; set; }
        public String studentEmploymentStatus { get; set; }

        // Constructor
        public Student(String studentFName, String studentLName, String studentEmail, String studentPhone, String studentExpGradYear, String studentMajor, String studentUniYear, String studentInternship, String studentEmploymentStatus)
        {
            this.studentFName = studentFName;
            this.studentLName = studentLName;
            this.studentEmail = studentEmail;
            this.studentPhone = studentPhone;
            this.studentExpGradYear = studentExpGradYear;
            this.studentMajor = studentMajor;
            this.studentUniYear = studentUniYear;
            this.studentInternship = studentInternship;
            this.studentEmploymentStatus = studentEmploymentStatus;
        }
        
    }
}
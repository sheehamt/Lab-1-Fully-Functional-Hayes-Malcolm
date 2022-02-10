using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Lab_1_Fully_Functional
{
    internal class Member
    {
        public String fName { get; set; }
        public String lName { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String gradYear { get; set; }
        public String title { get; set; }

        // Constructor
        public Member(String fName, String lName, String email, String phone, String gradYear, String title)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.phone = phone;
            this.gradYear = gradYear;
            this.title = title;
        }

    }
}
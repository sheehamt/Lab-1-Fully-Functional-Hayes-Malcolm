using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab_1_Fully_Functional
{
    public partial class AddMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // When the page first loads, create an empty array.
                Session["MemberArray"] = new Member[10];
                Session["ArrayKeeper"] = 0;
            }
        }

        protected void btnMemberPopulate_Click(object sender, EventArgs e)
        {
            txtMemberFName.Text = "James";
            txtMemberLName.Text = "Jewett";
            txtMemberEmail.Text = "jewettjw@dukes.jmu.edu";
            txtMemberPhone.Text = "5408889999";
            txtMemberGradYear.Text = "1975";
            txtMemberTitle.Text = "Member";
        }

        protected void btnMemberSave_Click(object sender, EventArgs e)
        {
            String fName = txtMemberFName.Text;
            String lName = txtMemberLName.Text;
            String email = txtMemberEmail.Text;
            String phone = txtMemberPhone.Text;
            String gradYear = txtMemberGradYear.Text;
            String title = txtMemberTitle.Text;

            Member[] sArray = (Member[])Session["MemberArray"];
            int keeper = (int)Session["ArrayKeeper"];

            // Create the student object and store in the array.
            sArray[keeper++] = new Member(fName, lName, email, phone, gradYear, title);
            // Update the keeper value in Session.
            Session["ArrayKeeper"] = keeper;
            // Update the array stored in memory
            Session["MemberArray"] = sArray;

            lstMembers.Items.Clear();

            for (int i = 0; i < keeper; i++)
            {
                lstMembers.Items.Add(sArray[i].fName + " " + sArray[i].lName);
            }

            // Clear out the Textboxes to prepare for the
            // next input.
            txtMemberFName.Text = " ";
            txtMemberLName.Text = " ";
            txtMemberEmail.Text = " ";
            txtMemberPhone.Text = " ";
            txtMemberGradYear.Text = " ";
            txtMemberTitle.Text = " ";
        }

        protected void btnMemberClear_Click(object sender, EventArgs e)
        {
            txtMemberFName.Text = " ";
            txtMemberLName.Text = " ";
            txtMemberEmail.Text = " ";
            txtMemberPhone.Text = " ";
            txtMemberGradYear.Text = " ";
            txtMemberTitle.Text = " ";
        }

        protected void btnMemberCommit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Server=Localhost;Database=Lab1DB;Trusted_Connection=Yes;");

            sqlConnect.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Members(FirstName, LastName, EmailAddress, PhoneNumber, GraduationYear, Title)values('" + txtMemberFName.Text + "','" + txtMemberLName.Text + "','" + txtMemberEmail.Text + "','" + txtMemberPhone.Text + "','" + txtMemberGradYear.Text + "','" + txtMemberTitle.Text + "')", sqlConnect);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            lblValidation.Text = "Data has been submitted";
        }
    }
}
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // When the page first loads, create an empty array.
                Session["StudentArray"] = new Student[10];
                Session["ArrayKeeper"] = 0;
            }

        }

        protected void btnAddStudentPopulate_Click(object sender, EventArgs e)
        {
            txtAddStudentfirstName.Text = "Jeremy";
            txtAddStudentLastName.Text = "Ezell";
            txtAddStudentEmail.Text = "ezelljd@jmu.edu";
            txtAddStudentPhone.Text = "5407035403";
            txtAddStudentExpectedGY.Text = "2022";
            txtAddStudentMajor.Text = "CIS";
            txtAddStudentUniYear.Text = "Senior";
            txtAddStudentInternship.Text = "N/A";
            txtAddStudentEmployStat.Text = "Employed";
        }
        protected void btnCommit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Server=Localhost;Database=Lab1DB;Trusted_Connection=Yes;");

            sqlConnect.Open();

            SqlCommand cmd = new SqlCommand("Insert into Students(FirstName, LastName, EmailAddress, PhoneNumber, ExpectedGradYear, Major, UniversityYear, InternshipStatus, EmploymentStatus)values('" + txtAddStudentfirstName.Text + "','" + txtAddStudentLastName.Text + "','" + txtAddStudentEmail.Text + "','" + txtAddStudentPhone.Text + "','" + txtAddStudentMajor.Text + "','" + txtAddStudentExpectedGY.Text + "','" + txtAddStudentUniYear.Text + "','" + txtAddStudentInternship.Text + "','" + txtAddStudentEmployStat.Text + "')", sqlConnect);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            lblValidation.Text = "Data has been submitted";
        }


        protected void btnAddStudentSave_Click(object sender, EventArgs e)
        {
            String addSFName = txtAddStudentfirstName.Text;
            String addSLName = txtAddStudentLastName.Text;
            String addSEmail = txtAddStudentEmail.Text;
            String addSPhone = txtAddStudentPhone.Text;
            String addSEGY = txtAddStudentExpectedGY.Text;
            String addSMajor = txtAddStudentMajor.Text;
            String addSUniversityYear = txtAddStudentUniYear.Text;
            String addSInternship = txtAddStudentInternship.Text;
            String addSEmployment = txtAddStudentEmployStat.Text;

            Student[] sArray = (Student[])Session["StudentArray"];
            int keeper = (int)Session["ArrayKeeper"];

            // Create the student object and store in the array.
            sArray[keeper++] = new Student(addSFName, addSLName, addSEmail, addSPhone, addSEGY, addSMajor, addSUniversityYear, addSInternship, addSEmployment);
            // Update the keeper value in Session.
            Session["ArrayKeeper"] = keeper;
            // Update the array stored in memory
            Session["StudentArray"] = sArray;

            lstStudentList.Items.Clear();

            for (int i = 0; i < keeper; i++)
            {
                lstStudentList.Items.Add(sArray[i].studentFName.ToString() + " " + sArray[i].studentLName.ToString());
            }

            // Clear out the Textboxes to prepare for the
            // next input.
            txtAddStudentfirstName.Text = "";
            txtAddStudentLastName.Text = "";
            txtAddStudentEmail.Text = "";
            txtAddStudentPhone.Text = "";
            txtAddStudentExpectedGY.Text = "";
            txtAddStudentMajor.Text = "";
            txtAddStudentUniYear.Text = "";
            txtAddStudentInternship.Text = "";
            txtAddStudentEmployStat.Text = "";
        }

        protected void btnAddStudentClear_Click(object sender, EventArgs e)
        {
            txtAddStudentfirstName.Text = "";
            txtAddStudentLastName.Text = "";
            txtAddStudentEmail.Text = "";
            txtAddStudentPhone.Text = "";
            txtAddStudentExpectedGY.Text = "";
            txtAddStudentMajor.Text = "";
            txtAddStudentUniYear.Text = "";
            txtAddStudentInternship.Text = "";
            txtAddStudentEmployStat.Text = "";
        }
    }
}
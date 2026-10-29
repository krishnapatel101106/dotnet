using System;

namespace WebFormsDemo
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "Not selected";
            string dob = calDOB.SelectedDate == DateTime.MinValue ? "Not selected" : calDOB.SelectedDate.ToShortDateString();
            lblOutput.Text = $"Name: {Server.HtmlEncode(txtName.Text)}<br/>" +
                $"Roll No: {Server.HtmlEncode(txtRoll.Text)}<br/>Gender: {gender}<br/>" +
                $"Course: {Server.HtmlEncode(ddlCourse.SelectedValue)}<br/>DOB: {dob}<br/>" +
                $"Confirmed: {chkAgree.Checked}";
        }
    }
}

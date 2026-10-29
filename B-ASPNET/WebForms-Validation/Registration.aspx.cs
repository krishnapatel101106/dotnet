using System;

namespace WebFormsDemo
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
                lblOutput.Text = "Registration details validated successfully for " + Server.HtmlEncode(txtName.Text) + ".";
        }
    }
}

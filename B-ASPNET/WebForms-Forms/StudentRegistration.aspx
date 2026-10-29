<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="WebFormsDemo.StudentRegistration" %>
<!DOCTYPE html>
<html><head runat="server"><title>Student Registration</title></head>
<body>
<form id="form1" runat="server">
    <h2>Student Registration Form</h2>
    <asp:Label runat="server" Text="Name:" /><asp:TextBox ID="txtName" runat="server" /><br />
    <asp:Label runat="server" Text="Roll No:" /><asp:TextBox ID="txtRoll" runat="server" /><br />
    Gender: <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />
    <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" /><br />
    Course: <asp:DropDownList ID="ddlCourse" runat="server">
        <asp:ListItem>BSc IT</asp:ListItem><asp:ListItem>BSc CS</asp:ListItem><asp:ListItem>BCom</asp:ListItem>
    </asp:DropDownList><br />
    <asp:CheckBox ID="chkAgree" runat="server" Text="I confirm these details are correct" /><br />
    Date of birth: <asp:Calendar ID="calDOB" runat="server" /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
    <asp:Label ID="lblOutput" runat="server" />
</form>
</body></html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebFormsDemo.Registration" %>
<!DOCTYPE html>
<html><head runat="server"><title>Validated Registration</title></head><body>
<form id="form1" runat="server">
    Name: <asp:TextBox ID="txtName" runat="server" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Name is required." ForeColor="Red" /><br />
    Age: <asp:TextBox ID="txtAge" runat="server" />
    <asp:RangeValidator runat="server" ControlToValidate="txtAge" Type="Integer" MinimumValue="16" MaximumValue="60" ErrorMessage="Age must be 16–60." ForeColor="Red" /><br />
    Email: <asp:TextBox ID="txtEmail" runat="server" />
    <asp:RegularExpressionValidator runat="server" ControlToValidate="txtEmail" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" ErrorMessage="Enter a valid email." ForeColor="Red" /><br />
    Password: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br />
    Confirm password: <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password" />
    <asp:CompareValidator runat="server" ControlToValidate="txtConfirm" ControlToCompare="txtPassword" ErrorMessage="Passwords do not match." ForeColor="Red" /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSubmit_Click" />
    <asp:Label ID="lblOutput" runat="server" />
</form></body></html>

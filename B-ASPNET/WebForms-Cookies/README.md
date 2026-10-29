# Session and persistent cookies (Web Forms)

Create a Web Forms project and add a button plus labels to a `.aspx` page:

```aspx
<asp:TextBox ID="txtName" runat="server" />
<asp:Button ID="btnSaveSession" runat="server" Text="Save session cookie" OnClick="btnSaveSession_Click" />
<asp:Button ID="btnSavePersistent" runat="server" Text="Save persistent cookie" OnClick="btnSavePersistent_Click" />
<asp:Button ID="btnRead" runat="server" Text="Read cookies" OnClick="btnRead_Click" />
<asp:Label ID="lblOutput" runat="server" />
```

In the code-behind:
```csharp
protected void btnSaveSession_Click(object sender, EventArgs e)
{
    var cookie = new System.Web.HttpCookie("UserName", txtName.Text);
    // No Expires property: session cookie.
    Response.Cookies.Add(cookie);
    lblOutput.Text = "Session cookie saved.";
}

protected void btnSavePersistent_Click(object sender, EventArgs e)
{
    var cookie = new System.Web.HttpCookie("SavedUserName", txtName.Text);
    cookie.Expires = DateTime.Now.AddDays(7);
    cookie.HttpOnly = true;
    cookie.Secure = Request.IsSecureConnection;
    Response.Cookies.Add(cookie);
    lblOutput.Text = "Persistent cookie saved for 7 days.";
}

protected void btnRead_Click(object sender, EventArgs e)
{
    string sessionName = Request.Cookies["UserName"]?.Value ?? "Not found";
    string savedName = Request.Cookies["SavedUserName"]?.Value ?? "Not found";
    lblOutput.Text = "Session: " + Server.HtmlEncode(sessionName) +
                     "<br/>Persistent: " + Server.HtmlEncode(savedName);
}
```

For a production site, use HTTPS and never store passwords or sensitive information in plain-text cookies.

# ASP.NET Core authentication and role-based authorization

This practical is larger than a single controller because real authentication needs a user store and secure password handling. For a college demo, the simplest supported path is to create an ASP.NET Core Web App (Model-View-Controller) and select **Individual Accounts** if that option is offered. This adds ASP.NET Core Identity.

## Steps
1. Create **ASP.NET Core Web App (Model-View-Controller)** named `RoleDemo`.
2. In Authentication type, select **Individual Accounts** (if available).
3. Ensure Identity pages/database are configured, then run migrations as required by the template.
4. Create roles `Admin` and `User` and assign them to test accounts. Do not hard-code real passwords.
5. Protect a controller/action using `[Authorize(Roles = "Admin")]` or `[Authorize(Roles = "User")]`.

Example controller:
```csharp
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoleDemo.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index() => Content("Any signed-in user can see this page.");

        [Authorize(Roles = "Admin")]
        public IActionResult Admin() => Content("Only Admin users can see this page.");

        [Authorize(Roles = "User")]
        public IActionResult UserPage() => Content("Only User-role users can see this page.");
    }
}
```

In `Program.cs`, ensure authentication and authorization middleware are enabled before route mapping:
```csharp
app.UseAuthentication();
app.UseAuthorization();
```

The Identity template normally configures these. Role creation/assignment must be done through Identity's `RoleManager` and `UserManager` or a properly secured seed routine. An `[Authorize]` attribute alone does not create accounts or roles.

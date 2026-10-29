# MVC Practical: Basic arithmetic operations

## Create project
1. Visual Studio → Create a new project.
2. Select **ASP.NET Core Web App (Model-View-Controller)**.
3. Name it `MvcArithmetic`.
4. Select an installed .NET version and create.

## Add controller
Create `Controllers/CalculatorController.cs`:

```csharp
using Microsoft.AspNetCore.Mvc;

namespace MvcArithmetic.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(double a, double b)
        {
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Sum = a + b;
            ViewBag.Difference = a - b;
            ViewBag.Product = a * b;
            ViewBag.Quotient = b == 0 ? "Cannot divide by zero" : (a / b).ToString();
            return View();
        }
    }
}
```

## Add view
Create `Views/Calculator/Index.cshtml`:

```html
@{
    ViewData["Title"] = "Arithmetic Calculator";
}
<h1>Arithmetic Calculator</h1>
<form method="post">
    <label>First number: <input type="number" step="any" name="a" required /></label><br />
    <label>Second number: <input type="number" step="any" name="b" required /></label><br />
    <button type="submit">Calculate</button>
</form>
@if (ViewBag.Sum != null)
{
    <h2>Results</h2>
    <p>Addition: @ViewBag.Sum</p>
    <p>Subtraction: @ViewBag.Difference</p>
    <p>Multiplication: @ViewBag.Product</p>
    <p>Division: @ViewBag.Quotient</p>
}
```

Run with Ctrl+F5 and open `/Calculator`.

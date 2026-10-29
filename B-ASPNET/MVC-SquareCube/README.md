# MVC Practical: Square and cube

Create an ASP.NET Core Web App (Model-View-Controller) named `MvcSquareCube`.

`Controllers/NumberController.cs`:
```csharp
using Microsoft.AspNetCore.Mvc;

namespace MvcSquareCube.Controllers
{
    public class NumberController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(double number)
        {
            ViewBag.Number = number;
            ViewBag.Square = number * number;
            ViewBag.Cube = number * number * number;
            return View();
        }
    }
}
```

`Views/Number/Index.cshtml`:
```html
<h1>Find Square and Cube</h1>
<form method="post">
    <label>Enter a number: <input type="number" step="any" name="number" required /></label>
    <button type="submit">Calculate</button>
</form>
@if (ViewBag.Square != null)
{
    <p>Number: @ViewBag.Number</p>
    <p>Square: @ViewBag.Square</p>
    <p>Cube: @ViewBag.Cube</p>
}
```

Run and open `/Number`.

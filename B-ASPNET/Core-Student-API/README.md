# ASP.NET Core Student JSON API

## Create project
Create **ASP.NET Core Web API** named `StudentApi`. Choose a supported .NET version. You can keep the default sample or remove it.

Add `Controllers/StudentsController.cs`:

```csharp
using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = new[]
            {
                new { RollNumber = 1, Name = "Asha", Course = "BSc IT", Marks = 85 },
                new { RollNumber = 2, Name = "Ravi", Course = "BSc IT", Marks = 91 }
            };
            return Ok(students);
        }

        [HttpGet("{rollNumber:int}")]
        public IActionResult GetStudent(int rollNumber)
        {
            var student = new[]
            {
                new { RollNumber = 1, Name = "Asha", Course = "BSc IT", Marks = 85 },
                new { RollNumber = 2, Name = "Ravi", Course = "BSc IT", Marks = 91 }
            }.FirstOrDefault(s => s.RollNumber == rollNumber);

            return student == null ? NotFound() : Ok(student);
        }
    }
}
```

Add `using System.Linq;` if the project does not include it implicitly.

Run the project and browse to `/api/students`. Test `/api/students/1` in a browser or Postman. The response is JSON.

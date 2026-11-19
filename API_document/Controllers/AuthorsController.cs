using API_document.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_document.Controllers;

[ApiController]
[Route("api/authors")]
public class AuthorsController : ControllerBase
{
    private static readonly List<Author> Authors =
    [
        new Author { Id = 1, FirstName = "Karel", LastName = "Čapek", BirthYear = 1890 },
        new Author { Id = 2, FirstName = "Božena", LastName = "Němcová", BirthYear = 1820 },
        new Author { Id = 3, FirstName = "Jaroslav", LastName = "Hašek", BirthYear = 1883 }
    ];

    [HttpGet]
    public ActionResult<List<Author>> GetAll()
    {
        return Ok(Authors);
    }
}
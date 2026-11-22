using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SectionA_AuthorBooksAPI.Service.Interfaces;

namespace SectionA_AuthorBooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;
        public AuthorsController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _authorsService.GetAllAuthorsAsync();
            return Ok(authors);
        }

    }
}

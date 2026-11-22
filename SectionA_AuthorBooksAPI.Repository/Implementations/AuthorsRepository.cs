using SectionA_AuthorBooksAPI.Domain.Entities;
using SectionA_AuthorBooksAPI.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SectionA_AuthorBooksAPI.Repository.Implementations
{
    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly ApplicationDbContext _context;
        //constructor injection of the ApplicationDbContext
        public AuthorsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        {
            return await _context.Authors.ToListAsync();
        }
    }
}

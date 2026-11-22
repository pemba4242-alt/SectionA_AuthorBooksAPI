using SectionA_AuthorBooksAPI.Repository.Interfaces;
using SectionA_AuthorBooksAPI.Service.DTO;
using SectionA_AuthorBooksAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA_AuthorBooksAPI.Service.Implementations
{
    public class AuthorsService : IAuthorsService
    {
        private readonly IAuthorsRepository _authorsRepository;
        public AuthorsService(IAuthorsRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        public async Task<List<AuthorDto>> GetAllAuthorsAsync()
        {
            var authors = await _authorsRepository.GetAllAuthorsAsync();
            return authors.Select(a => new AuthorDto
            {
                AuthorId = a.AuthorId,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Address = a.Address,
                CreatedDate = a.CreatedDate,
                UpdatedDate = a.UpdatedDate,
                DeletedDate = a.DeletedDate
            }).ToList();
        }
    }
}

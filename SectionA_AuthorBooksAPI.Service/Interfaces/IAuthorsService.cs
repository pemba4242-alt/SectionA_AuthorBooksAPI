using SectionA_AuthorBooksAPI.Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA_AuthorBooksAPI.Service.Interfaces
{
    public interface IAuthorsService
    {
        Task<List<AuthorDto>> GetAllAuthorsAsync();
    }
}

using SectionA_AuthorBooksAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA_AuthorBooksAPI.Repository.Interfaces
{
    public interface IAuthorsRepository
    {
        Task<List<Author>> GetAllAuthorsAsync();
    }
}

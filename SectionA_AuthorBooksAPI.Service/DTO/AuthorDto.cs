using SectionA_AuthorBooksAPI.Service.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA_AuthorBooksAPI.Service.DTO
{
    public class AuthorDto : BaseDto
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
}

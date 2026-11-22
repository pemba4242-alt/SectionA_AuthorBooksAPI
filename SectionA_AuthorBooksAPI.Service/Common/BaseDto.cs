using System;
using System.Collections.Generic;
using System.Text;

namespace SectionA_AuthorBooksAPI.Service.Common
{
    public class BaseDto
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}

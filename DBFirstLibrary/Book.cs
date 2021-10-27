using System;
using System.Collections.Generic;

#nullable disable

namespace DBFirstLibrary
{
    public partial class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long PublicationYear { get; set; }
        public long? AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}

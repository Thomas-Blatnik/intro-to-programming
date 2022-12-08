using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    public class ClassMembers
    {
        [Fact]
        public void CreatingStuff()
        {
            var book = new LibraryBook();

            //var bigTitle = book._author?.ToUpper();

            //Assert.Null(book._isbn);
            //Assert.Equal(0, book._numberOfPages);

            book.Author = "Sue";

            Assert.Equal("Sue", book.Author);
            
        }

        [Fact]
        public void NullableValueTypes()
        {
            DateTime? birthday = null;

            if (birthday.HasValue)
            {
                birthday.Value.AddDays(3);
            }
        }
    }

    public class LibraryBook
    {
        // "State"
        // - fields (class-level variables)
        private string _isbn = string.Empty;
        private string? _author;  // ? means can be null (sus)
        private int _numberOfPages;
        private DateTime _published;
        // "Behavior"
        public string? Author
        {
            get { return _author; }
            set { _author = value; }
        }
        // - Methods
        // - Constructors
        // - Properties
        // - *Destructors
    }
}

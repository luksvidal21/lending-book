using lending_book.Api.Interfaces;
using lending_book.Api.Interfaces.Repositories;
using lending_book.Api.Interfaces.Services;
using lending_book.Api.Model;

namespace lending_book.Api.Service
{
    public class BookService(IBookRepository repository) : ServiceBase<Book>(repository), IBookService
    {
        public Book SearchByISBN(string Isbn)
        {
            var book = repository.SearchByISBN(Isbn);

            if (book is null)
            {
                throw new KeyNotFoundException($"Book with ISBN {Isbn} not found.");
            }

            return book;
        }
    }
}
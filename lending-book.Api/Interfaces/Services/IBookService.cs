using lending_book.Api.Interfaces.Services;
using lending_book.Api.Model;

namespace lending_book.Api.Interfaces;

public interface IBookService : IServiceBase<Book>
{
    Book? SearchByISBN(string Isbn);

}
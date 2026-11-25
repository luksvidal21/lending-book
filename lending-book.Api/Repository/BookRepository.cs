using Dapper;
using lending_book.Api.Interfaces.Repositories;
using lending_book.Api.Model;

namespace lending_book.Api.Repository
{
    public class BookRepository(IConfiguration configuration) : RepositoryBase<Book>(configuration), IBookRepository
    {

        public Book SearchByISBN(string Isbn)
        {
            const string sql = """
                SELECT *
                FROM Books
                WHERE Isbn = @Isbn
            """;
            using var connection = Connection;
            var result = connection.QueryFirstOrDefault<Book>(sql, new { Isbn }) ?? throw new KeyNotFoundException($"Book with ISBN {Isbn} not found.");
            return result;
        }
    }
}
using Dapper.Contrib.Extensions;
namespace lending_book.Api.Model;

[Table("[Loan]")]
public class Loan
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}
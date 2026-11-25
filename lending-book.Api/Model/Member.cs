using Dapper.Contrib.Extensions;
namespace lending_book.Api.Model;

[Table("[Member]")]
public class Member
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateTime CreatedAt { get; set; }
}
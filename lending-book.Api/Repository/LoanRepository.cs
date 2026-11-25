using lending_book.Api.Interfaces.Repositories;
using lending_book.Api.Model;
namespace lending_book.Api.Repository;

public class LoanRepository(IConfiguration configuration) : RepositoryBase<Loan>(configuration), ILoanRepository {}
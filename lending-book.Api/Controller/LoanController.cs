using lending_book.Api.Interfaces.Services;
using lending_book.Api.Model;
using Microsoft.AspNetCore.Mvc;
namespace lending_book.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class LoanController(ILoanService service) : CrudControllerBase<Loan>(service){}
    
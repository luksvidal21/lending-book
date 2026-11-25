using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lending_book.Api.Interfaces.Repositories;
using lending_book.Api.Interfaces.Services;
using lending_book.Api.Model;

namespace lending_book.Api.Service
{
    public class LoanService(ILoanRepository repository) : ServiceBase<Loan>(repository), ILoanService
    {
        
    }
}
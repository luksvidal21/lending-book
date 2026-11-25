using lending_book.Api.Interfaces.Repositories;
using lending_book.Api.Interfaces.Services;
using lending_book.Api.Model;

namespace lending_book.Api.Service;

public class MemberService(IMemberRepository repository) : ServiceBase<Member>(repository), IMemberService
{
    
}
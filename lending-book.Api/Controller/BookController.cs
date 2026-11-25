using lending_book.Api.Interfaces;
using lending_book.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace lending_book.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class BookController(IBookService bookService) : CrudControllerBase<Book>(bookService){}
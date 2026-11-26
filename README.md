# lending-book.Api

## O que é (What it is)

Um serviço web de gerenciamento de empréstimos de livros — uma API **ASP.NET Core** construída em **.NET 10**. (An ASP.NET Core web service for managing book lending — an API built on .NET 10.)

Este README está em dois idiomas: primeiro em português, depois em inglês.

---

## O que o código faz (What the code does)

### Em português

A API gerencia três entidades de um sistema de empréstimo de livros:

1. **Book** (`Model/Book.cs`) — `Id`, `Title`, `Author`, `Isbn`, `TotalCopies` e `AvailableCopies`.
2. **Member** (`Model/Member.cs`) — `Id`, `Name`, `Email` e `CreatedAt`.
3. **Loan** (`Model/Loan.cs`) — `Id`, `BookId`, `MemberId`, `LoanDate`, `DueDate` e `ReturnDate` (opcional).

**Endpoints** (baseados em `Controller/*.cs`):

- `GET /api/books`, `GET /api/books/{id}`, `POST /api/books`, `PUT /api/books/{id}`, `DELETE /api/books/{id}`
- `GET /api/members`, `GET /api/members/{id}`, `POST /api/members`, `PUT /api/members/{id}`, `DELETE /api/members/{id}`
- `GET /api/loans`, `GET /api/loans/{id}`, `POST /api/loans`, `PUT /api/loans/{id}`, `DELETE /api/loans/{id}`

Esses endpoints são gerados por `CrudControllerBase<T>` (CRUD genérico: listar todos, ler um por ID, criar, atualizar e deletar).

**Busca extra:** `BookService`/`IBookService` traz `SearchByISBN(string)`, que consulta um book pelo ISBN via `BookRepository.SearchByISBN` (SQL `SELECT * FROM Books WHERE Isbn = @Isbn`).

**Dados:** persistidos em um banco SQL Server; as conexões vêm da connection string `DBConnection` em `appsettings.json` (usada por `RepositoryBase`).

**Arquitetura em camadas (DDD-lite):** Controllers → Services (`IServiceBase`) → Repositories (`IRepositoryBase`), todas registradas por DI no `Program.cs`.

Em ambiente de desenvolvimento, o `Program.cs` expõe a documentação OpenAPI 3.0 e o Scalar API Reference (`app.MapOpenApi()`, `app.MapScalarApiReference()`).

### In English

The API manages three entities of a book lending system:

1. **Book** (`Model/Book.cs`) — `Id`, `Title`, `Author`, `Isbn`, `TotalCopies`, `AvailableCopies`.
2. **Member** (`Model/Member.cs`) — `Id`, `Name`, `Email`, `CreatedAt`.
3. **Loan** (`Model/Loan.cs`) — `Id`, `BookId`, `MemberId`, `LoanDate`, `DueDate` and nullable `ReturnDate`.

**Endpoints** (based on `Controller/*.cs`):

- `GET /api/books`, `GET /api/books/{id}`, `POST /api/books`, `PUT /api/books/{id}`, `DELETE /api/books/{id}`
- `GET /api/members`, `GET /api/members/{id}`, `POST /api/members`, `PUT /api/members/{id}`, `DELETE /api/members/{id}`
- `GET /api/loans`, `GET /api/loans/{id}`, `POST /api/loans`, `PUT /api/loans/{id}`, `DELETE /api/loans/{id}`

These endpoints come from `CrudControllerBase<T>` (generic CRUD: list all, read by id, create, update, delete).

**Extra lookup:** `BookService`/`IBookService` provides `SearchByISBN(string)`, implemented in `BookRepository` with an SQL query on `Books` WHERE `Isbn = @Isbn`.

**Data:** persisted in a SQL Server database; connections come from the `DBConnection` connection string in `appsettings.json` (used by `RepositoryBase`).

**Layered architecture (DDD-lite):** Controllers → Services (`IServiceBase`) → Repositories (`IRepositoryBase`), all wired up via DI in `Program.cs`.

In development, `Program.cs` exposes OpenAPI 3.0 docs and the Scalar API Reference (`app.MapOpenApi()`, `app.MapScalarApiReference()`).

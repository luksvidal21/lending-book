using Dapper.Contrib.Extensions;
using lending_book.Api.Interfaces;
using Microsoft.Data.SqlClient;

namespace lending_book.Api.Repository;

public class RepositoryBase<T>(IConfiguration configuration) : IRepositoryBase<T> where T : class
{
    private readonly string connectionString = new(configuration.GetConnectionString("DBConnection") ??
        throw new InvalidOperationException("Connection string 'DBConnection' não encontrada."));

    protected SqlConnection Connection => new(connectionString);

    public void Create(T model) => Connection.Insert(model);

    public IEnumerable<T> ReadAll() => Connection.GetAll<T>();

    public T Read(Guid id) => Connection.Get<T>(id);

    public void Update(T model) => Connection.Update(model);

    public void Delete(T model) => Connection.Delete(model);

}
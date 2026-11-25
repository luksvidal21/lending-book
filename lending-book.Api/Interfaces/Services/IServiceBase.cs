namespace lending_book.Api.Interfaces.Services;

public interface IServiceBase<T> where T : class
{
    T Read(Guid id);
    IEnumerable<T> ReadAll();
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
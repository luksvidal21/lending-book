namespace lending_book.Api.Interfaces.Services;

public class ServiceBase<T>(IRepositoryBase<T> repository) : IServiceBase<T> where T : class
{
    public void Create(T entity) => repository.Create(entity);
    public void Delete(T entity) => repository.Delete(entity);
    public T Read(Guid id) => repository.Read(id);
    public IEnumerable<T> ReadAll() => repository.ReadAll();
    public void Update(T entity) => repository.Update(entity);
    
}
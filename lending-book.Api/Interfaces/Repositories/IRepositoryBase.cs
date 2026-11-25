using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lending_book.Api.Interfaces;

public interface IRepositoryBase<T> where T : class
{
    T Read(Guid id);
    IEnumerable<T> ReadAll();
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
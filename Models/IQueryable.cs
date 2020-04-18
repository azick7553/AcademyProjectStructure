using System.Collections.Generic;

namespace lesson3.Models
{
    public interface IQueryable<T>
    {
        List<T> SelectAll();
        T SelectById(int id);
        int InsertOne(T model);
    }
}
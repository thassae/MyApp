using MongoDB.Bson;
using System.Collections.Generic;

namespace DataInterface.Base
{
    public interface BaseDataInterface<T>
    {
        List<T> GetAll();
        T Get(ObjectId id);
        ObjectId Insert(T obj);
        void Update(T obj);
        void Delete(ObjectId id);
    }
}

using Domain.Objects.Base;
using MongoDB.Driver;
using System.Configuration;

namespace DataRepository.Base
{
    public class BaseRepository<T> where T : BaseObject, new()
    {
        private T baseObject = new T();

        private string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["connectionString"];
            }
        }

        private MongoClient Client
        {
            get
            {
                return new MongoClient(this.ConnectionString);
            }
        }

        private IMongoDatabase Repository
        {
            get
            {
                return Client.GetDatabase(ConfigurationManager.AppSettings["baseRepository"]);
            }
        }

        public IMongoCollection<T> Collection
        {
            get
            {
                return Repository.GetCollection<T>(baseObject.GetObjectCollectionName());
            }
        }
    }
}
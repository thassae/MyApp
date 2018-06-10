using DataInterface;
using DataRepository.Base;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace DataRepository
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileDataInterface
    {

        public void Delete(ObjectId id)
        {
            Collection.DeleteOne(profile => profile.Id.Equals(id));
        }

        public Profile Get(ObjectId id)
        {
            return Collection.Find(profile => profile.Id.Equals(id)).FirstOrDefault();
        }

        public List<Profile> GetAll()
        {
            return Collection.Find(profile => true).ToList();
        }

        public ObjectId Insert(Profile obj)
        {
            Collection.InsertOne(obj);
            return obj.Id;
        }

        public void Update(Profile obj)
        {
            Collection.ReplaceOne(profile => profile.Id.Equals(obj.Id), obj);
        }
    }
}

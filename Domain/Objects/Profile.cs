using Domain.Objects.Base;
using MongoDB.Bson;

namespace Domain
{
    public class Profile : BaseObject
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string About { get; set; }

        public BsonDateTime DateOfBirth { get; set; }

        public override string GetObjectCollectionName()
        {
            return "Profiles";
        }
     
    }
}

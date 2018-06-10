using Business;
using Domain;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{
    public class ProfileController : ApiController
    {
        public ProfileBusiness profileBusiness = new ProfileBusiness();

        [Route("api/Profile/GetAll"), HttpGet]
        public List<Profile> GetAll()
        {
            return profileBusiness.GetAll();
        }

        [Route("api/Profile/Insert"), HttpPost]
        public ObjectId InsertProfile(Profile profile)
        {
           return profileBusiness.Insert(profile);
        } 
    }
}

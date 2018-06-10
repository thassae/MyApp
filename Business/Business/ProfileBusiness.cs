using Business.Business.Base;
using DataInterface;
using Domain;
using MongoDB.Bson;
using System;
using System.Collections.Generic;


namespace Business
{
    public class ProfileBusiness : BaseBusiness<IProfileDataInterface>
    {
        
        public void Delete(ObjectId id)
        {
            try
            {
                this.Repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Profile Get(ObjectId id)
        {
            try
            {
                return this.Repository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Profile> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ObjectId Insert(Profile obj)
        {
            try
            {
                return this.Repository.Insert(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Profile obj)
        {
            try
            {
                this.Repository.Update(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

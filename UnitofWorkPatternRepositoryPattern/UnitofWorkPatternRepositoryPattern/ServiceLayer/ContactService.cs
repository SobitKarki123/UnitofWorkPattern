
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using UnitofWorkPatternRepositoryPattern.Models;
using UnitofWorkPatternRepositoryPattern.Repository;
using UnitofWorkPatternRepositoryPattern.Repository.Contacts;


namespace UnitofWorkPatternRepositoryPattern.ServiceLayer
{
    public class ContactService : IContactService
    {
        
      private readonly IRepository<Contact> _contactRepo;


        public ContactService()
        {
           
            _contactRepo = new GenericUnitOfWork().Repository<Contact>();
        }
       
        public IEnumerable<Contact> GetAll()
         {
             return _contactRepo.GetAll().ToList();
         }
        
      
        public void Post(Contact value)
        {
            _contactRepo.Add(value);
        }

   
          public void Delete(Contact contact)
        {
            _contactRepo.Delete(contact);
        }

        public Contact Get(Func<Contact, bool> predicate)
        {
            return _contactRepo.Get(predicate);
        }
        public void Attach(Contact entity)
        {
            _contactRepo.Attach(entity);
        }
    }
}


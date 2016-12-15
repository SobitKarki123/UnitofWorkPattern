using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitofWorkPatternRepositoryPattern.Models;

namespace UnitofWorkPatternRepositoryPattern.ServiceLayer
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAll();
        void Post(Contact value);
        void Delete(Contact contact);
        Contact Get(Func<Contact, bool> predicate);
        void Attach(Contact entity);


    }
}
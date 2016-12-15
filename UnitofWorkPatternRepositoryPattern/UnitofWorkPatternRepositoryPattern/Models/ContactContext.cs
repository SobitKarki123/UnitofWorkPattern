using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UnitofWorkPatternRepositoryPattern.Models
{
    public class ContactContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }









    }
}
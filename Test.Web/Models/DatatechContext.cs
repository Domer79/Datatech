using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test.Web.Models
{
    public class DatatechContext : DbContext
    {
        public DatatechContext() 
            : base("DatatechContext")
        {
        }

        public DbSet<AddressBook> AddressBook { get; set; }
    }
}
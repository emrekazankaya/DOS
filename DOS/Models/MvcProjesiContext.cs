using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DOS.Models
{
    public class MvcProjesiContext : DbContext
    {
        public MvcProjesiContext() : base("MvcProjesiContext")
        {

        }
        public DbSet<Rehber> RehberListesi { get; set; }
    }
}
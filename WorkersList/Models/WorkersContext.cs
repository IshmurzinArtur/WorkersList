using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WorkersList.Models
{
    public class WorkersContext: DbContext
    {
        public WorkersContext():base("WorkersDB")
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DispatchLogger.Models.DAL
{
    public class LoginDBContext : DbContext
    {
        public DbSet<Login> CallLog { get; set; }
    }
}
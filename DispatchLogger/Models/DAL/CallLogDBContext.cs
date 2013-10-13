using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DispatchLogger.Models.DAL
{

    public class CallLogDBContext : DbContext
    {
        public DbSet<CallLog> CallLog { get; set; }
    }
}
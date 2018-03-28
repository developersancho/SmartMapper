using Microsoft.EntityFrameworkCore;
using SmartMapperData.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMapperData.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Transport> Transport { get; set; }
    }
}

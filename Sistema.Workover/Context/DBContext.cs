using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Sistema.Workover.Models;

namespace Sistema.Workover.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Produto>Produto { get; set; }

    }
}
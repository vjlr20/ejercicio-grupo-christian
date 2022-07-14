﻿

using Microsoft.EntityFrameworkCore;
using swagger_jwt.Models;

namespace swagger_jwt.Data
{
    public class DataDbContext :DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }


        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Producto> producto { get; set; }
    }
}

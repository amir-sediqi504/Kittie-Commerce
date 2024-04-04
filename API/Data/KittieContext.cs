using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class KittieContext : DbContext
{
    public KittieContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Kitten> Kittens { get; set; }
}
}
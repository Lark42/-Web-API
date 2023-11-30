using Microsoft.EntityFrameworkCore;
using VisitorCore.Models;

namespace VisitorWebApi.Models
{
    public class VisitorAppContext : DbContext
    {
        public DbSet<Visitor> Visitors { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public VisitorAppContext(DbContextOptions<VisitorAppContext> options) : base(options)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedrandaGarciaGabrielApi.Model;

namespace MedrandaGarciaMisael.Data
{
    public class MedrandaGarciaMisaelContext : DbContext
    {
        public MedrandaGarciaMisaelContext (DbContextOptions<MedrandaGarciaMisaelContext> options)
            : base(options)
        {
        }

        public DbSet<MedrandaGarciaGabrielApi.Model.User> User { get; set; } = default!;
    }
}

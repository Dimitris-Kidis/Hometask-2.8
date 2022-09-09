using Hometask_2._8.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2._8.Context
{
    public class ScheduleDbContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.;Database=EFCore;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Schedule>()
                .HasOne<Client>(client => client.Client)
                .WithMany(schdule => schdule.Schedules)
                .HasForeignKey(schedule => schedule.ClientId);
        }
    }
}

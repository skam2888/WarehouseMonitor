using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseMonitorServer.Models.CWMS3000.Contexts
{
    public class CWMSContext : DbContext
    {
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Nomenklatura> Nomenklatura { get; set; }
        public DbSet<Contragent> Contragent { get; set; }
        public DbSet<CellAddress> CellAddress { get; set; }
        public DbSet<DicData> DicData { get; set; }
        public DbSet<UnitNom> UnitNom { get; set; }
        public CWMSContext(DbContextOptions<CWMSContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime NowDate = DateTime.Now;
            modelBuilder.Entity<Stock>().HasQueryFilter(s => s.Cnt > 0 && NowDate > s.StartDate && NowDate < s.EndDate);
           // modelBuilder.Entity<UnitNom>().HasQueryFilter(unitNom =>NowDate > unitNom.StartDate && NowDate < unitNom.EndDate);
        }

        public CWMSContext()
        {

        }
    }
}

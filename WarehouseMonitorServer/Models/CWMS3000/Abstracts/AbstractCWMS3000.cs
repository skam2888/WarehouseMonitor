using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseMonitorServer.Models.CWMS3000.Abstracts
{
    public abstract class AbstractCWMS3000
    {
        [Key]
        [Column("N")]
        public int Id { get; set; }

        [Column("FD")]
        public DateTime? StartDate { get; set; }

        [Column("TD")]
        public DateTime? EndDate { get; set; }
    }
}

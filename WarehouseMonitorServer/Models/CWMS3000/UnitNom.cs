using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("DIC_DATA_ALL_LANG")]
    public class UnitNom
    {
        [Key]
        [Column("N")]
        public int? Id { get; set; }
        [Column("FD")]
        public DateTime? StartDate { get; set; }
        [Column("TD")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("NOMENKLATURA_N")]
        public Nomenklatura Nomenklatura { get; set; }

        [ForeignKey("UNIT_TYP")]
        public Nomenklatura UnitTyp { get; set; }

        [Column("UNIT_CNT")]
        public int UnitCnt { get; set; }
    }
}

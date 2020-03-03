using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("CELL_ADDRESS")]
    public class CellAddress
    {
        [Key]
        [Column("N")]
        public int? Id { get; set; }
        [Column("FD")]
        public DateTime? StartDate { get; set; }
        [Column("TD")]
        public DateTime? EndDate { get; set; }
        [Column("FLOR")]
        public int? Flor { get; set; }
        [Column("LINE")]
        public int? Line { get; set; }
        [Column("STAGE")]
        public int? Stage { get; set; }
        [Column("PLACE")]
        public int? Place { get; set; }
        [Column("ADDR")]
        public string Addr { get; set; }
        [Column("CELL_TYP_N")]
        public int? CellTypN { get; set; }
        [Column("CELL_TYP_N2")]
        public int? CellTypN2 { get; set; }
        [Column("SECTION")]
        public int? Section { get; set; }
        [Column("ORD")]
        public int? Ord { get; set; }

    }
}

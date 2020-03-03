using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("NOMENKLATURA")]
    public class Nomenklatura
    {
        [Key]
        [Column("N")]
        public int? Id { get; set; }
        [Column("FD")]
        public DateTime? StartDate { get; set; }
        [Column("TD")]
        public DateTime? EndDate { get; set; }
        [ForeignKey("CONTRAGENT_N")]
        public Contragent Contragent { get; set; }
        [Column("CODE")]
        public string Code { get; set; }
        [Column("ARTK")]
        public string Artk { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("EXPIRE")]
        public int? Expire { get; set; }
        [Column("UNIT_OP")]
        public int? UnitOp { get; set; }
        [Column("CLIENT_UNIT")]
        public int? ClientUnit { get; set; }
        [Column("UNIT")]
        public int? Unit { get; set; }
    }
}

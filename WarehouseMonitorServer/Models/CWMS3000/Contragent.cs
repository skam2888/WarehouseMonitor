using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("CONTRAGENT")]
    public class Contragent
    {
        [Key]
        [Column("N")]
        public int? Id { get; set; }
        [Column("FD")]
        public DateTime? StartDate { get; set; }
        [Column("TD")]
        public DateTime? EndDate { get; set; }
        [Column("BRIEF")]
        public string Brief { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("AUTO_RESERVE_GRP")] 
        public int? AutoResrvGroup { get; set; }
    }
}

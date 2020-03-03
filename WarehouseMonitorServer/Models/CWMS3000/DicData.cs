using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("DIC_DATA_ALL_LANG")]
    public class DicData
    {
        [Column("N")]
        public int Id { get; set; }
        [Column("FD")]
        public DateTime? StartDate { get; set; }
        [Column("TD")]
        public DateTime? EndDate { get; set; }
        [Column("UP")]
        public int? Up { get; set; }
        [Key]
        [Column("CODE")]
        public int Code { get; set; }
        [Column("TERM")]
        public string Term { get; set; }
    }
}

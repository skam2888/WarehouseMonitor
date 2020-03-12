using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseMonitorServer.Models.CWMS3000.Abstracts;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("DIC_DATA_ALL_LANG")]
    public class DicData : AbstractCWMS3000
    {
        [Column("UP")]
        public int? Up { get; set; }
       
        [Column("CODE")]
        public int Code { get; set; }

        [Column("TERM")]
        public string Term { get; set; }
    }
}

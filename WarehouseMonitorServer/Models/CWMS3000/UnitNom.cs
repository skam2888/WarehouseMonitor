using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseMonitorServer.Models;
using WarehouseMonitorServer.Models.CWMS3000.Interfaces;
using WarehouseMonitorServer.Models.CWMS3000.Abstracts;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("NOM_UNIT")]
    public class UnitNom : AbstractCWMS3000, IDicData
    {
        [ForeignKey("NOMENKLATURA_N")]
        public Nomenklatura Nomenklatura { get; set; }
        
        [Column("UNIT_TYP")]
        public int UnitTyp { get; set; } // UntiTyp.Up = 362

        [Column("UNIT_CNT")]
        public int? UnitCnt { get; set; }

        [NotMapped]
        private const int UPDICDATEUNITTYP = 362;

        [NotMapped]
        public DicData DicData { get; private set; }

        public HashSet<int> GetCodeDicData()
        {
            HashSet<int> hashSetDD = new HashSet<int>();
            hashSetDD.Add(UPDICDATEUNITTYP);
            return hashSetDD;
        }

        public void SetDicData(IEnumerable<DicData> dicDatas)
        {
            DicData = dicDatas.Where(dd => dd.Code == UnitTyp && dd.Up == UPDICDATEUNITTYP).First();
        }
    }
}

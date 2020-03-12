using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseMonitorServer.Models.CWMS3000.Interfaces;
using WarehouseMonitorServer.Models.CWMS3000.Abstracts;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("NOMENKLATURA")]
    public class Nomenklatura : AbstractCWMS3000, IDicData
    {
        [Column("CONTRAGENT_N")]
        public int ContragentId { get; set; }

        [NotMapped]
        public Contragent Contragent { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("ARTK")]
        public string Artk { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("EXPIRE")]
        public int? Expire { get; set; }

        public IEnumerable<UnitNom> UnitNoms { get; set; }

        [Column("UNIT_OP")]
        public int UnitOpId { get; set; }

        [NotMapped]
        public UnitNom UnitOp 
        {
            get
            {
                return UnitNoms.Where(u => u.UnitTyp == UnitOpId).First();
            }
            private set { }
         
        }

        [Column("CLIENT_UNIT")]
        public int ClientUnitId { get; set; }

        [NotMapped]
        public UnitNom ClientUnit
        {
            get
            {
                return UnitNoms.Where(u => u.UnitTyp == ClientUnitId).First();
            }
            private set { }
        }

        [Column("UNIT")]
        public int UnitId { get; set; }

        [NotMapped]
        public UnitNom Unit
        {
            get
            {
                return UnitNoms.Where(u => u.UnitTyp == UnitId).First();
            }
            private set { }
        }

        public HashSet<int> GetCodeDicData()
        {
            HashSet<int> hashSetDD = new HashSet<int>();
            hashSetDD.UnionWith(Unit.GetCodeDicData());
            hashSetDD.UnionWith(UnitOp.GetCodeDicData());
            hashSetDD.UnionWith(ClientUnit.GetCodeDicData());
            return hashSetDD;
        }

        public void SetDicData(IEnumerable<DicData> dicDatas)
        {
            Unit.SetDicData(dicDatas);
            UnitOp.SetDicData(dicDatas);
            ClientUnit.SetDicData(dicDatas);
        }
    }
}

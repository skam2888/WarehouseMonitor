using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseMonitorServer.Models.CWMS3000.Interfaces;
using WarehouseMonitorServer.Models.CWMS3000.Abstracts;

namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("ST_STOCK")]
    public class Stock : AbstractCWMS3000, IDicData
    {
        [ForeignKey("CONTRAGENT_N")]
        public Contragent Contragent { get; set; }

        [ForeignKey("NOMENKLATURA_N")]
        public Nomenklatura Nomenklatura { get; set; }

        [ForeignKey("CELL_ADDRESS_N")]
        public CellAddress CellAdress { get; set; }

        [Column("EXPIRE_DATE")]
        public DateTime? ExpireDate { get; set; }

        [Column("CNT")]
        public int Cnt { get; set; }
       
        [Column("TYP")]
        public int TypId { get; set; } //Typ.up = 416

        [NotMapped]
        private const int UPDICDATETYP = 416;

        [NotMapped]
        public DicData Typ {get; set; } //Typ.up = 416

        [Column("NOM_TYP")]
        public int? NomTyp { get; set; }

        [Column("ST_PALL_N")]
        public int? PID { get; set; }

        [Column("QUANTUM")]
        public float? Quantum { get; set; }

        public void SetDicData(IEnumerable<DicData> dicDatas)
        {
            Nomenklatura.SetDicData(dicDatas);
            Typ = dicDatas.Where(dd => dd.Code == TypId && dd.Up == UPDICDATETYP).First();
        }

        public HashSet<int> GetCodeDicData()
        {
            HashSet<int> hashSetDD = new HashSet<int>();
            hashSetDD.Add(UPDICDATETYP);
            hashSetDD.UnionWith(Nomenklatura.GetCodeDicData());
            return hashSetDD;
        }
    }
}

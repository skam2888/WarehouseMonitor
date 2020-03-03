using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WarehouseMonitorServer.Models.CWMS3000
{
    [Table("ST_STOCK")]
    public class Stock
    {
        [Key]
        [Column("N")]
        public int Id { get; set; }
        [Column("FD")]
        public DateTime? StartDate { get; set; }
        [Column("TD")]
        public DateTime? EndDate { get; set; }
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
       
        [ForeignKey("TYP")]
        public DicData Typ { get; set; } //Typ.up = 416

        [Column("NOM_TYP")]
        public int? NomTyp { get; set; }
        [Column("ST_PALL_N")]
        public int? PID { get; set; }
        [Column("QUANTUM")]
        public float? Quantum { get; set; }
    }
}

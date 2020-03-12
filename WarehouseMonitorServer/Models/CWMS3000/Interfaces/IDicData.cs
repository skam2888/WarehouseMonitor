using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseMonitorServer.Models.CWMS3000.Interfaces
{
    public interface IDicData
    {
        public void SetDicData(IEnumerable<DicData> dicDatas);
        public HashSet<int> GetCodeDicData();
    }
}

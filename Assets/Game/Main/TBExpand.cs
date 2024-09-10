using UnityEngine;

namespace cfg.Battle
{

    public partial class TBMonster : ITablePostProcess
    {
        public void PostProcess(Tables tables)
        {
            Debug.Log("PostProcess: TBMonster");
        }
    }
}
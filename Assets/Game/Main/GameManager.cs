using System;
using Congroo.Core;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Init();
    }

    private void Init()
    {
#if UNITY_EDITOR
        UniqueIdValidCheck.Check(typeof(EventID));
#endif
        CfgTable.Ins.Init();
    }
}

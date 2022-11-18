using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g4_R4C2 : g4_ControllerRowColum
{
    public static g4_R4C2 Singleton;
    protected override void Awake()
    {
        base.Awake();
        Singleton = this;
    }
}

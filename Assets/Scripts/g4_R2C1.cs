using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g4_R2C1 : g4_ControllerRowColum
{
    public static g4_R2C1 Singleton;
    protected override void Awake()
    {
        base.Awake();
        Singleton = this;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g4_Controller : MonoBehaviour
{
    public List<Vector3> Point;
    public static g4_Controller Singleton;
    private void Awake()
    {
        Singleton = this;
    }


}

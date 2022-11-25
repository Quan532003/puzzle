using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class g4_ControllerRowColum : MonoBehaviour
{
    public List<bool> isBlank;
    public List<GameObject> Slot;
    protected virtual void Awake()
    {
        SetUp();
    }
    public void SetUp()
    {
        for (int i = 0; i < 3; i++)
        {
            Slot.Add(transform.GetChild(i).gameObject);
        }
        for (int i = 0; i < Slot.Count; i++)
        {
            isBlank.Add(true);
        }
        for (int i = 0; i < Slot.Count; i++)
        {
            var index = i;
            if (Slot[index].transform.childCount == 0)
            {
                isBlank[index] = true;
            }
            else isBlank[index] = false;
        }
    }
}

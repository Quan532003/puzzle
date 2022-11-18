using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g4_MainObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private Vector3 lastPos;
    private GameObject RC;
    private void Start()
    {
        lastPos = transform.position;

    }
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        lastPos = transform.position;
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }
    private void OnMouseUp()
    {
        var dem = 0;
        for (int i = 0; i < 3; i++)
        {
            if (Vector3.Distance(transform.position, g4_R0C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R0C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R0C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R0C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R0C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R0C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
              
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R0C2.Singleton.Slot[i].transform.position) < 0.2f && g4_R0C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R0C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R1C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R1C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R1C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
              
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R1C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R1C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R1C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R1C2.Singleton.Slot[i].transform.position) < 0.2f && g4_R1C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R1C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R2C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R2C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R2C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R2C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R2C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R2C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R2C2.Singleton.Slot[i].transform.position) < 0.2f && g4_R2C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R2C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R3C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R3C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R3C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R3C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R3C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R3C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R3C2.Singleton.Slot[i].transform.position) < 0.2f && g4_R3C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R3C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R4C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R4C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R4C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R4C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R4C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R4C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R4C2.Singleton.Slot[i].transform.position) < 0.22f && g4_R4C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R4C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R5C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R5C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R5C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
              
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R5C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R5C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R5C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R5C2.Singleton.Slot[i].transform.position) < 0.2f && g4_R5C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R5C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R6C0.Singleton.Slot[i].transform.position) < 0.2f && g4_R6C0.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R6C0.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R6C1.Singleton.Slot[i].transform.position) < 0.2f && g4_R6C1.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R6C1.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
               
                dem++;
            }
            if (Vector3.Distance(transform.position, g4_R6C2.Singleton.Slot[i].transform.position) < 0.2f && g4_R6C2.Singleton.Slot[i].transform.childCount == 0)
            {
                transform.SetParent(g4_R6C2.Singleton.Slot[i].transform);
                transform.localPosition = Vector3.zero;
                
                dem++;
            }



        }
        if(dem == 0)
        {
            transform.position = lastPos;
        }
    }


}

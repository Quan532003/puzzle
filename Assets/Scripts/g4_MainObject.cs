using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g4_MainObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private Vector3 lastPos;
    public List<GameObject> RC;
   
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
        test2();

    }
    public void test2()
    {
        var dem = 0;
        for (int k = 0; k < g4_Controller.Singleton.RC.Count; k++)
        {
            int index_k = k;
            for (int i = 0; i < 3; i++)
            {

                int index_i = i;
                Debug.Log(index_i);
                var slot = g4_Controller.Singleton.RC[index_k].transform.GetChild(index_i);
                if (Vector3.Distance(transform.position, slot.position) < 0.3f && slot.childCount == 0)
                {
                    Debug.Log("test");
                    transform.SetParent(slot.transform);
                    transform.localPosition = Vector3.zero;
                    dem++;
                    g4_Controller.Singleton.Check(index_k);
                }
            }
        }
        if (dem == 0) transform.localPosition = Vector3.zero;
    }
    
}

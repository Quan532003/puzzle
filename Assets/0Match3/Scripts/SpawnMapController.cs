using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMapController : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject wallPrefab;
    public List<GameObject> line;
    public List<GameObject> wall;
    int row, col;
    public static SpawnMapController Singleton;
    public GameObject LineTotal;
    private void Awake()
    {
        Singleton = this;
        row = 7;
        var hPerw = (float)(1f) / Camera.main.aspect;
        if (hPerw == 2340f / 1080f)
        {
            Camera.main.transform.position = new Vector3(0, -0.8f, -10);
            row = 8;
        }
        if (hPerw == 1366f / 1024f)
        {
            Camera.main.transform.position = new Vector3(0, 0.7f, -10);
            row = 6;
        }
        if (hPerw == 2160f / 1080f)
        {
            Camera.main.transform.position = new Vector3(0, -1.3f, -10);
            row = 8;
        }
        if (hPerw == 2960f / 1440f)
        {
            Camera.main.transform.position = new Vector3(0, -1.1f, -10);
            row = 8;
        }

        Camera.main.orthographicSize = 5.625f * hPerw * 5.54f / 10f;

        col = 3;
        SpawnWall();
        SpawnLine();
    }
    public void SpawnWall()
    {
        var weight = Camera.main.orthographicSize * 2f * Camera.main.aspect;
        //weight /= 3f;
        for(int i = 0; i < 4; i++)
        {
            var wallIns = Instantiate(wallPrefab);
            wallIns.transform.position = new Vector3(-weight / 2f + i * weight / 3f, 0, 0);
            wall.Add(wallIns);
            wallIns.transform.SetParent(LineTotal.transform);
        }
    }
    public void SpawnLine()
    {

        var height = Camera.main.orthographicSize;
      
        for(int j = 0; j < 3; j++)
        {
            if(j == 1)
            {
                var midRow = Instantiate(linePrefab);
                midRow.transform.position = new Vector3((wall[j].transform.position.x + wall[j + 1].transform.position.x) / 2f, height - height*2f/row + 0.1f, 0);
                line.Add(midRow);
                midRow.transform.SetParent(LineTotal.transform);
            }
            else
            {
                var Row = Instantiate(linePrefab);
                Row.transform.position = new Vector3((wall[j].transform.position.x + wall[j + 1].transform.position.x) / 2f, height - height*2f / row, 0);
                line.Add(Row);
                Row.transform.SetParent(LineTotal.transform);
            }
        }
        for(int i = 1; i < row; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                var Row = Instantiate(linePrefab);
                Row.transform.position = new Vector3(line[j].transform.position.x, line[j].transform.position.y - height*2f / row * i, 0);
                line.Add(Row);
                Row.transform.SetParent(LineTotal.transform);
            }
        }
    }
}

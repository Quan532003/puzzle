using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using Random = UnityEngine.Random;

public class g4_Controller : MonoBehaviour
{
    public List<GameObject> RC;
    public List<GameObject> gO;
    public List<GameObject> slot;
    public static g4_Controller Singleton;
    public GameObject gold;
    public int row = 7, col = 3;
    public ScriptsTableobject scrOb;
    public List<int> rand_index = new List<int>();
    public List<int> rand_type = new List<int>();
    private void Awake()
    {
        for (int i = 0; i < RC.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                slot.Add(RC[i].transform.GetChild(j).transform.gameObject);
            }
        }
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
        Singleton = this;
        col = 3;
        SpawnLevel(4);
    }
    public void SpawnLevel(int level)
    {
        var col = g4_Controller.Singleton.col;
        var row = g4_Controller.Singleton.row;
        var sum = col * row;
        if (sum <= 21)
        {
            for (int i = 0; i < sum - 1; i++)
            {
                while (true)
                {
                    var rand_ty = (int)(Random.Range(0, 20));
                    var dem = 0;
                    for (int j = 0; j < rand_type.Count; j++)
                    {
                        if (rand_type[j] == rand_ty) dem++;
                    }
                    if (dem == 0)
                    {
                        rand_type.Add(rand_ty);
                        for (int j = 0; j < 3; j++)
                        {
                            List<int> try_rand_ind = new List<int>();
                            while (true)
                            {
                                var rand_i = Random.Range(0, sum * 3);
                                var d = 0;
                                for (int l = 0; l < rand_index.Count; l++)
                                {
                                    if (rand_index[l] == rand_i)
                                    {
                                        d++;
                                    }
                                }
                                int cnt = try_rand_ind.Count;
                                if (cnt == 0 && d == 0)
                                {
                                    try_rand_ind.Add(rand_i);

                                }
                                else if (d == 0 && cnt > 0 && MathF.Abs(rand_i - try_rand_ind[cnt - 1]) > level)
                                {
                                    try_rand_ind.Add(rand_i);
                                    rand_index.Add(rand_i);
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < 3; j++)
                        {
                            var idj = j;
                            var gO_1 = Instantiate(g4_Controller.Singleton.gO[rand_ty]);
                            gO_1.transform.SetParent(g4_Controller.Singleton.slot[rand_index[rand_index.Count - idj - 1]].transform);
                            gO_1.transform.localPosition = new Vector3(0, 0, 0);
                        }
                        break;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < sum - 1; i++)
            {
                while (true)
                {
                    var rand_ty = (int)(Random.Range(0, 20));
                    var dem = 0;
                    for (int j = 0; j < rand_type.Count; j++)
                    {
                        if (rand_type[j] == rand_ty) dem++;
                    }
                    if (dem < 2)
                    {
                        rand_type.Add(rand_ty);
                        for (int j = 0; j < 3; j++)
                        {
                            List<int> try_rand_ind = new List<int>();
                            while (true)
                            {
                                var rand_i = Random.Range(0, sum * 3);
                                var d = 0;
                                for (int l = 0; l < rand_index.Count; l++)
                                {
                                    if (rand_index[l] == rand_i)
                                    {
                                        d++;
                                    }
                                }
                                int cnt = try_rand_ind.Count;
                                if (cnt == 0 && d == 0)
                                {
                                    try_rand_ind.Add(rand_i);

                                }
                                else if (d == 0 && cnt > 0 && MathF.Abs(rand_i - try_rand_ind[cnt - 1]) > level)
                                {
                                    try_rand_ind.Add(rand_i);
                                    rand_index.Add(rand_i);
                                    break;
                                }
                            }
                        }
                        for (int j = 0; j < 3; j++)
                        {
                            var idj = j;
                            var gO_1 = Instantiate(g4_Controller.Singleton.gO[rand_ty]);
                            gO_1.transform.SetParent(g4_Controller.Singleton.slot[rand_index[rand_index.Count - idj - 1]].transform);
                            gO_1.transform.localPosition = new Vector3(0, 0, 0);
                        }
                        break;
                    }
                }
            }
        }
        List<int> pos = new List<int>();
        for (int i = 0; i < sum * 3; i++)
        {
            if (!rand_index.Contains(i))
            {
                pos.Add(i);
            }
        }
        var gO_in = Instantiate(g4_Controller.Singleton.gO[rand_type[0]]);
        gO_in.transform.SetParent(g4_Controller.Singleton.slot[pos[0]].transform);
        gO_in.transform.localPosition = new Vector3(0, 0, 0);
        var go_in1 = Instantiate(g4_Controller.Singleton.gO[rand_type[1]]);
        go_in1.transform.SetParent(g4_Controller.Singleton.slot[pos[1]].transform);
        go_in1.transform.localPosition = new Vector3(0, 0, 0);
    }
    public void Check(int index)
    {
        List<GameObject> slot = new List<GameObject>();
        List<GameObject> child_slot = new List<GameObject>();
        var dem = 0;
        var rc_i = RC[index].transform;
        for (int j = 0; j < 3; j++)
        {
            slot.Add(rc_i.GetChild(j).gameObject);
            if (slot[j].transform.childCount > 0)
            {
                child_slot.Add(slot[j].transform.GetChild(0).gameObject);
                dem++;
            }
        }
        if (dem == 3)
        {
            if (child_slot[0].CompareTag(child_slot[1].tag) && child_slot[1].CompareTag(child_slot[2].tag))
            {
                for (int j = 0; j < 3; j++)
                {
                    var indexj = j;
                    child_slot[indexj].transform.DOScale(Vector3.zero, 0.5f).OnComplete(() =>
                    {
                        Destroy(child_slot[indexj]);
                        gold.transform.position = slot[1].transform.position;
                        gold.SetActive(true);
                        gold.transform.DOMove(6 * Vector3.up, 2f).OnComplete(() =>
                        {
                            gold.SetActive(false);
                        });
                    });
                }
            }
        }

    }

}

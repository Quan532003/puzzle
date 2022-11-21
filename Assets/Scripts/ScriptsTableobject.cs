using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

[Serializable]
public class SlotData
{
    public List<int> index;
    public int type;

}
[Serializable]
[CreateAssetMenu(fileName = "slot_data", menuName = "datas/slot_data")]
public class ScriptsTableobject : ScriptableObject
{
    int level;
    public List<SlotData> slot_data;

    List<int> rand_index = new List<int>();
    List<int> rand_type = new List<int>();
    public void SpawnLevel_1_30()
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
                    var rand = (int)(Random.Range(1, 21));
                    var dem = 0;
                    for (int j = 0; j < rand_type.Count; j++)
                    {
                        if (rand_type[j] == rand) dem++;
                    }
                    if (dem == 0)
                    {
                        SlotData slData = new SlotData();
                        slData.type = rand;

                        for (int j = 0; j < 3; j++)
                        {
                            List<int> try_rand = new List<int>();
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
                                int cnt = try_rand.Count;
                                if(cnt == 0 && d == 0)
                                {
                                    try_rand.Add(rand_i);
                          
                                }
                                else if (d == 0 && cnt > 0 && MathF.Abs(rand_i - try_rand[cnt - 1]) != 1)
                                {
                                    try_rand.Add(rand_i);
                                    rand_index.Add(rand_i);
                                    break;
                                }
                            }
                            slData.index.Add(try_rand[try_rand.Count - 1]);
                        }
                        slot_data.Add(slData);
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
                    var rand = (int)(Random.Range(1, 21));
                    var dem = 0;
                    for (int j = 0; j < slot_data.Count; j++)
                    {
                        if (slot_data[j].type == rand) dem++;
                    }
                    if (dem < 2)
                    {
                        SlotData slData = new SlotData();
                        slData.type = rand;

                        for (int j = 0; j < 3; j++)
                        {
                            List<int> try_rand = new List<int>();
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
                                int cnt = try_rand.Count;
                                if (d == 0 && MathF.Abs(rand_i - try_rand[cnt - 1]) != 5)
                                {
                                    try_rand.Add(rand_i);
                                    rand_index.Add(rand_i);
                                    break;
                                }
                            }
                            slData.index.Add(try_rand[try_rand.Count - 1]);
                        }
                        slot_data.Add(slData);
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < slot_data.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log("A");
                var gO = Instantiate(g4_Controller.Singleton.gO[slot_data[i].type - 1]);
                gO.transform.SetParent(g4_Controller.Singleton.slot[slot_data[i].index[j]].transform);
                gO.transform.localPosition = Vector3.zero;
            }
        }
    }

}
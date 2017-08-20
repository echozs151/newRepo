using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleObjectsWithLoop : MonoBehaviour
{
    public GameObject[] gos;
    public ArrayList allHumans;
    // Use this for initialization
    void Start()
    {
        gos = new GameObject[10];
        
        allHumans = new ArrayList();
        //allHumans = new GameObject[6];
        for (int i = 0; i < 10; i++)
        {
            GameObject go =
                GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3();
            v.x = Random.Range(-10, 10);
            v.z = Random.Range(-10, 10);
            go.transform.position = v;
            go.name = i.ToString() + " CUBE";
            if (i % 2 == 0)
            {
                go.AddComponent(typeof(ZombieData));
            }
            gos[i] = go;
        }

    }

    // Update is called once per frame
    void Update()
    {
        testForEach();
    }

    void testForEach()
    {
        foreach (GameObject go in gos)
        {
            ZombieData zd =
            (ZombieData)go.GetComponent(typeof(ZombieData));
            if (zd == null)
            {
                HumanData hd = (HumanData)go.GetComponent(typeof(HumanData));
                if(hd != null)
                {
                    allHumans.Add(go);
                }
                continue;
            }
            if (zd.hp > 0)
            {
                break;
            }
            print(go.name);
            zd.hp = 10;
        }

    }
}
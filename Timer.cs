using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    //public GameObject pos;
    public float NextTime = 0f;
    public float timer = 0.5f;
    public int Counter = 10;
    private Vector3 tPos;
    public int minHeight = 1;
    public int maxHeight = 10;
    public float HorizontalSpacing = 2f;
    public float VerticalSpacing = 1f;

    void Start()
    {
        tPos = GetComponent<Transform>().position;
    }
    void Update()
    {
        if (Counter > 0 && Time.fixedTime > NextTime)
        {
            NextTime = Time.fixedTime + timer;
            for (int j = 10; j > 0; j--)
            {
                int randomNumber = Random.Range(minHeight, maxHeight);
                for (int i = 0; i < randomNumber; i++)
                {
                    GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    box.transform.position = new Vector3((Counter * HorizontalSpacing), i * VerticalSpacing, j + HorizontalSpacing) + tPos;
                }
            }
            Counter-- ;
        }
    }
}

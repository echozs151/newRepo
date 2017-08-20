using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingClass : MonoBehaviour {


    public float NextTime = 0f;
    public float timer = 0.5f;
    public int Counter = 10;
    private Vector3 tPos;
    public int minHeight = 1;
    public int maxHeight = 10;
    public float HorizontalSpacing = 2f;
    public float VerticalSpacing = 1f;
    // Use this for initialization
    void Start () {
        tPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Counter > 0 && Time.fixedTime > NextTime)
        {
            NextTime = Time.fixedTime + timer;
            for (int j = 10; j > 0; j--)
            {
                int randomNumber = UnityEngine.Random.Range(minHeight, maxHeight);
                for (int i = 0; i < randomNumber; i++)
                {
                    CustomBox cBox = new CustomBox();
                    cBox.box.transform.position = new Vector3(Counter * HorizontalSpacing, i * VerticalSpacing, j * HorizontalSpacing) + tPos;
                    cBox.PickRandomColor();
                }
            }
            Counter--;
        }
    }

    class CustomBox
    {
        public GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);

        public void PickRandomColor()
        {
            int randomNumber = UnityEngine.Random.Range(0, 3);
            print(randomNumber);
            Color[] color = { Color.red, Color.green, Color.blue };
            
            box.GetComponent<Renderer>().material.color = color[randomNumber];
            //throw new NotImplementedException();
        }
    }
}

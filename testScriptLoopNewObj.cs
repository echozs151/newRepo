using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScriptLoopNewObj : MonoBehaviour {
    int numOfCubes = 0;
    enum Days : int
    {
        Sun = 0,
        Mon = 1,
        Tus = 2
    }

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		while(numOfCubes < 10)
        {
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.transform.position = new Vector3(GetComponent<Transform>().transform.position.x + numOfCubes, GetComponent<Transform>().transform.position.y+10, GetComponent<Transform>().transform.position.z + +numOfCubes);
            numOfCubes++;
        }
	}
}

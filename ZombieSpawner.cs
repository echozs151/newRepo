using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Zombies.numZombies < 4)
        {
            GameObject go =
            GameObject.CreatePrimitive(PrimitiveType.Capsule);
            go.AddComponent(typeof(Zombies));
            go.transform.position = transform.position;
        }
    }
}

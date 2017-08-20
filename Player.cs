using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Vector3 pos;
    public float movementSpeed;
    public bool zombieChase;

	// Use this for initialization
	void Start () {
        //set the position to where we start off in the scene
        if (zombieChase)
            Zombies.enableChase = true;
        else
            Zombies.enableChase = false;

            pos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        bool WKey = Input.GetKey(KeyCode.W);
        bool SKey = Input.GetKey(KeyCode.S);
        bool AKey = Input.GetKey(KeyCode.A);
        bool DKey = Input.GetKey(KeyCode.D);
        bool ShiftKey = Input.GetKey(KeyCode.LeftShift);
        if (zombieChase)
            Zombies.enableChase = true;
        else
            Zombies.enableChase = false;
        if (AKey)
        {
            Debug.Log("AKey");
            Zombies.CountZombies();
        }
        if (WKey)
        {
            pos.z += movementSpeed;
            //if(ShiftKey)            // Doesnt Work. it still moves forward. Contain vertical movement to its own if.
            //{
            //    pos.y += movementSpeed;
            //}
        }
        if (SKey)
        {
            pos.z -= movementSpeed;
            //if (shiftkey)
            //{
            //    pos.y -= movementspeed;
            //}
        }
        if (AKey)
        {
            pos.x -= movementSpeed;
        }
        if (DKey)
        {
            pos.x += movementSpeed;
        }
        gameObject.transform.position = pos;
    }
}

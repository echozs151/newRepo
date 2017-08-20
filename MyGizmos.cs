using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum states { Sitting, Standing };

public class MyGizmos : MonoBehaviour {


    public states mState;
    // Use this for initialization
    public GameObject PlayerObject;
    void Start()
    {
        int number = (int)mState;
        Debug.Log(number);
        Vector3 pos = new Vector3();
        pos.x = Random.Range(-10f, 10f);
        pos.z = Random.Range(-10f, 10f);
        transform.position = pos;
        GameObject[] AllGameObjects = GameObject.FindObjectsOfType(typeof
        (GameObject)) as GameObject[];
        foreach (GameObject aGameObject in AllGameObjects)
        {
            Component aComponent = aGameObject.GetComponent(typeof(Player));
            if (aComponent != null)
            {
                PlayerObject = aGameObject;
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void vectorsTut(Vector3 Direction, float AttackRange)
    {

        //Distance from vectors
        Vector3 MyVector =
        PlayerObject.transform.position - transform.position;
        float DistanceToPlayer = MyVector.magnitude;
        if (DistanceToPlayer > AttackRange)
        {
            Direction =
            Vector3.Normalize(PlayerObject.transform.position -
            transform.position);
            transform.position += Direction * 0.1f;
        }
    }

}



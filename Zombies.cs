using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour {

    //variables
    public static int numZombies;
    public bool die;
    public GameObject player;
    public float speed = 0.01f;
    public static bool enableChase;

    //Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");  // or use // player = GameObject.Find("Main Camera");
        numZombies++;
        Debug.Log(numZombies);
    }

    // Update is called once per frame
    void Update () {
        if(enableChase)
        {
            Vector3 direction =
               (player.transform.position - transform.position).normalized;
            float distance =
                (player.transform.position - transform.position).magnitude;

            Vector3 move =
                transform.position + (direction * speed); // current position + the direction (which is always normalized) * speed modifier


            transform.position = move; //asign move to position

            if (distance < 1f)
            {
                die = true;
            }

            if (die)
            {
                numZombies--;
                Destroy(gameObject);
            }
        }
        

	}

    public static void CountZombies()
    {
        Debug.Log(numZombies);
    }
}

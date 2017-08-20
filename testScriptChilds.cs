using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScriptChilds : MonoBehaviour
{
    public bool showGameObjects;

    public class Cat
    {
        public int Paws = 4;
        public void Meow()
        {
           // Debug.Log("meow");
        }
    }
    public class PianoCat : Cat
    {
        public void PlayPiano()
        {
            Meow();
        }

    }

    public GameObject ChildObject;


    // Use this for initialization
    void Start()
    {
        PianoCat famousCat = new PianoCat();
        famousCat.PlayPiano();// child's ability
        famousCat.Meow();// inherited function
        //Debug.Log(famousCat.Paws);
        GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[]; // new GameObject Array named gos filled with objects of type GameObject
        foreach (GameObject go in gos)// loops in gos and assign in each pass elements in go
        {
            if(showGameObjects)
            {
                Debug.Log(go);
                Component comp = go.GetComponent(typeof(Child));// find if the component is Child type and set the Component in comp
                if (comp != null)
                {
                    ChildObject = go;
                    Debug.Log(ChildObject);
                }
            }
            
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
}


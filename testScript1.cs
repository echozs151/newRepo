using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript1 : MonoBehaviour
{
    public bool someBool;
    public int gold;
    public float otherScale;
    otherScope other;


    // Use this for initialization
    void Start () {

        //cube = new cubes();
        int a = 1;
        int b = 1;
        someBool = (a == b);
        gold = 10;
        other = (otherScope)GameObject.FindObjectOfType(typeof(otherScope));
        Debug.Log(other.gameObject.name);

    }
	
	// Update is called once per frame
	void Update () {

        // cameraController();
        setScale();
	}

    void mousePosition()
    {
        Debug.Log(Input.mousePosition);
    }

    void cameraController()
    {
        transform.rotation = Quaternion.Euler(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
    }

    void spitCubes()
    {
        

        Vector3 playerPos;
        playerPos = this.transform.position;
        //cube.transform.position = playerPos;

        
    }
    void setScale()
    {
        other.Size = otherScale;
    }
}

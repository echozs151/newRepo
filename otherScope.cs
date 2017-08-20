using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherScope : MonoBehaviour {

    public float Size;
    Vector3 mScale;
    Collider colider1;
    BoxCollider boxCollider;


    
	// Use this for initialization
	void Start () {
        boxCollider = GetComponent<BoxCollider>() as BoxCollider;
        
    }
	
	// Update is called once per frame
	void Update () {
        mScale = new Vector3(Size, Size, Size);
        
        gameObject.transform.localScale = mScale;
        //boxCollider.size = mScale;
        
        //colider1.transform.
	}
}

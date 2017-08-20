using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : Parent {

	// Use this for initialization
	void Start () {
        //Debug.Log(SomeInt);
        ParentAbility();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChildAbility()
    {
        Debug.Log("My parent doesn't get me.");

    }

}

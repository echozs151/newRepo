using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour {
    public float sens;
    public bool InvertedMouse;
    Camera mCamera;
    Vector3 camPos1;
    public GameObject scope;
    bool inScope;

    // Use this for initialization
    void Start () {
        sens = 0.5f;
        camPos1 = GetComponent<Transform>().position;
	}

    // Update is called once per frame
    float mouseX;
    float mouseY;
	void Update () {
        //
        //Zoom
        //
        changeViewPoint();
        //mouseControlWithAxis();
        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
	}

    void mouseControlWrong()
    {
        Vector3 mousePosition = Input.mousePosition;
        float mouseX = mousePosition.x;
        float mouseY = mousePosition.y;
        Debug.Log(transform.eulerAngles);
        transform.eulerAngles = new Vector3(-(mouseY * sens), (mouseX * sens), 0);
    }
    void mouseControlWithAxis()
    {
        float mouseX = Input.GetAxis("Mouse X");// Still Wrong. We get an in increase or decrease in the value. We can add this increase to the camera rotation
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
    void changeViewPoint()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(!inScope)
            { 
                transform.position = scope.transform.position;
                inScope = true;
            }
            else
            {
                transform.position = camPos1;
                inScope = false;
            }

        }
    }
}

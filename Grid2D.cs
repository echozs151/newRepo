using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2D : MonoBehaviour {

    // Use this for initialization
    public int Width;
    public int Height;
    public GameObject PuzzlePiece;
    private GameObject[,] Grid;
    //Use this for initialization
    void Start()
    {
        Grid = new GameObject[Width, Height];
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                GameObject go =
                GameObject.Instantiate(PuzzlePiece) as GameObject;
                Vector3 position = new Vector3(x, y, 0);
                go.transform.position = position;
                Grid[x, y] = go;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        Vector3 mPosition =
        Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Debug.DrawLine(Vector3.zero, mPosition);
        int x = (int)(mPosition.x + 0.5f);
        int y = (int)(mPosition.y + 0.5f);
        GameObject go = Grid[x, y];
        if((x < Width && x > 0) && (y < Height && y > 0))
            go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}

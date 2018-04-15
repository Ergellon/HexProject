using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

    public int gridsize;
    public float max_x, max_y,min_x,min_y;

    public GameObject Hex;

    private Transform gamefield;

    private List<Vector3Int> hexcoords = new List<Vector3Int>();
    private Vector2 truecoords = new Vector2();

	// Use this for initialization
	void Start ()
    {
        gamefield = new GameObject("Game Field").transform;
        int t = 0;
        for (int x = -gridsize; x<= gridsize;x++)
        {
            if (x <= 0)
            {
                for (int y = t; y <= gridsize; y++)
                {
                    truecoords.x = x * 3f / 4f;
                    truecoords.y = (y + x / 2f) * Mathf.Sqrt(3) * 0.5f;
                    GameObject instance = Instantiate(Hex, truecoords, Quaternion.Euler(0, 0, 30));
                    instance.transform.SetParent(gamefield);
                }
                t--;
            }
            else
            {
                for (int y = -gridsize; y<-t-1; y++)
                {
                    truecoords.x = x * 3f / 4f;
                    truecoords.y = (y + x / 2f) * Mathf.Sqrt(3) * 0.5f;
                    GameObject instance = Instantiate(Hex, truecoords, Quaternion.Euler(0, 0, 30));
                    instance.transform.SetParent(gamefield);
                }
                t++;
            }
        }




        /*for (int x = -gridsize; x<gridsize;x++)
        {
            for (int y = - gridsize; y<gridsize;y++)
            {
                
                    truecoords.x = x*3f/4f ;
                    truecoords.y = (y+x/2f)*Mathf.Sqrt(3)*0.5f;
                if (truecoords.y < max_y && truecoords.y > min_y)
                {
                    GameObject instance = Instantiate(Hex, truecoords, Quaternion.Euler(0, 0, 30));
                    instance.transform.SetParent(gamefield);
                }
            }
        }*/

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

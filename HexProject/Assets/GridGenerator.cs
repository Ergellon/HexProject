using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

    public int gridsize;
    public GameObject Hex;

    private Transform gamefield;

    private List<Vector3Int> hexcoords = new List<Vector3Int>();
    private Vector2 truecoords = new Vector2();

	// Use this for initialization
	void Start ()
    {
        gamefield = new GameObject("Game Field").transform;

        for (int x = -gridsize; x<gridsize;x++)
        {
            for (int y = - gridsize; y<gridsize;y++)
            {
                for (int z = -gridsize; z<gridsize; z++)
                {
                    truecoords.x = x - y * 0.5f;
                    truecoords.y = y * Mathf.Sqrt(3)*0.5f;
                    GameObject instance = Instantiate(Hex, truecoords, Quaternion.identity);
                    instance.transform.SetParent(gamefield);
                }
            }
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

    public int gridradius;

    private Transform gamefield;

    private List<Vector3> hexpositions = new List<Vector3>();

    private Vector3 trueposition = new Vector3();

    public GameObject Hex;

	// Use this for initialization
	void Start () {

        hexpositions.Clear();
        gamefield = new GameObject("Game Field").transform;

        for (int x = 0; x < gridradius; x++){
            for (int y = 0; y < gridradius; y++){
                for (int z = 0; z < gridradius; z++)
                {
                    hexpositions.Add(new Vector3(x, y, z));
                    trueposition.x = y - z;
                    trueposition.y = z - x;
                    GameObject instance = Instantiate(Hex, new Vector3(trueposition.x, trueposition.y, 0f), Quaternion.identity);
                }
            }
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        int i = 0;
        if(i == 0)
        {
            Debug.Log("KEKS");
        }
	}
}

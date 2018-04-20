using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {


    public int gridsize;

    public GameObject Hex;

    private Transform gamefield;

    private Vector2 truecoords = new Vector2();

    // public GameObject gamefieldmanager;
    public GameFieldManager gamefieldmanager;



    void CreateHex (int x, int y)
    {
        truecoords.x = x * 3f / 4f;
        truecoords.y = (y + x / 2f) * Mathf.Sqrt(3) * 0.5f;
        GameObject instance = Instantiate(Hex, truecoords, Quaternion.Euler(0, 0, 30));
        instance.transform.SetParent(gamefield);

       gamefieldmanager.AddToDictionary(x, y);
    }

    public void GenerateField()
    {
        gamefield = new GameObject("Game Field").transform;


        //gamefieldmanagerscript = gamefieldmanager.GetComponent<GameFieldManager>();


        int t = 0;
        for (int x = -gridsize; x <= gridsize; x++)
        {
            if (x <= 0)
            {
                for (int y = t; y <= gridsize; y++)
                {
                    CreateHex(x, y);

                }
                t--;
            }
            else
            {
                for (int y = -gridsize; y < -t - 1; y++)
                {
                    CreateHex(x, y);

                }
                t++;
            }
        }
    }

	
}

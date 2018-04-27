using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour {


    public int gridsize;

    public GameObject Hex;
    private Transform fieldcontainer;
    private Vector2 truecoords = new Vector2();
    public FieldController fieldController;
    public HexCalculator hexCalculator;

    public GameObject grass, forest, rocks, lake, flag, water;



    void CreateHex(int x, int y)
    {
        HexProperties hex;

        fieldController.AddToDictionary(x, y);         // Creating actual hex

        fieldController.hexProperties.TryGetValue(new Vector2Int(x, y), out hex);
        hex.type = fieldController.RandomTileType();            //rolling hex type
        
        switch(hex.type)                //WHAT THE FUCK
        {


            case "grass":
                Hex = grass;
                break;
            case "forest":
                Hex = forest;
                break;
            case "rocks":
                Hex = rocks;
                break;
            case "lake":
                Hex = lake;
                break;
            case "water":
                Hex = water;
                break;
            default:
                Debug.Log("smthing goes wrong");
                break;
        }
        if(x == 0 && (y == gridsize - 1 || y == -gridsize + 1))
        {
            hex.type = "flag";
            Hex = flag;
        }


        truecoords = hexCalculator.HexToPixel(x,y);
        GameObject instance = Instantiate(Hex, truecoords, Quaternion.Euler(0, 0, 0)); //Creating visual hex
        instance.transform.SetParent(fieldcontainer);
        fieldController.hextiles.Add(instance);


    }



    public void GenerateField()
    {
        fieldcontainer = new GameObject("Game Field").transform;


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

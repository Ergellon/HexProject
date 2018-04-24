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



    void CreateHex(int x, int y)
    {
        truecoords = hexCalculator.HexToPixel(x,y);
        GameObject instance = Instantiate(Hex, truecoords, Quaternion.Euler(0, 0, 0));
        instance.transform.SetParent(fieldcontainer);

        fieldController.AddToDictionary(x, y);
    }

    public void GenerateField()
    {
        fieldcontainer = new GameObject("Game Field").transform;


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

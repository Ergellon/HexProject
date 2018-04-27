using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitGenerator : MonoBehaviour {



    public Vector2Int unit1pos, unit2pos;

    public UnitController unitcontroller;
    public HexCalculator hexcalculator;
    public GameObject infantry;


    public void CreateUnit(int x, int y, int owner)
    {
        UnitProperties unit = new UnitProperties();
        unitcontroller.unitProperties.Add(new Vector2Int(x,y), unit);

        Vector3 truecoords = hexcalculator.HexToPixel(x,y);
        GameObject instance = Instantiate(infantry, truecoords, Quaternion.Euler(0,0,0));


    }

    public void GenerateUnits()
    {
        CreateUnit(unit1pos.x, unit1pos.y, 1);
        CreateUnit(unit2pos.x, unit2pos.y, 2);
    }


}

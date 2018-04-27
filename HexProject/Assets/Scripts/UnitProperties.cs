using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitProperties {


    public string type;
    public int owner;

    public GameObject sprite;

    public UnitProperties()
    {

    }
    public UnitProperties(int own)
    {
        owner = own;
    }
    
}

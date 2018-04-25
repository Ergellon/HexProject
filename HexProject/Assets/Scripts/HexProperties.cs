using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexProperties {

    public string type = null;
    public bool isoccupied = false;
    public bool isborder = false;
    public bool isblocker = false;

    public HexProperties()
    {
        type = "grass";
    }

    public HexProperties(string t)
    {
        type = t;
    }

}

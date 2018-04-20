using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFieldManager : MonoBehaviour {

    public Dictionary<Vector2Int, HexProperties> hexProperties = new Dictionary<Vector2Int, HexProperties>();

    public void AddToDictionary(int x, int y)
    {

       hexProperties.Add(new Vector2Int(x, y), new HexProperties());
        
    }
    public void PrintToLog ()
    {

    }

}

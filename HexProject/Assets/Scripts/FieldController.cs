using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour {

    public List<GameObject> hextiles = new List<GameObject>();

    public Dictionary<Vector2Int, HexProperties> hexProperties = new Dictionary<Vector2Int, HexProperties>();


    public void AddToDictionary(int x, int y)
    {
        hexProperties.Add(new Vector2Int(x, y), new HexProperties());
    }

    public string RandomTileType()
    {
        string t;
        int r = Random.Range(0,5);
        switch (r)
        {
            case 0:
                t = "forest";
                break;
            case 1:
                t = "rocks";
                break;
            case 2:
                t = "lake";
                break;
            default:
                t = "grass";
                break;
        }
        Debug.Log("works");
        return t;
    }
}

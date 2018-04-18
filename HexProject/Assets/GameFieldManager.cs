using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFieldManager : MonoBehaviour {

    public static GameFieldManager gameFieldManager = null;

    public List<Vector2Int> hexCoordinates = new List<Vector2Int>();
    public Dictionary<Vector2Int, HexProperties> hexProperties = new Dictionary<Vector2Int, HexProperties>();

    public void AddToDictionary(int x, int y)
    {
        hexCoordinates.Add(new Vector2Int(x, y));
       // hexProperties.Add(new Vector2Int(x, y), new HexProperties());
        
    }

    public void PrintList()
    {
        foreach(Vector2Int temp in hexCoordinates)
        {
            Debug.LogFormat("x={0} y={1}",temp.x,temp.y);
        }
    }



    void Start () {
		
        
	}
	
	void Update () {
		
	}
    

}

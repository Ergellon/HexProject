using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameFieldManager : MonoBehaviour {

    public Dictionary<Vector2Int, HexProperties> hexProperties = new Dictionary<Vector2Int, HexProperties>();


    public void AddToDictionary(int x, int y)
    {
        string t;
        t = Randomizer();
        

       hexProperties.Add(new Vector2Int(x, y), new HexProperties(t));
        
    }

    public string Randomizer()
    {
        string t = "bug";
        int r = Random.Range(0, 2);
        switch (r)
        {
            case 0:
                t = "forest";
                break;
            case 1:
                t = "plain";
                break;
            case 2:
                t = "hill";
                break;
        }

        return t;
    }

}

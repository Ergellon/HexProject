using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GridGenerator generator;
    public GameFieldManager gamefieldmanager;
    public Camera maincamera;


	void Start () {

        generator.GenerateField();
		
	}
	
	void Update ()
    {
        if(Input.GetButton("Fire1"))
        {
            Vector2 truecoords;
            truecoords = maincamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2Int hexcoords = new Vector2Int();
            hexcoords.x = (int)(2f/ 3f * truecoords.x*2f);
            hexcoords.y = (int)(-1f / 3f * truecoords.x*2f + Mathf.Sqrt(3) / 3 * truecoords.y*2f);

            Debug.LogFormat("x={0} y={1}", hexcoords.x, hexcoords.y);

            HexProperties field;
            gamefieldmanager.hexProperties.TryGetValue(hexcoords, out field);
            Debug.Log(field.type);

        }
    }
}

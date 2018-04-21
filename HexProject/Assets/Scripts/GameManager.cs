using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public FieldGenerator fieldgenerator;
    public FieldController fieldcontroller;
    public Camera maincamera;

    [SerializeField]
    public Text text;
    public Text text2;

	void Start () {
        
        fieldgenerator.GenerateField();
		
	}
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 truecoords;
            Vector2Int hexcoords;
            truecoords = maincamera.ScreenToWorldPoint(Input.mousePosition);

            
            Vector3 cubecoords = new Vector3((2f / 3f * truecoords.x * 2f), (-1f / 3f * truecoords.x * 2f + Mathf.Sqrt(3) / 3 * truecoords.y * 2f), -truecoords.x - truecoords.y);

            cubecoords.x = Mathf.Round(cubecoords.x);
            cubecoords.y = Mathf.Round(cubecoords.y);
            cubecoords.z = Mathf.Round(cubecoords.z);

            float x_diff = Mathf.Abs(cubecoords.x - truecoords.x);
            float y_diff = Mathf.Abs(cubecoords.y - truecoords.y);
            float z_diff = Mathf.Abs(cubecoords.z - truecoords.z);

            if ((x_diff > y_diff) && (x_diff > z_diff))
            {
                cubecoords.x = -cubecoords.y - cubecoords.z;
            }
            else
                if (y_diff > z_diff)
            {
                cubecoords.y = cubecoords.x - cubecoords.z;
            }
            else
            {
                cubecoords.z = cubecoords.x - cubecoords.y;
            }




            hexcoords = new Vector2Int((int)cubecoords.x, (int)cubecoords.y);
            //hexcoords.x = (2f/ 3f * truecoords.x*2f);
            // hexcoords.y = (-1f / 3f * truecoords.x*2f + Mathf.Sqrt(3) / 3 * truecoords.y*2f);

            text.text = "x=" + hexcoords.x + " y=" + hexcoords.y + "   ";
            //Debug.LogFormat("x={0} y={1}", hexcoords.x, hexcoords.y);

            HexProperties field;
            fieldcontroller.hexProperties.TryGetValue(hexcoords, out field);
            //Debug.Log(field.type);
            text.text += field.type;
            
        }

    }
}

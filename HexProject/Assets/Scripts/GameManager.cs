using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public FieldGenerator fieldgenerator;
    public FieldController fieldcontroller;
    public Camera maincamera;
    public HexCalculator hexcalculator;

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
            truecoords = maincamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2Int hexcoords = hexcalculator.MousePositionToHex(truecoords);

            text.text = "x=" + hexcoords.x + " y=" + hexcoords.y + "   ";

            HexProperties field;
            fieldcontroller.hexProperties.TryGetValue(hexcoords, out field);
            text.text += field.type;
            
        }

    }
}

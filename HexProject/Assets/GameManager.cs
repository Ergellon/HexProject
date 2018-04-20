using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GridGenerator generator;
    public GameFieldManager fieldmanager;


	void Start () {

        generator.GenerateField();
        //filling dictionary
        //randomizing tiles

		
	}
	
	void Update () {
		
	}
}

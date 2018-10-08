using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip1Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, Time.deltaTime*8, 0);


    }
}

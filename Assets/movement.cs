using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public Material InnerColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("w")) {
			transform.Translate(0, 0, 5);
		}
		if (Input.GetKeyDown ("s")) {
			transform.Translate(0, 0, -5);
		}
		if (Input.GetKeyDown ("a")) {
			transform.Translate(-5, 0, 0);
		}
		if (Input.GetKeyDown ("d")) {
			transform.Translate(5, 0, 0);
		}


			
		//var x = Input.GetAxis("Horizontal") * Time.deltaTime * 170.0f;
		//var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

		//transform.Rotate(0, x, 0);
		//transform.Translate(0, 0, z);
	}



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	private bool start;
	private bool first;
	private bool second;

	public GameObject box1;
	public GameObject box2;

	// Use this for initialization
	void Start () {
		start = true;
		first = false;
		second = false;

	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetKeyDown("r"))&& (start == true)){
			transform.position = new Vector3 (3.5f, 6.87f, -23.1f);
		}
		if((Input.GetKeyDown("r"))&& (first == true)){
			transform.position = new Vector3 (3.5f, 6.87f, 40.7f);
		}
		if((Input.GetKeyDown("r"))&& (second == true)){
			transform.position = new Vector3 (3.5f, 6.87f, 125f);
		}
			
		
	}

	void OnTriggerEnter(Collider col){
		
		if (col.gameObject == box1) {
			start = false;
			first = true;

		}
		if (col.gameObject == box2) {
			first = false;
			second = true;

		}
	}


}

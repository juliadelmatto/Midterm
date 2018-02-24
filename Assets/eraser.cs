using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eraser : MonoBehaviour {
	public Rigidbody rb;
	public GameObject button;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		//make sure script is correst, and numbers are all correct
		if(button.GetComponent<squarereset> ().check == true){
		Debug.Log ("hey");
		//rb.velocity = new Vector3 (1f,rb.velocity.y, rb.velocity.z);
			rb.isKinematic = false;
			rb.useGravity = true;
		}
	}
}

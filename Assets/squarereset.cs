using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squarereset : MonoBehaviour {
	
	public byte r;
	public byte g;
	public byte b;
	public byte a;

	private int num;
	public bool check;

	MeshRenderer material;

	// Use this for initialization
	void Start () {
		
		material = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (material.material.color == new Color32 (r, g, b, a)) {
			check = true;
		} else {
			check = false;
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "player") {
			//set platform color to purple 
			GetComponent<MeshRenderer> ().material.color = new Color32 (255, 0, 0, 255);
			//Debug.Log ("red");
		}
	}
}

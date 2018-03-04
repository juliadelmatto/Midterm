using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c3 : MonoBehaviour {

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
		num = 0;
	}

	// Update is called once per frame
	void Update () {
		//if r is pressed
		if(Input.GetKeyDown("r")){
			//set color of squares to white
			GetComponent<MeshRenderer> ().material.color = new Color32 (255, 255, 255, 255);
			//set num to zero 
			num = 0;
		}
		//if color is the same as the one in inspector
		if (material.material.color == new Color32 (r, g, b, a)) {
			//check is true
			check = true;
		} else {
			check = false;
		}
	}

	//when player walks on platform, the platforms change color
	void OnTriggerEnter(Collider other){
		if ((other.gameObject.tag == "player") && (num == 0)) {
			//set platform color to brown
			GetComponent<MeshRenderer> ().material.color = new Color32 (12, 54, 191, 1);
			Debug.Log ("dblue");
		}
		if ((other.gameObject.tag == "player") && (num == 1)) {
			//set platform color to green
			GetComponent<MeshRenderer> ().material.color = new Color32 (243, 233, 149, 1);
			Debug.Log ("yellow");
		}
		if ((other.gameObject.tag == "player") && (num == 2)) {
			//set platform color to blue
			GetComponent<MeshRenderer> ().material.color = new Color32 (146, 203, 240, 1);
			Debug.Log ("lightblue");
		}
		if ((other.gameObject.tag == "player") && (num == 3)) {
			//set platform color to blue
			GetComponent<MeshRenderer> ().material.color = new Color32 (240, 146, 203, 1);
			Debug.Log ("pink");
		}
		if (other.gameObject.tag == "eraser") {
			GetComponent<MeshRenderer> ().material.color = new Color32 (255, 255, 255, 255);
		}
	}

	//when player exits platform, the num increases so the next time they step on the platform it will be a different color
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "player") {
			num++;
			if (num == 4) {
				num = 0;
			}
		}
	}
}
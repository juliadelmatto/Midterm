using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c2 : MonoBehaviour {


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

		if (material.material.color == new Color32 (r, g, b, a)) {
			check = true;
		} else {
			check = false;
		}
	}

	//when player walks on platform
	void OnTriggerEnter(Collider other){
		if ((other.gameObject.tag == "player") && (num == 0)) {
			//set platform color to brown
			GetComponent<MeshRenderer> ().material.color = new Color32 (125, 86, 57, 1);
			Debug.Log ("brown");
		}
		if ((other.gameObject.tag == "player") && (num == 1)) {
			//set platform color to green
			GetComponent<MeshRenderer> ().material.color = new Color32 (131, 200, 125, 1);
			Debug.Log ("green");
		}
		if ((other.gameObject.tag == "player") && (num == 2)) {
			//set platform color to blue
			GetComponent<MeshRenderer> ().material.color = new Color32 (83, 185, 232, 1);
			Debug.Log ("blue");
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "player") {
			num++;
			if (num == 3) {
				num = 0;
			}
		}
	}
}
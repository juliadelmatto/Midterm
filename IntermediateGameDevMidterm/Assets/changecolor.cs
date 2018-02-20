using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour {
	

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
			//set platform color to purple 
			GetComponent<MeshRenderer> ().material.color = new Color32 (131, 75, 189, 255);
			Debug.Log ("purple");
		}
		if ((other.gameObject.tag == "player") && (num == 1)) {
			//set platform color to blue 
			GetComponent<MeshRenderer> ().material.color = new Color32 (63, 191, 191, 1);
			Debug.Log ("blue");
		}

		if (other.gameObject.tag == "eraser") {
			GetComponent<MeshRenderer> ().material.color = new Color32 (255, 255, 255, 255);
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "player") {
			num++;
			if (num == 2) {
				num = 0;
			}
		}
	}
}

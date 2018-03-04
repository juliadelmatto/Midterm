using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

//	private bool start;
//	private bool first;
//	private bool second;

	public GameObject box1;
	public GameObject box2;

	public bool start;
	public bool second;
	public bool third;

	public Camera cam1;
	public Camera cam2;
	public Camera cam3;

	// Use this for initialization
	void Start () {
		start = true;
		second = false;
		third = false;

		cam1.gameObject.SetActive(true);
		cam2.gameObject.SetActive(false);
		cam3.gameObject.SetActive(false);
//		start = false;
//		first = false;
//		second = false;

	}
	
	// Update is called once per frame
	void Update () {
//		if((Input.GetKeyDown("r"))&& (start == true)){
//			transform.position = new Vector3 (3.5f, 6.87f, -23.1f);
//		}
//		if((Input.GetKeyDown("r"))&& (first == true)){
//			transform.position = new Vector3 (3.5f, 6.87f, 40.7f);
//		}
//		if((Input.GetKeyDown("r"))&& (second == true)){
//			transform.position = new Vector3 (3.5f, 6.87f, 125f);
//		}

		if ((GetComponent<Rigidbody> ().position.y < 5) && (start == true)){
			transform.position = new Vector3 (1.28f, 7.05f, -65.61f);
		}
		if ((GetComponent<Rigidbody> ().position.y < 5) && (second == true)){
			transform.position = new Vector3 (3.96f, 7.057f, -16.36f);
		}
		if ((GetComponent<Rigidbody> ().position.y < 5) && (third == true)){
			transform.position = new Vector3 (8.9f, 7.05f, 44f);
		}
	}

	void OnTriggerEnter(Collider col){
		
		if (col.gameObject == box1) {
			transform.position = new Vector3 (3.96f, 7.057f, -16.36f);
			cam1.gameObject.SetActive(false);
			cam2.gameObject.SetActive(true);
			start = false;
			second = true;
//			first = false;
//			second = true;
//
		}
		if (col.gameObject == box2) {
			transform.position = new Vector3 (8.9f, 7.05f, 44f);
			cam2.gameObject.SetActive(false);
			cam3.gameObject.SetActive(true);
			second = false;
			third = true;
//			first = false;
//			second = true;

		}
	}


}

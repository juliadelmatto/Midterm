using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall2 : MonoBehaviour {

	public GameObject platform1;
	public GameObject platform2;
	public GameObject platform3;
	public GameObject platform4;
	public GameObject platform5;
	public GameObject platform6;
	public GameObject platform7;
	public GameObject platform8;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//if square == whatever color, and other square == whatever color

		if ((platform1.GetComponent<c2> ().check == true)&&(platform2.GetComponent<c2> ().check == true)&&(platform3.GetComponent<c2> ().check == true)&&(platform4.GetComponent<c2> ().check == true)&&(platform5.GetComponent<c2> ().check == true)&&(platform6.GetComponent<c2> ().check == true)&&(platform7.GetComponent<squarereset> ().check == true)&&(platform8.GetComponent<squarereset> ().check == true)) {
			this.gameObject.SetActive(false);
		}

	}
}
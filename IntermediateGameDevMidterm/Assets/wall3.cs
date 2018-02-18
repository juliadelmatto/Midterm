using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall3 : MonoBehaviour {

	public GameObject platform111;
	public GameObject platform222;
	public GameObject platform333;
	public GameObject platform444;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//if square == whatever color, and other square == whatever color

		if ((platform111.GetComponent<c3> ().check == true)&&(platform222.GetComponent<c3> ().check == true)&&(platform333.GetComponent<c3> ().check == true)&&(platform444.GetComponent<c3> ().check == true)) {
			this.gameObject.SetActive(false);
		}

	}
}
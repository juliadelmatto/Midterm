using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall2 : MonoBehaviour {

	public GameObject platform11;
	public GameObject platform22;
	public GameObject platform33;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//if square == whatever color, and other square == whatever color

		if ((platform11.GetComponent<c2> ().check == true)&&(platform22.GetComponent<c2> ().check == true)&&(platform33.GetComponent<c2> ().check == true)) {
			this.gameObject.SetActive(false);
		}

	}
}
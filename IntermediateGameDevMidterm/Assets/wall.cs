using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {

	public GameObject platform1;
	public GameObject platform2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if square == whatever color, and other square == whatever color

		if ((platform1.GetComponent<changecolor> ().check == true)&&(platform2.GetComponent<changecolor> ().check == true)) {
			this.gameObject.SetActive(false);
		}
			
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour {
	public GameObject box;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	public void change(string scenename){
//		if (check == true) {
//			Application.LoadLevel (scenename);
//		}
//
//	}
//
	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "end") {
			SceneManager.LoadScene ("end");
		}
	
	}
}


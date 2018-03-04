using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public void change(string scenename){
		Application.LoadLevel (scenename);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {

	public GameObject platform1;
	public GameObject platform2;

	public GameObject platform3;
	public GameObject platform4;
	public GameObject platform5;
	public GameObject platform6;
	public GameObject platform7;
	public GameObject platform8;
	public GameObject platform9;
	public GameObject platform10;
	public GameObject platform11;
	public GameObject platform12;
	public GameObject platform13;
	public GameObject platform14;
	public GameObject platform15;
	public GameObject platform16;
	public GameObject platform17;
	public GameObject platform18;
	public GameObject platform19;
	public GameObject platform20;
	public GameObject platform21;
	public GameObject platform22;
	public GameObject platform222;
	public GameObject platform23;
	public GameObject platform24;
	public GameObject platform25;
	public GameObject platform26;
	public GameObject platform27;
	public GameObject platform28;
	public GameObject platform29;
	public GameObject platform30;
	public GameObject platform31;
	public GameObject platform32;
	public GameObject platform33;
	public GameObject platform34;
	public GameObject platform35;
	public GameObject platform36;
	public GameObject platform37;
	public GameObject platform38;
	public GameObject platform39;
	public GameObject platform40;
	public GameObject platform41;
	public GameObject platform42;
	public GameObject platform43;
	public GameObject platform44;
	public GameObject platform45;
	public GameObject platform46;
	public GameObject platform47;
	public GameObject platform48;
	public GameObject platform49;
	public GameObject platform50;
	public GameObject platform51;
	public GameObject platform52;
	public GameObject platform53;
	public GameObject platform54;
	public GameObject platform55;
	public GameObject platform56;
	public GameObject platform57;
	public GameObject platform58;
	public GameObject platform59;
	public GameObject platform60;
	public GameObject platform61;
	public GameObject platform62;
	public GameObject platform63;
	public GameObject platform64;
	public GameObject platform65;
	public GameObject platform66;
	public GameObject platform67;
	public GameObject platform68;
	public GameObject platform69;
	public GameObject platform70;
	public GameObject platform71;
	public GameObject platform72;
	public GameObject platform73;
	public GameObject platform74;
	public GameObject platform75;
	public GameObject platform76;






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

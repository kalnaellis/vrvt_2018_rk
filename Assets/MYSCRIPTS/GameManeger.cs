using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour {

	public Transform appleStartPoz;
	public GameObject apple;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		 if (Input.GetMouseButtonDown(0)){
			  Instantiate(apple, appleStartPoz.position, appleStartPoz.rotation);
		 }

	}

}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationSwich : MonoBehaviour {

public GameObject sit;
public GameObject jump;
 public Animator anim ;
bool j = true;


	// Use this for initialization
	void Start () {
	anim.StartPlayback();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 void OnCollisionEnter(Collision col)
    {
		if (j){
		sit.SetActive(false);
		jump.SetActive(true);
		j = false;
		anim.StopPlayback();
		
		}
		else
		{
		sit.SetActive(true);
		jump.SetActive(false);
		j = true;
		anim.StartPlayback();
		}

    }

}

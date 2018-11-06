using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objA : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameControl.increaseSize += onIncreaseSize;		
		GameControl.decreaseSize += onDecreaseSize;		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onIncreaseSize(float f) {
		transform.localScale = transform.localScale + (Vector3.one * f);
		print ("Increase! " + f);
		
	}

	void onDecreaseSize(float f) {
		transform.localScale = transform.localScale - (Vector3.one * f);
		print ("Decrease!" + f);
	}
}

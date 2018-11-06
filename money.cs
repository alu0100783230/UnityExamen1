using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameControl.updateMoney += onUpdateMoney;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onUpdateMoney (float m, float p) {		
		GetComponent<Text>().text = "Money: " + m + " | Power: " + p;
	}
}

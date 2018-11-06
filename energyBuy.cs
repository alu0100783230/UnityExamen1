using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyBuy : MonoBehaviour {

	private Button sl;
	// Use this for initialization
	void Start () {
		
	        sl = GetComponent<Button>();
		sl.onClick.AddListener(delegate {ButtonClicked(); });	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 void ButtonClicked() {
		GameControl.buyPower();

    }

	
}

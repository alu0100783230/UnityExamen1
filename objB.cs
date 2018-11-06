using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objB : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameControl.changeColor += onChangeColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onChangeColor() {
		 Renderer rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("_Color");
		 rend.material.SetColor("_Color", Color.yellow);	
		print ("COLOR! " );		
	}

	void OnCollisionEnter(Collision collision)
    {
	GameControl.emitIncreaseSize();
    }
}

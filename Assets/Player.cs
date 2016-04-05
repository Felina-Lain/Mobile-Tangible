using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	void Start(){
		
		if (this.tag == "Player1") {
			this.GetComponent<Renderer> ().material.color = Manager.Player1S;
		}
		if (this.tag == "Player2") {
			this.GetComponent<Renderer> ().material.color = Manager.Player2S;
		}
		
	}


	
	// Update is called once per frame
	void Update () {
				
		if (this.tag == "Player1") {
			this.GetComponent<Renderer> ().material.color = Manager.Player1S;
		}
		if (this.tag == "Player2") {
			this.GetComponent<Renderer> ().material.color = Manager.Player2S;
		}
		
		
	}
		
}
